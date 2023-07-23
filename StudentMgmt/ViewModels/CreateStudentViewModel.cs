using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentMgmt.ViewModels
{
    public class CreateStudentViewModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime Enrolled { get; set; }
        public IList<SelectListItem> Courses { get; set; }
    }
}
