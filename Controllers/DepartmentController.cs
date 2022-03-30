using MVC_MultipleTables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_MultipleTables.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            MVC_MultiTableEntities dbContext = new MVC_MultiTableEntities();
            List<Department> listDepartments = dbContext.Departments.ToList();
            return View(listDepartments);
        }
    }
}