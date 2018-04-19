using MyobExercise.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyobExercise.Models
{
    public class PaymentDate : GenericEntity
    {
        public string MonthName { get; set; }
        public int NumberOfDays { get; set; }
        public string Description { get; set; }
        public int MonthSeqInYear { get; set; }
    }
}