namespace WAD_8574.Models
{
    public class CourseAssignment
    {
        public int TutorId { get; set; }
        public int CourseId { get; set; }
        public Tutor Tutor { get; set; }
        public Course Course { get; set; }
    }
}