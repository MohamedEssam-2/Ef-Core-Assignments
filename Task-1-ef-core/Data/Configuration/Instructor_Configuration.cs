using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task_1_ef_core.Data.Models;

namespace Task_1_ef_core.Data.Configuration
{
    internal class Instructor_Configuration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Instructor> builder)
        {
            builder. HasKey(k=>k.Id);
            builder. Property(i => i.Name).HasMaxLength(100).IsRequired();
            builder. Property(i => i.Dep_id).HasColumnName("Dep_Id");
            builder.Property(i => i.Salary)
                  .HasColumnType("decimal(10,2)");


        }
    }
}
