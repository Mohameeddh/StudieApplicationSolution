using Microsoft.AspNetCore.Mvc;
using StudieApplication.Models;
using StudieApplication.Repository;

namespace StudieApplication.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Course> courses = _courseRepository.GetAllCourses();
            return View(courses);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            _courseRepository.Create(course);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _courseRepository.Delete(id);
            return View();
        }
    }
}
