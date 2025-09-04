using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1_ef_core.Data.Models;
using Microsoft.EntityFrameworkCore;
using Task_1_ef_core.Data.Configuration;
namespace Task_1_ef_core.Data.Models
{
    internal class ItiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1JO19MD;Database=Iti_EF_Core;Trusted_Connection=True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>(sc =>
            {

                sc.HasKey(sc => new { sc.StudentId, sc.CourseId });
                sc.Property(sc => sc.Grade).IsRequired();
                sc.Property(sc => sc.StudentId).HasColumnName("Student_Id");
                sc.Property(sc => sc.CourseId).HasColumnName("Course_Id");
            });
            modelBuilder.Entity<Course_inst>(ci =>
            {
                ci.HasKey(ci => new { ci.InstId, ci.CourseId });
                ci.Property(ci => ci.evaluate).IsRequired();
                ci.Property(ci => ci.InstId).HasColumnName("Inst_Id");
                ci.Property(ci => ci.CourseId).HasColumnName("Course_Id");
            });

            modelBuilder.ApplyConfiguration(new Instructor_Configuration());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Stud_Course> Student_Course { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_inst> course_Insts { get; set; }
        public DbSet<Instructor> Instructors { get; set; }


    }
}
