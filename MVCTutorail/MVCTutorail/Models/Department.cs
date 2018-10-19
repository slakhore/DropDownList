using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTutorail.Models
{
    [Table("Department")]
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DeptID { get; set; }

        public string DeptName { get; set; }
        public List<Employee> employeeList { get; set; }
        public int EmpID { get; set; }

    }
}