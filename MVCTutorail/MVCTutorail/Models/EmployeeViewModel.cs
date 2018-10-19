using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTutorail.Models
{
    [Table("Department")]
    public class EmployeeViewModel
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }

        public string City { get; set; }
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public bool Remember { get; set; }
    }
}