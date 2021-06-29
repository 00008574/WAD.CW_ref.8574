using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WAD_8574.Data;
using WAD_8574.Models;
using WAD_8574.Models.SchoolViewModels;

namespace WAD_8574.Controllers
{
    public class TutorsController : Controller
    {
        private readonly SchoolContext _context;

        public TutorsController(SchoolContext context)
        {
            _context = context;
        }

        // GET: Tutors
        public async Task<IActionResult> Index(int? id, int? courseId)
        {
            var viewModel = new TutorIndexData();
            viewModel.Tutors = await _context.Tutors
                .Include(i => i.OfficeAssignment)
                .Include(i => i.CourseAssignments)
                    .ThenInclude(i => i.Course)
                        .ThenInclude(i => i.Enrollments)
                            .ThenInclude(i => i.Student)
                .Include(i => i.CourseAssignments)
                    .ThenInclude(i => i.Course)
                        .ThenInclude(i => i.Department)
                .OrderBy(i => i.LastName)
                .ToListAsync();

            if (id != null)
            {
                ViewData["TutorId"] = id.Value;
                Tutor Tutor = viewModel.Tutors.Where(i => i.ID == id.Value).Single();
                viewModel.Courses = Tutor.CourseAssignments.Select(s => s.Course);
            }

            if (courseId != null)
            {
                ViewData["CourseId"] = courseId.Value;
                var selectedCourse = viewModel.Courses.Where(x => x.CourseId == courseId).Single();

                await _context.Entry(selectedCourse).Collection(x => x.Enrollments).LoadAsync();

                foreach (Enrollment enrollment in selectedCourse.Enrollments)
                {
                    await _context.Entry(enrollment).Reference(x => x.Student).LoadAsync();
                }
                viewModel.Enrollments = selectedCourse.Enrollments;
            }

            return View(viewModel);
        }

        // GET: Tutors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tutor == null)
            {
                return NotFound();
            }

            return View(tutor);
        }

        // GET: Tutors/Create
        public IActionResult Create()
        {
            var tutor = new Tutor();
            tutor.CourseAssignments = new List<CourseAssignment>();
            PopulateAssignedCourseData(tutor);
            return View();
        }

        // POST: Tutors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstMidName,HireDate,LastName,OfficeAssignment")] Tutor tutor, string[] selectedCourses)
        {
            if (selectedCourses != null)
            {
                tutor.CourseAssignments = new List<CourseAssignment>();
                foreach (var course in selectedCourses)
                {
                    var courseToAdd = new CourseAssignment
                    {
                        TutorId = tutor.ID,
                        CourseId = int.Parse(course)
                    };
                    tutor.CourseAssignments.Add(courseToAdd);
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(tutor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateAssignedCourseData(tutor);
            return View(tutor);
        }

        // GET: Tutors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutors
                .Include(i => i.OfficeAssignment)
                .Include(i => i.CourseAssignments)
                    .ThenInclude(i => i.Course)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (tutor == null)
            {
                return NotFound();
            }

            PopulateAssignedCourseData(tutor);
            return View(tutor);
        }

        private void PopulateAssignedCourseData(Tutor tutor)
        {
            var allCourses = _context.Courses;
            var tutorCourses = new HashSet<int>(tutor.CourseAssignments.Select(c => c.CourseId));
            var viewModel = new List<AssignedCourseData>();

            foreach (var course in allCourses)
            {
                viewModel.Add(new AssignedCourseData
                {
                    CourseId = course.CourseId,
                    Title = course.Title,
                    Assigned = tutorCourses.Contains(course.CourseId)
                });
            }
            ViewData["Courses"] = viewModel;
        }

        // POST: Tutors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, string[] selectedCourses)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorToUpdate = await _context.Tutors
                    .Include(i => i.OfficeAssignment)
                    .Include(i => i.CourseAssignments)
                        .ThenInclude(i => i.Course)
                    .FirstOrDefaultAsync(s => s.ID == id);

            if (await TryUpdateModelAsync<Tutor>(
                tutorToUpdate,
                "",
                i => i.FirstMidName, i => i.LastName, i => i.HireDate, i => i.OfficeAssignment))
            {
                if (String.IsNullOrWhiteSpace(tutorToUpdate.OfficeAssignment?.Location))
                {
                    tutorToUpdate.OfficeAssignment = null;
                }
                UpdateTutorCourses(selectedCourses, tutorToUpdate);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to save changes. Please restart!");
                }
                return RedirectToAction(nameof(Index));
            }

            UpdateTutorCourses(selectedCourses, tutorToUpdate);
            PopulateAssignedCourseData(tutorToUpdate);
            return View(tutorToUpdate);
        }

        private void UpdateTutorCourses(string[] selectedCourses, Tutor tutorToUpdate)
        {
            if (selectedCourses == null)
            {
                tutorToUpdate.CourseAssignments = new List<CourseAssignment>();
                return;
            }

            var selectedCoursesNotNull = new HashSet<string>(selectedCourses);
            var tutorCourses = new HashSet<int>
                    (tutorToUpdate.CourseAssignments.Select(c => c.Course.CourseId));
            foreach (var course in _context.Courses)
            {
                if (selectedCoursesNotNull.Contains(course.CourseId.ToString()))
                {
                    if (!tutorCourses.Contains(course.CourseId))
                    {
                        tutorToUpdate.CourseAssignments.Add(new CourseAssignment
                        {
                            TutorId = tutorToUpdate.ID,
                            CourseId = course.CourseId
                        });
                    }
                }
                else
                {
                    if (tutorCourses.Contains(course.CourseId))
                    {
                        CourseAssignment courseToRemove = tutorToUpdate.CourseAssignments.FirstOrDefault(i => i.CourseId == course.CourseId);
                        _context.Remove(courseToRemove);
                    }
                }
            }
        }

        // GET: Tutors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tutor == null)
            {
                return NotFound();
            }

            return View(tutor);
        }

        // POST: Tutors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Tutor tutor = await _context.Tutors
                        .Include(i => i.CourseAssignments)
                        .SingleAsync(i => i.ID == id);

            var departments = await _context.Departments
                    .Where(d => d.TutorId == id)
                    .ToListAsync();

            departments.ForEach(d => d.TutorId = null);

            _context.Tutors.Remove(tutor);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool TutorExists(int id)
        {
            return _context.Tutors.Any(e => e.ID == id);
        }
    }
}
