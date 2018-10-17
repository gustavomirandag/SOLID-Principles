using ConsoleAppNoOpenClose.Model.Entities;
using ConsoleAppNoOpenClose.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNoOpenClose.Model.Services
{
    public class StudentPersistService
    {
        public void Save(Student student)
        {
            var repo = new StudentRepository();
            repo.Add(student);
        }
    }
}
