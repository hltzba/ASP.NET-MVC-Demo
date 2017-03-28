using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class UserDetailsViewModel
    {
        [StringLength(7,MinimumLength =2,ErrorMessage ="用户名的长度必须是2-7个字符。")]
        public string UserName
        { get; set; }

        public string Password
        { get; set; }
    }
}