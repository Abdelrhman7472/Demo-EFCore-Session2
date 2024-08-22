using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Employee
    {
        public int EId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
        public decimal Salary { get; set; }
        //[ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        //public Department? Department { get; set; }
    }
}
