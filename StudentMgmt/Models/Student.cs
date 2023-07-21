namespace StudentMgmt.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime Enrolled { get; set; }
        public ICollection<StudentCourse> Enrollment { get; set; }
    }
}

