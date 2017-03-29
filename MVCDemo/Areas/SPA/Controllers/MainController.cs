using DAL;
using DAL.BussinessLayer;
using MVCDemo.ViewModel.SPA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Areas.SPA.Controllers
{
    public class MainController : Controller
    {
        // GET: SPA/Main
        public ActionResult Index()
        {
            List<Employee> employees = EmployeesDAL.GetAllEmployees();
            List<EmployeeViewModel> resultModels = new List<EmployeeViewModel>();
            foreach (Employee e in employees)
            {
                EmployeeViewModel model = new EmployeeViewModel();
                model.EmployeeName = e.FirstName + " " + e.LastName;
                model.Salary = e.Salary;
                if (model.Salary > 2000)
                {
                    model.SalaryColor = "green";
                }
                else
                {
                    model.SalaryColor = "yellow";
                }
                resultModels.Add(model);
            }
            return View(resultModels);
        }

        public ActionResult GetAddNewLink()
        {
            if (Convert.ToBoolean(Session["IsAdmin"]))
            {
                return PartialView("AddNewLink");
            }
            else
            {
                return new EmptyResult();
            }
        }

        public ActionResult AddNew()
        {
            CreateEmployeeViewModel v = new CreateEmployeeViewModel();
            return PartialView("CreateEmployee", v);
        }
    }
}