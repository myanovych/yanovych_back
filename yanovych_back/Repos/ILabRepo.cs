using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yanovych_back.Models;

namespace yanovych_back.Repos
{
    public interface ILabRepo
    {
        public IEnumerable<Lab> GetAll();

        public Lab GetById(int id);

        public Lab Add(Lab lab);

        public void Update(Lab lab);

        public void DeleteById(int id);
    }
}
