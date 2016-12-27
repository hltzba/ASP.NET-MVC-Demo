using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class EmployeeListViewModel
    {
        public string LoginName { get; set; }
        public List<EmployeeViewModel> Employees { get; set; }
    }
}