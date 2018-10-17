using ConsoleAppOpenClose.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOpenClose.Model.Repositories
{
    public interface IStudentRepository
    {
        void Add(Student student);
        IEnumerable<Student> GetAll();
    }
}
