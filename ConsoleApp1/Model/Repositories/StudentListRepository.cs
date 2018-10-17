using ConsoleAppOpenClose.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOpenClose.Model.Repositories
{
    public class StudentListRepository : IStudentRepository
    {
        private static List<Student> _student = new List<Student>();

        public void Add(Student student)
        {
            _student.Add(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return _student;
        }
    }
}
