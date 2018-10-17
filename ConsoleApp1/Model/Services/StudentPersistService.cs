using ConsoleAppOpenClose.Model.Entities;
using ConsoleAppOpenClose.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOpenClose.Model.Services
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
