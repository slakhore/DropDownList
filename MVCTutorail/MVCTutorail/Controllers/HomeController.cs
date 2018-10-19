using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorail.Models;

namespace MVCTutorail.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public  ActionResult DepartmentIndex()
        //{
        //    EmployeeContext employeeContext = new EmployeeContext();
        //    List<Department> department = employeeContext.Departments.ToList();

        //    return View(department);
        //}
        //public ActionResult Details(int ID)
        //{
        //    EmployeeContext employeeContext = new EmployeeContext();
        //    Employee employee = employeeContext.Empolyees.SingleOrDefault(emp => emp.EmpID == ID);
        //    return View(employee);
        //}

        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            // List<Employee> employee = employeeContext.Empolyees.ToList();
            Employee employee = employeeContext.Empolyees.SingleOrDefault(x => x.EmpID ==101);

            EmployeeViewModel empModel = new Models.EmployeeViewModel();
            empModel.DeptID = employee.DeptID;
            empModel.DeptName = employee.EmpName;
            empModel.EmpID = employee.EmpID;
            empModel.City = employee.City;
            // ViewBag.EmploymentList = new SelectList(list, "DeptID", "DeptName");

            return View(empModel);
        }
    }
}