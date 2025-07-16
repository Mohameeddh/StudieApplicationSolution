using StudieApplication.Models;
using StudieApplication.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StudieApplication.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly MyContext _myDbConnection;

        public TeacherRepository(MyContext myContext)
        {
            _myDbConnection = myContext;
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = (from tchObj in _myDbConnection.Teachers
                                    select tchObj).ToList();
            return teachers;
        }

        public void Creat(Teacher teacher)
        {
            _myDbConnection.Teachers.Add(teacher);
            _myDbConnection.SaveChanges();
        }

        public void Delete(int Id)
        {
            Teacher teacher = (from tchObj in _myDbConnection.Teachers
                               where tchObj.TeacherId == Id
                               select tchObj).FirstOrDefault();
            _myDbConnection.Teachers.Remove(teacher);
            _myDbConnection.SaveChanges();
        }

    }
}
