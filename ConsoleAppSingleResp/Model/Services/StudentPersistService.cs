using ConsoleAppSingleResp.Model.Entities;
using ConsoleAppSingleResp.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSingleResp.Model.Services
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
