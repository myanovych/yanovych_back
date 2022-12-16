using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yanovych_back.Models;

namespace yanovych_back.Repos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasData(
                    new Student { Id = 1, Attendance = 16, ExamMark = 48 },
                    new Student { Id = 2, Attendance = 12, ExamMark = 42 }
                    );

            modelBuilder.Entity<Lab>()
                .HasData(
                    new Lab { Id = 1, Title="Lab1", Date = "2022-10-01", Priority = 3, Status = "Evaluated", Mark=7, StudentID = 2 },
                    new Lab { Id = 2, Title = "Lab2", Date = "2022-10-10", Priority = 2, Status = "Submitted", Mark = 0, StudentID = 1 }
                    );;


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> StudentList { get; set; }
        public DbSet<Lab> LabList { get; set; }
    }
}

