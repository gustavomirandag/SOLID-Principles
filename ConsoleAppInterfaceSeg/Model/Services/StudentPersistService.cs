using ConsoleAppInterfaceSeg.Model.Entities;
using ConsoleAppInterfaceSeg.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInterfaceSeg.Model.Services
{
    public class StudentPersistService
    {
        IStudentRepository _repo;

        public StudentPersistService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public void Save(Student student)
        {
            _repo.Add(student);
        }
    }
}
