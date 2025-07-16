using Microsoft.AspNetCore.Mvc;
using StudieApplication.Models;
using StudieApplication.Repository;

namespace StudieApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Student> stdLst = _studentRepository.GetAllStudents();
            return View(stdLst);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            _studentRepository.Create(student);
            return View();
        }

        public ViewResult Delete(int id)
        {
            _studentRepository.Delete(id);
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(int studentId, int courseId)
        {
            _studentRepository.Register(studentId, courseId);
            return View();
        }
    }
    
}
