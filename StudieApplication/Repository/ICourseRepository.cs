using Microsoft.EntityFrameworkCore;
using StudieApplication.Models;

namespace StudieApplication.Repository
{
    public interface ICourseRepository
    {
        public List<Course> GetAllCourses();

        public void Create(Course course);

        public void Delete(int id);
    }
}
