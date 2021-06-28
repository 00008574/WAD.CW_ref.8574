using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD_8574.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        
        public string Title { get; set; }

       
        public int Credits { get; set; }

        public int DepartmentId { get; set; }

        
        public ICollection<Enrollment> Enrollments { get; set; }
        
    }
}
