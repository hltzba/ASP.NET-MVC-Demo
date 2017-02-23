using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public static class FooterViewModel
    {
        public static string CompanyName { get; set; }
        public static string Year { get; set; }

        static FooterViewModel()
        {
            CompanyName = "Jimmy & Jane's Sweet House";
            Year = "2016";
        }
    }
}