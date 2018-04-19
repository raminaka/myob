using MyobExercise.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyobExercise.Models
{
    public class Tax : GenericEntity
    {
        public decimal MinimumPay { get; set; }
        public decimal MaximumPay { get; set; }
        public decimal Rate { get; set; }
        
        [RegularExpression(@"^\d+\.\d{0,3}$")]
        public decimal Surplus { get; set; }
    }
}