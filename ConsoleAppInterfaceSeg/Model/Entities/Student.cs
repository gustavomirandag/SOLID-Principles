using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInterfaceSeg.Model.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Test> Tests { get; set; }

        public Student()
        {
            Tests = new List<Test>();
        }
    }
}
