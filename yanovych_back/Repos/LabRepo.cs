using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yanovych_back.Models;

namespace yanovych_back.Repos
{
    public class LabRepo : ILabRepo
    {
        private readonly DbSet<Lab> _dbSet;
        private readonly AppDbContext _context;

        public LabRepo(AppDbContext context)
        {
            _context = context;
            _dbSet = context.LabList;
        }
        public Lab Add(Lab lab)
        {
            var addedLab = _dbSet.Add(lab); ;
            _context.SaveChanges();

            return addedLab.Entity;
        }

        public void DeleteById(int id)
        {
            var lab = GetById(id);

            if (lab != null)
            {
                _dbSet.Remove(lab);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Lab> GetAll()
        {
            return _dbSet.AsNoTracking().AsEnumerable();
        }

        public Lab GetById(int id)
        {
            return _dbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Update(Lab lab)
        {
            _dbSet.Update(lab);
            _context.SaveChanges();
        }
    }
}
