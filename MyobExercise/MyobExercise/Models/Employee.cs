using MyobExercise.Common.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyobExercise.Models
{
    public class Employee : GenericEntity
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        [StringLength (55)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your Salary.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please enter numeric digits only.")]
        [Display(Name="Annual Salary")]
        public decimal AnnualSalary { get; set; }

        [Required(ErrorMessage ="Please enter your super rate.")]
        [SuperRateRange]
        [Display(Name = "Super Rate")]
        public decimal SuperRate { get; set; }
       
        
        public PaymentDate PaymentDate { get; set; }

        [Required(ErrorMessage = "Please choose a pay period.")]
        [Display(Name = "Pay Period")]
        public Guid PaymentDateId { get; set; }
        
    }
}