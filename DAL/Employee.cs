using CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "名字是必填项目。")]
        public string FirstName { get; set; }

        [StringLength(15, ErrorMessage = "姓氏的最大长度为15个字符。")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Email地址不正确。")]
        public string Email { get; set; }

        [JobNumExpression]
        public string JobNumber { get; set; }

        [Required(ErrorMessage = "薪金是必填项目。")]
        [Range(1, 5000, ErrorMessage = "薪金的范围必须是1-5000.")]
        public int Salary { get; set; }
    }
}