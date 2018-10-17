using ConsoleAppNoSingleResp.Model.Entities;
using System;

namespace ConsoleAppNoSingleResp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Students
            Student cadu = new Student();
            cadu.Id = Guid.NewGuid();
            cadu.Name = "Carlos Eduardo";

            Student ruhan = new Student();
            ruhan.Id = Guid.NewGuid();
            ruhan.Name = "Ruhan";

            //Save the students
            cadu.Save();
            ruhan.Save();

            //Print the students
            cadu.Print();
            ruhan.Print();

            Console.ReadLine();
        }
    }
}
