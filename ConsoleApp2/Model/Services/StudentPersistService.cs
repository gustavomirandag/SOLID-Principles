using ConsoleAppNoInterfaceSeg.Model.Entities;
using ConsoleAppNoInterfaceSeg.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNoInterfaceSeg.Model.Services
{
    public class StudentPersistService
    {
        public void Save(Student student)
        {
            IStudentRepository repo = new StudentLinkedListRepository();
            repo.Add(student);
        }
    }
}
