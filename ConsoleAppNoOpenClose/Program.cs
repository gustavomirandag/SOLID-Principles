using ConsoleAppNoOpenClose.Model.Entities;
using ConsoleAppNoOpenClose.Model.Services;
using System;

namespace ConsoleAppNoOpenClose
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
            var persistService = new StudentPersistService();
            persistService.Save(cadu);
            persistService.Save(ruhan);

            //Print the students
            var printService = new StudentPrintService();
            printService.PrintAll();

            Console.ReadLine();
        }
    }
}
