using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD_8574.Models
{
    public class Student
    {
        public int Id { get; set; }

        
        public string LastName { get; set; }

        
        public string FirstMidName { get; set; }

        
        public DateTime EnrollmentDate { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
