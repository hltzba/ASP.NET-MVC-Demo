using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidations
{
    public class JobNumExpression : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value.ToString().Length < 3)
            {
                return new ValidationResult("工号不能小于3个字符。");
            }

            if (value != null && value.ToString().Substring(0, 1) != "E")
            {
                return new ValidationResult("工号必须以字母'E'开头。");
            }

            return ValidationResult.Success;
        }
    }
}