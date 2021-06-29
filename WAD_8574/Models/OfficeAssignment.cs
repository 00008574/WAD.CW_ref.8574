using System.ComponentModel.DataAnnotations;

namespace WAD_8574.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int TutorId { get; set; }

        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Tutor Tutor { get; set; }
    }
}