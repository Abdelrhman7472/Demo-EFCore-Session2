using ConsoleApp2.Context.Configurations;
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Context
{
    internal class MyContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

         => optionsBuilder.UseSqlServer("server=.;database=CompanyDbG01;trusted_Connection=true;encrypt=false");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EmployeeConfig());
            //modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            modelBuilder.Entity<Student>()
                .HasMany<Course>().
                WithMany()
                .UsingEntity<CourseStudent>()
                .HasKey(c => new { c.StudentId, c.CourseId });
        }


      public DbSet<Employee> Employees { get; set; }
 
       public DbSet<Department>Departments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseStudent> CourseStudents { get; set; }

    }
}
