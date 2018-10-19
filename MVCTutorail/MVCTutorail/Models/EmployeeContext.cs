using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCTutorail.Models;

namespace MVCTutorail.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Empolyees { get; set; }

        public DbSet<Department> Departments { get; set; }

    }
}