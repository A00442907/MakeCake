using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace CakeMake.Validations
{
    class CardTypeValidate : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            string str = value.ToString();
            Console.WriteLine(str);

            string cardType = str.Split(':')[0];
            String cardNum = str.Split(':')[1];

            if (!IsCard(cardType, cardNum))
            {
                return new ValidationResult("Invalid card number");
            }

            return ValidationResult.Success;
        }

        private bool IsCard(string cardType,string cardNum)
        {
            bool isValid = false;
            string pattern;
            int len;

            if (cardType == "Visa")
            {
                pattern = @"^4[0-9]{12}(?:[0-9]{3})?$";
                len = 16;
            }
            else if (cardType == "MasterCard")
            {
                pattern = @"^5[1-5][0-9]{14}$";
                len = 16;
            }
            else
            {
                pattern = @"3[47][0-9]{13}$";
                len = 15;
            }
            Regex regex = new Regex(pattern);
            isValid = regex.IsMatch(cardNum) && (cardNum.Length == len);
            return isValid;
        }

    }


}
