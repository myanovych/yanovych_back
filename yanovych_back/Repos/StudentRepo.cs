using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yanovych_back.Models;

namespace yanovych_back.Repos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly DbSet<Student> _dbSet;
        private readonly AppDbContext _context;

        public StudentRepo(AppDbContext context)
        {
            _context = context;
            _dbSet = context.StudentList;
        }

        public Student Add(Student student)
        {
            var addedStudent = _dbSet.Add(student); ;
            _context.SaveChanges();

            return addedStudent.Entity;
        }

        public void DeleteById(int id)
        {
            var student = GetById(id);

            if (student != null)
            {
                _dbSet.Remove(student);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Student> GetAll()
        {
            return _dbSet.AsNoTracking().AsEnumerable();
        }

        public Student GetById(int id)
        {
            return _dbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Update(Student student)
        {
            _dbSet.Update(student);
            _context.SaveChanges();
        }
    }
}
