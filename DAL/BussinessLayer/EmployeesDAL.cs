using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BussinessLayer
{
    public static class EmployeesDAL
    {
        public static List<Employee> GetAllEmployees()
        {
            using (SalesERPDAL db = new SalesERPDAL())
            {
                return db.Employees.ToList();
            }
        }
    }
}