using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD_8574.Models;

namespace WAD_8574.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student { FirstMidName = "John",   LastName = "Black",
                    EnrollmentDate = DateTime.Parse("2019-01-01") },
                new Student { FirstMidName = "Amina", LastName = "Krix",
                    EnrollmentDate = DateTime.Parse("2020-01-01") },
                new Student { FirstMidName = "Milita",   LastName = "Smith",
                    EnrollmentDate = DateTime.Parse("2020-01-01") },
                new Student { FirstMidName = "Samuel",    LastName = "Adamson",
                    EnrollmentDate = DateTime.Parse("2020-01-01") },
                new Student { FirstMidName = "Amelia",    LastName = "Brown",
                    EnrollmentDate = DateTime.Parse("2019-01-01") },
                new Student { FirstMidName = "George",    LastName = "Wilson",
                    EnrollmentDate = DateTime.Parse("2020-01-01") },
                new Student { FirstMidName = "Harry",     LastName = "Davies",
                    EnrollmentDate = DateTime.Parse("2018-01-01") }
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var instructors = new Tutor[]
            {
                new Tutor { FirstMidName = "Jack",     LastName = "Smith",
                    HireDate = DateTime.Parse("2017-03-11") },
                new Tutor { FirstMidName = "Oliver",    LastName = "Davies",
                    HireDate = DateTime.Parse("2015-07-06") },
                new Tutor { FirstMidName = "Thomas",   LastName = "Evans",
                    HireDate = DateTime.Parse("2006-07-01") },
                new Tutor { FirstMidName = "Lily", LastName = "Taylor",
                    HireDate = DateTime.Parse("2008-01-15") },
                new Tutor { FirstMidName = "Emma",   LastName = "Charles",
                    HireDate = DateTime.Parse("2008-02-12") }
            };

            foreach (Tutor i in instructors)
            {
                context.Tutors.Add(i);
            }
            context.SaveChanges();

            var departments = new Department[]
            {
                new Department { Name = "Business Information System",     Budget = 150000,
                    StartDate = DateTime.Parse("2017-09-01"),
                    TutorId  = instructors.Single( i => i.LastName == "Smith").ID },
                new Department { Name = "Business management", Budget = 80000,
                    StartDate = DateTime.Parse("2017-09-01"),
                    TutorId  = instructors.Single( i => i.LastName == "Davies").ID },
                new Department { Name = "Economics", Budget = 150000,
                    StartDate = DateTime.Parse("2008-09-01"),
                    TutorId  = instructors.Single( i => i.LastName == "Evans").ID },
                new Department { Name = "Commercial law",   Budget = 80000,
                    StartDate = DateTime.Parse("2010-09-01"),
                    TutorId  = instructors.Single( i => i.LastName == "Taylor").ID }
            };

            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course {CourseId = 101, Title = "WAD",      Credits = 20,
                DepartmentId = departments.Single( s => s.Name == "Business Information System").DepartmentId
                },
                new Course {CourseId = 102, Title = "MAD", Credits = 20,
                DepartmentId = departments.Single( s => s.Name == "Business Information System").DepartmentId
                },
                new Course {CourseId = 103, Title = "Marketing Management", Credits = 20,
                DepartmentId = departments.Single( s => s.Name == "Business management").DepartmentId
                },
                new Course {CourseId = 104, Title = "Quality and Operations Management",       Credits = 20,
                DepartmentId = departments.Single( s => s.Name == "Business management").DepartmentId
                },
                new Course {CourseId = 105, Title = "Company Law",   Credits = 20,
                DepartmentId = departments.Single( s => s.Name == "Commercial law").DepartmentId
                },
                new Course {CourseId = 106, Title = "Intermediate Microeconomics",    Credits = 20,
                DepartmentId = departments.Single( s => s.Name == "Economics").DepartmentId
                },
                new Course {CourseId = 107, Title = "Macroeconomics",     Credits = 20,
                DepartmentId = departments.Single( s => s.Name == "Economics").DepartmentId
                },
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment {
                    TutorId = instructors.Single( i => i.LastName == "Smith").ID,
                    Location = "IB" },
                new OfficeAssignment {
                    TutorId = instructors.Single( i => i.LastName == "Davies").ID,
                    Location = "ATB" },
                new OfficeAssignment {
                    TutorId = instructors.Single( i => i.LastName == "Taylor").ID,
                    Location = "NB" },
            };

            foreach (OfficeAssignment o in officeAssignments)
            {
                context.OfficeAssignments.Add(o);
            }
            context.SaveChanges();

            var courseInstructors = new CourseAssignment[]
            {
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "WAD" ).CourseId,
                    TutorId = instructors.Single(i => i.LastName == "Smith").ID
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "WAD" ).CourseId,
                    TutorId = instructors.Single(i => i.LastName == "Smith").ID
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "MAD" ).CourseId,
                    TutorId = instructors.Single(i => i.LastName == "Charles").ID
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "MAD" ).CourseId,
                    TutorId = instructors.Single(i => i.LastName == "Charles").ID
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Marketing Management" ).CourseId,
                    TutorId = instructors.Single(i => i.LastName == "Davies").ID
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Marketing Management" ).CourseId,
                    TutorId = instructors.Single(i => i.LastName == "Davies").ID
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Company Law" ).CourseId,
                    TutorId = instructors.Single(i => i.LastName == "Taylor").ID
                    },
                new CourseAssignment {
                    CourseId = courses.Single(c => c.Title == "Intermediate Microeconomics" ).CourseId,
                    TutorId = instructors.Single(i => i.LastName == "Evans").ID
                    },
            };

            foreach (CourseAssignment ci in courseInstructors)
            {
                context.CourseAssignments.Add(ci);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Black").Id,
                    CourseId = courses.Single(c => c.Title == "WAD" ).CourseId,
                    Grade = Grade.A
                },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Black").Id,
                    CourseId = courses.Single(c => c.Title == "MAD" ).CourseId,
                    Grade = Grade.C
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Krix").Id,
                    CourseId = courses.Single(c => c.Title == "MAD" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Smith").Id,
                    CourseId = courses.Single(c => c.Title == "Marketing Management" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Smith").Id,
                    CourseId = courses.Single(c => c.Title == "Intermediate Microeconomics" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Adamson").Id,
                    CourseId = courses.Single(c => c.Title == "Company Law" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Adamson").Id,
                    CourseId = courses.Single(c => c.Title == "WAD" ).CourseId
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Brown").Id,
                    CourseId = courses.Single(c => c.Title == "MAD").CourseId,
                    Grade = Grade.B
                    },
                new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Wilson").Id,
                    CourseId = courses.Single(c => c.Title == "WAD").CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = students.Single(s => s.LastName == "Davies").Id,
                    CourseId = courses.Single(c => c.Title == "Company Law").CourseId,
                    Grade = Grade.B
                    }
            };

            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollments.Where(
                    s =>
                            s.Student.Id == e.StudentId &&
                            s.Course.CourseId == e.CourseId).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Enrollments.Add(e);
                }
            }
            context.SaveChanges();
        }


    }
}
