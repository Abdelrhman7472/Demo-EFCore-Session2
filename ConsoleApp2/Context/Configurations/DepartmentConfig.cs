using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Context.Configurations
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(20);

            //builder.HasOne<Employee>(e => e.Manager) //Navigational Property
            //    .WithOne(e => e.Department)  //Navigational Property 
            //    .HasForeignKey<Department>(e => e.MGId);

            //builder.HasMany<Employee>(e => e.Employees).
            //    WithOne(d => d.Department).HasForeignKey(e=>e.DeptId);

            //builder.HasOne<Employee>().WithOne().HasForeignKey<Department>(d => d.EmployeeId);

            //builder.HasMany<Employee>().WithOne().HasForeignKey(e => e.DepartmentId);


        }


    }
}

