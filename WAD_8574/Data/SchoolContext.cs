using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD_8574.Models;

namespace WAD_8574.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Department>().ToTable("Departments");
            modelBuilder.Entity<Tutor>().ToTable("Tutors");
            modelBuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignments");
            modelBuilder.Entity<CourseAssignment>().ToTable("CourseAssignments");

            modelBuilder.Entity<CourseAssignment>()
                    .HasKey(c => new { c.CourseId, c.TutorId });
        }
    }
}
