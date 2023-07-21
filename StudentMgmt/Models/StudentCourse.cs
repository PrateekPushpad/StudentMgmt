using StudentMgmt.Models;

namespace StudentMgmt.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }

    }
}
namespace GettingStarted.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }

    }
}
