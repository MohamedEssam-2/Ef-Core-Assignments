using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_Task_2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Task_2.Data
{
    internal class Iti_DbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1JO19MD; database=CompanyTest-2; Trusted_Connection=True; TrustServerCertificate=True ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.StudCourse_Configuration());
            modelBuilder.ApplyConfiguration(new Configurations.Inst_Course_Configuratrion());
            modelBuilder.ApplyConfiguration(new Configurations.Ins_Dep_MangeRelationShip_1_To_1());
            modelBuilder.ApplyConfiguration(new Configurations.Ins_Dep_WorkRelationShip_1_To_M());

        }
        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<StudCourse> StudCourses { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<Course_inst> Course_Insts { get; set; }
        DbSet<Topic> Topic { get; set; }
        DbSet<Department> Departments { get; set; }
    }
}
