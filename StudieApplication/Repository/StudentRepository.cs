using StudieApplication.Context;
using StudieApplication.Models;

namespace StudieApplication.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyContext _myDbConnection;

        public StudentRepository(MyContext myContext)
        {
            _myDbConnection = myContext;
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                List<Student> students = (from stdobj in _myDbConnection.Students
                                          select stdobj).ToList();
                            return students;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public void Create(Student student)
        {
            _myDbConnection.Students.Add(student);
            _myDbConnection.SaveChanges();
        }

        public void Delete(int Id)
        {
            Student student = (from stdobj in _myDbConnection.Students
                               where stdobj.StudentId == Id
                               select stdobj).FirstOrDefault();
            _myDbConnection.Students.Remove(student);
            _myDbConnection.SaveChanges();
        }

        public void Register(int studentId, int courseId)
        {
            StudentCourse Obj = new StudentCourse();
            Obj.CourseId = courseId;
            Obj.StudentId = studentId;

            _myDbConnection.Add(Obj);
            _myDbConnection.SaveChanges();
        }
    }
}
