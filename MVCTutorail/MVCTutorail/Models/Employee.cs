using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTutorail.Models
{
    [Table("Empolyee")]
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        //public string Gender { get; set; }
        public string City { get; set; }

        public int DeptID{ get; set; }
    }
}