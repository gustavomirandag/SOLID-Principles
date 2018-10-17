using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppInterfaceSeg.Model.Entities;

namespace ConsoleAppInterfaceSeg.Model.Repositories
{
    public class ProfessorListRepository : IProfessorRepository
    {
        private static List<Professor> _professors = new List<Professor>();

        public void Add(Professor entity)
        {
            _professors.Add(entity);
        }

        public IEnumerable<Professor> GetAll()
        {
            return _professors;
        }
    }
}
