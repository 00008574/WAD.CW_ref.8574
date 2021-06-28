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

            var courses = new Course[]
            {
                new Course {CourseId = 101, Title = "WAD",      Credits = 20,

                },
                new Course {CourseId = 102, Title = "MAD", Credits = 20,

                },
                new Course {CourseId = 103, Title = "Marketing Management", Credits = 20,

                },
                new Course {CourseId = 104, Title = "Quality and Operations Management",       Credits = 20,

                },
                new Course {CourseId = 105, Title = "Company Law",   Credits = 20,

                },
                new Course {CourseId = 106, Title = "Intermediate Microeconomics",    Credits = 20,

                },
                new Course {CourseId = 107, Title = "Intermediate Macroeconomics",     Credits = 20,

                },
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment {StudentId = 1, CourseId = 101, Grade = Grade.A},
                new Enrollment {StudentId = 1, CourseId = 102, Grade = Grade.B},
                new Enrollment {StudentId = 1, CourseId = 103, Grade = Grade.A},
                new Enrollment {StudentId = 2, CourseId = 101, Grade = Grade.C},
                new Enrollment {StudentId = 2, CourseId = 102},
                new Enrollment {StudentId = 3, CourseId = 101},
                new Enrollment {StudentId = 3, CourseId = 102, Grade = Grade.B},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }


    }
}
