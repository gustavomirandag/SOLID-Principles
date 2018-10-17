using ConsoleAppNoInterfaceSeg.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNoInterfaceSeg.Model.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
    }
}
