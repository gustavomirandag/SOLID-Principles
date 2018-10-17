using ConsoleAppNoInterfaceSeg.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNoInterfaceSeg.Model.Repositories
{
    public class StudentLinkedListRepository : IStudentRepository
    {
        private static LinkedList<Student> _student = new LinkedList<Student>();

        public void Add(Student student)
        {
            _student.AddLast(student);
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
