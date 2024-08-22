using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? EmployeeId { get; set; }

        #region OneToOne
        ////[ForeignKey("Manager")]
        //public int? MGId { get; set; }
        ////[ForeignKey("MGId")]
        //public Employee? Manager { get; set; } //Navigational Property
        #endregion
        //[InverseProperty("Department")]
        //public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); //Collection Navigational Property


    }
}
// one beykon el PK w el many 3andha el FK
// Ay Navigational Property bett2ery enha relation bas 
//Collection Navigational Property => ba2ol en 3andy relation one to many 