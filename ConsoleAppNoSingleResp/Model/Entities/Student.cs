using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNoSingleResp.Model.Entities
{
    public class Student
    {
        private static List<Student> _students = new List<Student>();
        public Guid Id { get; set; }
        public string Name { get; set; }
        public void Save()
        {
            _students.Add(this);
        }

        public void Print()
        {
            foreach(var student in _students)
                Console.WriteLine(student.Name);
        }

        public enum Persistence
        {
            SqlDatabase,
            NoSql,
            RAM
        }
    }
}
