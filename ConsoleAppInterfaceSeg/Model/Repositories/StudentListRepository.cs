using ConsoleAppInterfaceSeg.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInterfaceSeg.Model.Repositories
{
    public class StudentListRepository : IStudentRepository
    {
        private static List<Student> _student = new List<Student>();

        public void Add(Student student)
        {
            _student.Add(student);
        }

        public void AddTest(Student student, Test test)
        {
            test.Owner = student;
            student.Tests.Add(test);
        }

        public IEnumerable<Student> GetAll()
        {
            return _student;
        }
    }
}
