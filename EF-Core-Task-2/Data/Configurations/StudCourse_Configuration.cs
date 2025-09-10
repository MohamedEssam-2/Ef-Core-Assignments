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
    internal class StudCourse_Configuration : IEntityTypeConfiguration<StudCourse>
    {
        public void Configure(EntityTypeBuilder<StudCourse> builder)
        {
            //Student-Course Many to Many

            //Student 1 to Many StudCourse

            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });
           builder.HasOne(sc => sc.Student).WithMany().HasForeignKey(sc => sc.StudentId).HasConstraintName("Student_id");

            //Course 1 to Many StudCourse
            builder.HasOne(sc => sc.Course).WithMany().HasForeignKey(sc => sc.CourseId).HasConstraintName("Course_id"); ;
        }

       
    }
}
