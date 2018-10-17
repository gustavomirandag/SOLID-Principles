using ConsoleAppOpenClose.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOpenClose.Model.Services
{
    public class StudentPrintService
    {
       public void PrintAll()
        {
            var repo = new StudentListRepository();
            var students = repo.GetAll();

            foreach(var student in students)
                Console.WriteLine(student.Name);
        }
    }
}
