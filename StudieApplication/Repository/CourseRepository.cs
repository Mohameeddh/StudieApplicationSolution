using StudieApplication.Context;
using StudieApplication.Models;

namespace StudieApplication.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private readonly MyContext _myDbConnection;

        public CourseRepository(MyContext myDbConnection)
        {
            _myDbConnection = myDbConnection;
        }

        public List<Course> GetAllCourses()
        {
            List<Course> courses = (from cObj in _myDbConnection.Courses
                                    select cObj).ToList();
            return courses;
        }

        public void Create(Course course)
        {
            _myDbConnection.Add(course);
            _myDbConnection.SaveChanges();
        }

        public void Delete(int id)
        {
            Course courses = (from cObj in _myDbConnection.Courses
                              where cObj.CourseId == id
                              select cObj).FirstOrDefault();
        }
    }
}
