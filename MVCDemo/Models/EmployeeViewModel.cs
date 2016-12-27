using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class EmployeeViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int Salary { get; set; }

        public string SalaryColor
        {
            get
            {
                if (Salary > 2000)
                {
                    return "yellow";
                }
                else
                {
                    return "green";
                }
            }
        }
    }
}