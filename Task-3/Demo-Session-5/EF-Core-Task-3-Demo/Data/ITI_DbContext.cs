using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_Task_3_Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Task_3_Demo.Data
{
    internal class ITI_DbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1JO19MD; database=CompanyTest-2; Trusted_Connection=True; TrustServerCertificate=True ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Models.Stu_Dep_View>(entity =>
            //{
            //    entity.HasNoKey();
            //    entity.ToView("Stu_Dep_View");
            //});

            #region Change Discriminator name 
            //modelBuilder.Entity<Employee>().HasDiscriminator<string>("Emp_Type"); 
            #endregion

            //modelBuilder.Entity<Fulltime_Employee>().ToTable("Fulltime_Employee");
            //modelBuilder.Entity<Part_time_Employee>().ToTable("Part_time_Employee");

        }
        #region View
        //public DbSet<Stu_Dep_View> Stu_Dep_Veiw { get; set; }
        #endregion
        #region TPCT
        //public DbSet<Fulltime_Employee> Fulltime_Employee { get; set; }
        //public DbSet<Part_time_Employee> Part_time_Employee { get; set; } 
        #endregion
        #region TPH
        //public DbSet<Employee> Employee { get; set; }
        //public DbSet<Fulltime_Employee> Fulltime_Employee { get; set; }
        //public DbSet<Part_time_Employee> Part_time_Employee { get; set; }
        #endregion
        #region TPC
        //public DbSet<Employee> Employee { get; set; }
        //public DbSet<Fulltime_Employee> Fulltime_Employee { get; set; }
        //public DbSet<Part_time_Employee> Part_time_Employee { get; set; }
        #endregion
    }
}
