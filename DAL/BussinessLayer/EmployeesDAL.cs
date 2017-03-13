using DAL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                return db.Employee.ToList();
            }
        }

        public static Employee GetEmployee(int id)
        {
            using (SalesERPDAL db = new SalesERPDAL())
            {
                Expression<Func<Employee, bool>> where = PredicateExtensionses.True<Employee>();
                where = where.And(it => it.Id == id);
                return db.Employee.Where(where).FirstOrDefault();
            }
        }

        public static void SaveEmployee(Employee e)
        {
            using (SalesERPDAL db = new SalesERPDAL())
            {
                db.Employee.Add(e);
                db.SaveChanges();
            }
        }

        public static void SaveEmployeeList(List<Employee> source)
        {
            using (SalesERPDAL db = new SalesERPDAL())
            {
                try
                {
                    db.Employee.AddRange(source);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}