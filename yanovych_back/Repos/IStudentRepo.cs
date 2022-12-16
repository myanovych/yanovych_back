using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yanovych_back.Models;

namespace yanovych_back.Repos
{
    public interface IStudentRepo
    {
        public IEnumerable<Student> GetAll();

        public Student GetById(int id);

        public Student Add(Student student);

        public void Update(Student student);

        public void DeleteById(int id);
    }
}
