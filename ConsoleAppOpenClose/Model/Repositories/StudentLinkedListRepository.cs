using ConsoleAppOpenClose.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOpenClose.Model.Repositories
{
    public class StudentLinkedListRepository : IStudentRepository
    {
        private static LinkedList<Student> _student = new LinkedList<Student>();

        public void Add(Student student)
        {
            _student.AddLast(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return _student;
        }
    }
}
