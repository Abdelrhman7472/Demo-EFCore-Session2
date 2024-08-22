using ConsoleApp2.Models;
using ConsoleApp2.Context;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyContext context = new MyContext();//Db Connection and dispose=> (For un Managed resources)

            #region Create:Insert

            //Employee emp1 = new Employee { Age=20,Salary=3000,Name="Ahmed"};

            //Employee emp2 = new Employee { Age = 21, Salary = 3000, Name = "Omar" };


            //Console.WriteLine(context.Entry(emp1).State);
            //Console.WriteLine(context.Entry(emp2).State);
            //Console.WriteLine("===========================================");

            //context.Employees.Add(emp1);//==>> Change Entity State to Added 
            //context.Employees.Add(emp2);//==>> Change Entity State to Added 

            //context.Entry(emp1).State =EntityState.Added;

            //Console.WriteLine("===========================================");
            //Console.WriteLine(context.Entry(emp1).State);
            //Console.WriteLine(context.Entry(emp2).State);

            //context.SaveChanges(); //==>> saveChanges in sql and change the state


            //Console.WriteLine("===========================================");

            //Console.WriteLine(context.Entry(emp1).State);
            //Console.WriteLine(context.Entry(emp2).State);





            #endregion

            #region Retrieve:Select

            //var emp1=context.Employees.FirstOrDefault(e=>e.EId==1);
            //var employess = context.Employees.Where(p => p.Salary < 150000).AsNoTracking();

            //foreach (var employee in employess) {
            //    Console.WriteLine(employee.Name);
            //    Console.WriteLine(context.Entry(employee).State);

            //}












            #endregion

            #region Update
            //var emp = context.Employees.AsNoTracking().FirstOrDefault(p => p.EId == 1);

            //if (emp != null)
            //{
            //    Console.WriteLine(context.Entry(emp).State);

            //    emp.Name = "Omar";
            //    Console.WriteLine("================================");

            //    Console.WriteLine(context.Entry(emp).State);

            //    context.SaveChanges();
            //    Console.WriteLine("================================");

            //    Console.WriteLine(context.Entry(emp).State);


            //}





            #endregion

            #region Delete
            //var emp = context.Employees.FirstOrDefault(p => p.EId == 1);

            //if (emp != null)
            //{
            //    Console.WriteLine(context.Entry(emp).State);


            //    context.Employees.Remove(emp);

            //    Console.WriteLine("================================");

            //    Console.WriteLine(context.Entry(emp).State);

            //    context.SaveChanges();
            //    Console.WriteLine("================================");

            //    Console.WriteLine(context.Entry(emp).State);


            //}






            #endregion

            #region OneToOne 

            //Department department = new Department
            //{
            //    Id = 1,
            //    Name = "TestDept",
            //    ManagerId = 1,
            //    Manager = new Employee { EId = 1, Age = 50, Name = "Test", Salary = 50000 }


            //};
            //Console.WriteLine(department.Manager.Name);


            #endregion








            Console.ReadKey();   }
    }
}
//First Commit Here