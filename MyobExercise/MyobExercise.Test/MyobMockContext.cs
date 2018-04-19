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

            Employees.Add(new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = "David",
                LastName= "Rudd",
                AnnualSalary = 60050,
                SuperRate =9,
                PaymentDateId = Guid.Parse("{DF929BE5-8AF5-449A-9C0E-C6014B6894E7}")
                
            });

            Employees.Add(new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = "Ryan",
                LastName = "Chen",
                AnnualSalary = 120000,
                SuperRate = 10,
                PaymentDateId = Guid.Parse("{DF929BE5-8AF5-449A-9C0E-C6014B6894E7}")

            });

            Employees.Add(new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = "Ramina",
                LastName = "Kashefipour",
                AnnualSalary = 15000,
                SuperRate = 3,
                PaymentDateId = Guid.Parse("{331B5E78-CB37-457B-80F5-873B2ECAF244}")

            });

            Employees.Add(new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = "Sarah",
                LastName = "Smith",
                AnnualSalary = 27000,
                SuperRate = 5,
                PaymentDateId = Guid.Parse("{331B5E78-CB37-457B-80F5-873B2ECAF244}")

            });

            Employees.Add(new Employee()
            {
                Id = Guid.NewGuid(),
                FirstName = "Raeika",
                LastName = "Kashefipour",
                AnnualSalary = 250000,
                SuperRate = 10,
                PaymentDateId = Guid.Parse("{331B5E78-CB37-457B-80F5-873B2ECAF244}")

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
    }
}
