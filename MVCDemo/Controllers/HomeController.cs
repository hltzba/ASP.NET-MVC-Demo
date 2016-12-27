using DAL;
using DAL.BussinessLayer;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetEmployees()
        {
            List<Employee> employees = EmployeesDAL.GetAllEmployees();
            EmployeeListViewModel listviewmodel = new EmployeeListViewModel();
            listviewmodel.LoginName = "Admin";
            listviewmodel.Employees = new List<EmployeeViewModel>();
            foreach (Employee e in employees)
            {
                EmployeeViewModel item = new EmployeeViewModel();
                item.FirstName = e.FirstName;
                item.LastName = e.LastName;
                item.Salary = e.Salary;
                listviewmodel.Employees.Add(item);
            }

            //   ViewData["Employee"] = model;
            // ViewBag.Employee = model;
            return View(listviewmodel);
        }
    }
}