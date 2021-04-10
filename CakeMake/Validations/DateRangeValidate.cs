using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace CakeMake.Validations
{
   public class DateRangeValidate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dt = (DateTime)value;
            if (dt <= DateTime.Now.AddDays(2) && dt > DateTime.Now.AddDays(-1)) 
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Please select the recent two days for delivery.");
            }
        }
    }

}
