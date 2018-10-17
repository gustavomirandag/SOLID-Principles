using ConsoleAppSingleResp.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSingleResp.Model.Services
{
    public class StudentPrintService
    {
       public void PrintAll()
        {
            var repo = new StudentRepository();
            var students = repo.GetAll();

            foreach(var student in students)
                Console.WriteLine(student.Name);
        }
    }
}
