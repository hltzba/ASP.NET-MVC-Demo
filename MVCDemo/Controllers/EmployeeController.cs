﻿using DAL;
using DAL.BussinessLayer;
using MVCDemo.Filters;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Authorize]
        public ActionResult Index()
        {
            List<Employee> employees = EmployeesDAL.GetAllEmployees();
            //Employee tmp=EmployeesDAL.GetEmployee(2);
            EmployeeListViewModel listviewmodel = new EmployeeListViewModel();

            listviewmodel.Employees = new List<EmployeeViewModel>();
            foreach (Employee e in employees)
            {
                EmployeeViewModel item = new EmployeeViewModel();
                item.JobNumber = e.JobNumber;
                item.Email = e.Email;
                item.FirstName = e.FirstName;
                item.LastName = e.LastName;
                item.Salary = e.Salary;
                listviewmodel.Employees.Add(item);
            }

            //   ViewData["Employee"] = model;
            // ViewBag.Employee = model;

            return View(listviewmodel);
        }

        [AdminFilter]
        public ActionResult AddNew()
        {
            return View("CreateEmployee", new CreateEmployeeViewModel());
        }

        [AdminFilter]
        public ActionResult SaveEmployee(Employee e)
        {
            if (ModelState.IsValid)
            {
                EmployeesDAL.SaveEmployee(e);
                return RedirectToAction("Index");
            }
            else
            {
                CreateEmployeeViewModel model = new CreateEmployeeViewModel();
                model.JobNumber = e.JobNumber;
                model.FirstName = e.FirstName;
                model.LastName = e.LastName;
                model.Email = e.Email;
                model.Salary = e.Salary;
                return View("CreateEmployee", model);
            }
            //return e.FirstName + "|" + e.LastName + "|" + e.Salary;
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
    }
}