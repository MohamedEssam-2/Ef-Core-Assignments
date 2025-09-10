
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
    internal class Ins_Dep_WorkRelationShip_1_To_M : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasOne(i => i.Work_in_Dep)
                    .WithMany(d => d.Instructors)
                    .HasForeignKey(i => i.Dep_id);
                    
        }
    }
}
