using Microsoft.AspNetCore.Mvc;
using StudentMgmt.Data;
using StudentMgmt.Models;

namespace StudentMgmt.Controllers
{
    public class CoursesController : Controller
    {
        private readonly DataContext _context;
        public CoursesController(DataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// All Get Methods
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var course = _context.Courses.Where(x => x.Id == id).FirstOrDefault();
            return View(course);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var course = _context.Courses.Where(x=> x.Id == id).FirstOrDefault();
            return View(course);
        }
        public IActionResult Delete(int id)
        {
            var course = _context.Courses.Where(x => x.Id == id).FirstOrDefault();
            return View(course);
        }
        /// <summary>
        /// All POST Methods
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Course model)
        {
            _context.Courses.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");   
        }
        [HttpPost]
        public IActionResult Edit(Course model)
        {
            _context.Courses.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Course model)
        {
            _context.Courses.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
