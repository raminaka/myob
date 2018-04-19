using MyobExercise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyobExercise.ViewModels
{
    public class EmployeePayslipViewModel
    {
       
        public string Name { get; set; }

        public Employee Employee { get; set; }

        public IEnumerable<Tax> Taxes { get; set; }

        public IEnumerable<PaymentDate> PaymenDates { get; set; }

        public decimal GrossIncome { get; set; }

        public decimal IncomeTax { get; set; }

        public decimal NetIncome { get; set; }

        public decimal Super { get; set; }

        public string PaymentDateDescription { get; set; }
    }
}