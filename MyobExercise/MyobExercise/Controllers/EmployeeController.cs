using MyobExercise.Context;
using MyobExercise.Context.Interface;
using MyobExercise.Models;
using MyobExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyobExercise.Controllers
{
    public class EmployeeController : Controller
    {
        private IDbContext _dbContext;

        public EmployeeController(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public ActionResult EmployeeForm()
        {
            var paymentDates = _dbContext.Set<PaymentDate>().ToList();
            var viewModel = new EmployeePayslipViewModel {
                PaymenDates = paymentDates.OrderBy( p => p.MonthSeqInYear).ToList()
            };

            return View(viewModel);
        }

        public ActionResult Calculate(EmployeePayslipViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                viewModel.PaymenDates = _dbContext.Set<PaymentDate>().ToList();
                return View("EmployeeForm", viewModel);
            }
            else
            {
                viewModel.Name = viewModel.Employee.FirstName + " " + viewModel.Employee.LastName;
                viewModel.PaymentDateDescription = GetPaymentDateDescription(viewModel.Employee.PaymentDateId).ToString();
                viewModel.IncomeTax = CalculateIncomeTax(viewModel.Employee.AnnualSalary);
                viewModel.GrossIncome = CalculateGrossIncome(viewModel.Employee.AnnualSalary);
                viewModel.NetIncome = CalculateNetIncome(viewModel.GrossIncome, viewModel.IncomeTax);
                viewModel.Super = CalculateSuper(viewModel.GrossIncome, viewModel.Employee.SuperRate);

                return View("PayslipResult", viewModel);
            }
        }
        public decimal CalculateIncomeTax(decimal annualSalary) {
            
            var taxinfo = _dbContext.Set<Tax>().Where(t => t.MinimumPay <= annualSalary && t.MaximumPay >= annualSalary).FirstOrDefault();

            decimal incomeTax = 0;

            if (taxinfo != null)
            {
                decimal calculateIncomeTax = 0;

                //Fix Database Auto Rounding issue
                if (taxinfo.Surplus == 0.33M){
                    taxinfo.Surplus = 0.325M;
                }

                calculateIncomeTax = ((taxinfo.Rate) + ((annualSalary - (taxinfo.MinimumPay - 1)) * (taxinfo.Surplus))) / 12;
                incomeTax = Math.Round(calculateIncomeTax, 0, MidpointRounding.AwayFromZero);
            }

            else {

                var otherTaxInfo = _dbContext.Set<Tax>().Where(t => t.MinimumPay <= annualSalary && t.MaximumPay == 0).FirstOrDefault();
                decimal calculateIncomeTax = 0;
                calculateIncomeTax = ((otherTaxInfo.Rate) + ((annualSalary - (otherTaxInfo.MinimumPay - 1)) * (otherTaxInfo.Surplus))) / 12;
                incomeTax = Math.Round(calculateIncomeTax, 0, MidpointRounding.AwayFromZero);
            }
            
            return incomeTax;
        }

        public decimal CalculateGrossIncome(decimal annualSalary)
        {       
            decimal grossIncome = 0;
          
            if (annualSalary != default(decimal))
            {
                grossIncome = Math.Round((annualSalary / 12), 0, MidpointRounding.AwayFromZero);
            }
            return grossIncome;
        }


        public decimal CalculateNetIncome(decimal grossIncome, decimal IncomeTax)
        {
            decimal netIncome = 0;
            if (grossIncome != default(decimal) && IncomeTax != default(decimal)) {
                netIncome = Math.Round((grossIncome-IncomeTax), 0, MidpointRounding.AwayFromZero);
            }
            return netIncome;
        }

        public decimal CalculateSuper(decimal grossIncome, decimal superRate)
        {
            decimal super = 0;
            if (grossIncome != null && superRate != null)
            {
                super = Math.Round((grossIncome * (superRate/100)), 0, MidpointRounding.AwayFromZero);
            }
            return super;
        }

        public string GetPaymentDateDescription(Guid PaymentDateId)
        {
            string PaymentDateDescription= string.Empty;
            if (PaymentDateId != null)
            {
                 PaymentDateDescription = _dbContext.Set<PaymentDate>().Where(t => t.Id == PaymentDateId).Select(t => t.Description).FirstOrDefault().ToString();
            }
            return PaymentDateDescription;
        }
    }
}