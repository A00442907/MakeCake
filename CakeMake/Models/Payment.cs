using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using ExpressiveAnnotations.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using Foolproof;
using CakeMake.Validations;

namespace CakeMake.Models
{
    public class Payment
    {

        public int PaymentId { get; set; }
        [Required(ErrorMessage = "Selecting card type is required")]
        public String CardType { get; set; }

 //       [RegularExpression("[^;:!@#$%^*+?/<>0-9]", ErrorMessage = "Credit Card Holder should not contain any numbers or special characters")]
        [RegularExpression("^[A-Za-z\\s]{1,}[\\.]{0,1}[A-Za-z\\s]{0,}$", ErrorMessage = "Credit Card Holder should not contain any numbers or special characters")]
        [Required(ErrorMessage = "Card Holder's Name is required")]
        public string HolderName { get; set; }

        //   [RegularExpressionIf("@^4[0 - 9]{12}(?:[0-9]{3})?$)","CardType","Visa")]
        //^[ - MATCH START
        //
        public String CardNumber { get; set; }

        [NotMapped]
        [CardTypeValidate]
        public String CardMix
        {
            get
            {
                return (CardType +":"+ CardNumber);
            }
        }

        [RegularExpression("(0[1-9]|10|11|12)/20[0-9]{2}$", ErrorMessage = "The expired data should be in format(MM/YYYY)")]
        [Required(ErrorMessage = "Expired Date is required")]
        public String ExpireDate { get; set; }
    }
}