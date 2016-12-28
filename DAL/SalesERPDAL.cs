using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SalesERPDAL : DbContext
    {
        //使用下面构造函数可以自由定义连接
        //public SalesERPDAL():base("ConnctionString或者ConnctName")

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("T_Employee");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employee { get; set; }
    }
}