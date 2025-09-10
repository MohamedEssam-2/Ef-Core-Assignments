using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_Task_2.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EF_Core_Task_2.Data.Configurations
{
    internal class Inst_Course_Configuratrion : IEntityTypeConfiguration<Course_inst>
    {
        //Instructor-Course Many to Many
        //Instructor 1 to Many Inst_Course
        public void Configure(EntityTypeBuilder<Course_inst> builder)
        {
            builder.HasKey(ci => new { ci.Inst_Id, ci.Course_Id });
            //Instructor
            builder.HasOne(ci => ci.instructor).WithMany().HasForeignKey(ci => ci.Inst_Id).HasConstraintName("Inst_id");

            //Course 1 to Many Inst_Course
            //Course 
            builder.HasOne(ci => ci.course).WithMany().HasForeignKey(ci => ci.Course_Id).HasConstraintName("CourseId");
        }
    }
}
