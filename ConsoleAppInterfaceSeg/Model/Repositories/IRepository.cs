using ConsoleAppInterfaceSeg.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInterfaceSeg.Model.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
    }
}
