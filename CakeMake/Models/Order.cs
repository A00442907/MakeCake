using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CakeMake.Validations;

namespace CakeMake.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [RegularExpression("^[A-Za-z\\s]{1,}[\\.]{0,1}[A-Za-z\\s]{0,}$", ErrorMessage = "Firstname should not contain any numbers or special characters")]
        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [RegularExpression("^[A-Za-z\\s]{1,}[\\.]{0,1}[A-Za-z\\s]{0,}$", ErrorMessage = "Lastname should not contain any numbers or special characters")]
        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [RegularExpression("^[A-Za-z\\s]{1,}[\\.]{0,1}[A-Za-z\\s]{0,}$", ErrorMessage = "Street address should not contain any numbers or special characters")]
        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Street Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [RegularExpression("^[A-Za-z\\s]{1,}[\\.]{0,1}[A-Za-z\\s]{0,}$", ErrorMessage = "City should not contain any numbers or special characters")]
        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }

        [RegularExpression("^[A-Za-z\\s]{1,}[\\.]{0,1}[A-Za-z\\s]{0,}$", ErrorMessage = "State should not contain any numbers or special characters")]
        [Required(ErrorMessage = "Please enter your state")]
        [StringLength(2,MinimumLength =2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zip")]
        [StringLength(6, MinimumLength = 1)]
        [Display(Name = "Zip Code")]
        [PostalValidate]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [RegularExpression("\\D*([2-9]\\d{2})(\\D*)([2-9]\\d{2})(\\D*)(\\d{4})\\D*", ErrorMessage = "Please input US or Canada phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter the delivery date")]
        [DateRangeValidate]
        public DateTime DeliveryDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}
