using MVC_MultipleTables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_MultipleTables.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int departmentId)
        {
            MVC_MultiTableEntities dbContext = new MVC_MultiTableEntities();
            List<Employee> employees = dbContext.Employees.Where(emp => emp.DepartmentId == departmentId).ToList();
            return View(employees);
        }
        public ActionResult Details(int id)
        {
            MVC_MultiTableEntities dbContext = new MVC_MultiTableEntities();
            Employee employee = dbContext.Employees.FirstOrDefault(x => x.EmployeeId == id);
            return View(employee);
        }
    }
}