﻿using StudieApplication.Models;

namespace StudieApplication.Repository
{
    public interface IStudentRepository
    {
        public List<Student> GetAllStudents();
        public void Create(Student student);
        public void Delete(int Id);
        public void Register(int studentId, int courseId);
    }
}
