using MyobExercise.Context.Interface;
using MyobExercise.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyobExercise.Test
{
    public class MyobMockContext : IDbContext
    {
        public List<Tax> Taxes { get; set; }
        public List<PaymentDate> PaymentDates { get; set; }
        public List<Employee> Employees { get; set; }

        public MyobMockContext()
        {
            Employees = new List<Employee>();
            Taxes = new List<Tax>();
            PaymentDates = new List<PaymentDate>();

            Taxes.Add(new Tax()
            {
                Id = Guid.NewGuid(),
                MinimumPay = 87001,
                MaximumPay = 180000,
                Rate = 19822,
                Surplus = 0.37M
                
            });

            Taxes.Add(new Tax()
            {
                Id = Guid.NewGuid(),
                MinimumPay = 37001,
                MaximumPay = 87000,
                Rate = 3572,
                Surplus = 0.33M

            });

            Taxes.Add(new Tax()
            {
                Id = Guid.NewGuid(),
                MinimumPay = 0,
                MaximumPay = 18200,
                Rate = 0,
                Surplus = 0

            });

            Taxes.Add(new Tax()
            {
                Id = Guid.NewGuid(),
                MinimumPay = 180001,
                MaximumPay = 0,
                Rate = 54232,
                Surplus = 0.45M

            });

            Taxes.Add(new Tax()
            {
                Id = Guid.NewGuid(),
                MinimumPay = 18201,
                MaximumPay = 37000,
                Rate = 0,
                Surplus = 0.19M

            });

            PaymentDates.Add(new PaymentDate()
            {
                Id = Guid.Parse("{DF929BE5-8AF5-449A-9C0E-C6014B6894E7}"),
                MonthName = "March",
                NumberOfDays = 31,
                Description = "01 March to 31 March",
                MonthSeqInYear = 3

            });

            PaymentDates.Add(new PaymentDate()
            {
                Id = Guid.Parse("{2C5473E9-276C-4204-9DD4-6FDE1238C89D}"),
                MonthName = "January",
                NumberOfDays = 31,
                Description = "01 Januray to 31 January",
                MonthSeqInYear = 1

            });

            PaymentDates.Add(new PaymentDate()
            {
                Id = Guid.Parse("{71DFC804-1F03-4A3E-B979-457D4142D480}"),
                MonthName = "October",
                NumberOfDays = 31,
                Description = "01 October to 31 October",
                MonthSeqInYear = 10

            });

            PaymentDates.Add(new PaymentDate()
            {
                Id = Guid.Parse("{AB483398-D570-4974-8D60-AA1534CA32E4}"),
                MonthName = "April",
                NumberOfDays = 30,
                Description = "01 April to 30 April",
                MonthSeqInYear = 4

            });

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public System.Data.Entity.Infrastructure.DbEntityEntry<T> Entry<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public System.Data.Entity.DbSet<T> Set<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public List<Tax> GetTaxes()
        {
            return Taxes;
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public List<PaymentDate> GetPaymentDates()
        {
            return PaymentDates;
        }
    }
}
