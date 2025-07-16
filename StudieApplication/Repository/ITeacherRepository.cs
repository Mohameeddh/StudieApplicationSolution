using StudieApplication.Models;

namespace StudieApplication.Repository
{
    public interface ITeacherRepository
    {
        public List<Teacher> GetAllTeachers();

        public void Creat(Teacher teacher);

        public void Delete(int Id);
    }
}
