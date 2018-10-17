using ConsoleAppInterfaceSeg.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInterfaceSeg.Model.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        void AddTest(Student student, Test test);
    }
}
