using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyobExercise.Models
{
    public class SuperRateRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {

            var employee = (Employee)validationContext.ObjectInstance;          
            var insertedSuperRate = employee.SuperRate;
            return (insertedSuperRate > 0 && insertedSuperRate < 11) ? ValidationResult.Success : new ValidationResult("Super rate must be between 1 and 10.");

        }


        }
    }
