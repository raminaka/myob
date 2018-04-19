using MyobExercise.Context.Interface;
using MyobExercise.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyobExercise.Context
{
    public class MyobDbContext: DbContext, IDbContext
    {
        public MyobDbContext() : base("MyobExerciseConnectionString") {
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Tax> Taxes { get; set; }

        public DbSet<PaymentDate> PaymentDates { get; set; }



        public List<Tax> GetTaxes()
        {
            return Taxes.ToList();
        }
        public List<Employee> GetEmployees()
        {
            return Employees.ToList();
        }
        public List<PaymentDate> GetPaymentDates()
        {
            return PaymentDates.ToList();
        }
    }
}