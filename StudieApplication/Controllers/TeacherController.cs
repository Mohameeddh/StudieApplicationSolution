using Microsoft.AspNetCore.Mvc;
using StudieApplication.Models;
using StudieApplication.Repository;

namespace StudieApplication.Controllers
{
    public class TeacherController : Controller
    {

        private readonly ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
           List<Teacher> teachers = _teacherRepository.GetAllTeachers();
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            _teacherRepository.Creat(teacher);
            return View(teacher);
        }

        public ActionResult Delete(int id)
        {
            _teacherRepository.Delete(id);
            return View(id);
        }
    }
}
