using MyobExercise.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MyobExercise.Context.Interface
{
    public interface IDbContext
    {
        DbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();

        Task<int> SaveChangesAsync();

        void Dispose();

        List<Tax> GetTaxes();

        List<Employee> GetEmployees();

        List<PaymentDate> GetPaymentDates();

    }
}




