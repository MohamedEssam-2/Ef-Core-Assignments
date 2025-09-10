
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
    internal class Ins_Dep_MangeRelationShip_1_To_1 : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasOne(d => d.Manager)
                 .WithOne(i => i.Manage_Department)
                 .HasForeignKey<Department>(d => d.Ins_Id);
        }
    }
}
