using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppNoInterfaceSeg.Model.Entities;

namespace ConsoleAppNoInterfaceSeg.Model.Repositories
{
    public class ProfessorListRepository : IProfessorRepository
    {
        private static List<Professor> _professors = new List<Professor>();

        public void Add(Professor entity)
        {
            _professors.Add(entity);
        }

        public void AddTest(Student student, Test test)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Professor> GetAll()
        {
            return _professors;
        }
    }
}
