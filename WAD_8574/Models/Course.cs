using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WAD_8574.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        
        public string Title { get; set; }

       
        public int Credits { get; set; }

        public int DepartmentId { get; set; }

        
        public ICollection<Enrollment> Enrollments { get; set; }
        
    }
}
