﻿using DAL;
using DAL.BussinessLayer;
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

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Employee e)
        {
            if (ModelState.IsValid)
            {
                EmployeesDAL.SaveEmployee(e);
                return RedirectToAction("Index");
            }
            else
            {
                return View("CreateEmployee");
            }
            //return e.FirstName + "|" + e.LastName + "|" + e.Salary;
        }
    }
}