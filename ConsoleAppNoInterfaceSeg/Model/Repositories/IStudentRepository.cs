using ConsoleAppNoInterfaceSeg.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNoInterfaceSeg.Model.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
    }
}
