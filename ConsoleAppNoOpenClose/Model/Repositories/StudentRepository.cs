using ConsoleAppNoOpenClose.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNoOpenClose.Model.Repositories
{
    public class StudentRepository
    {
        private static List<Student> _students = new List<Student>();
        private static LinkedList<Student> _studentsLl = new LinkedList<Student>();

        public void Add(Student student, bool persistInLinkedList = false)
        {
            if (persistInLinkedList)
                _studentsLl.AddLast(student);
            _students.Add(student);
        }

        public IEnumerable<Student> GetAll(bool getFromLinkedList = false)
        {
            if (getFromLinkedList)
                return _studentsLl;
            return _students;
        }
    }
}
