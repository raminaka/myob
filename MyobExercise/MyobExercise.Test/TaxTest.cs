using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyobExercise.Controllers;
using MyobExercise.Models;
using MyobExercise.ViewModels;

namespace MyobExercise.Test
{
    [TestClass]
    public class TaxTest
    {
        private MyobMockContext context;
        private EmployeeController controller;

        [TestInitialize]
        public void Initilize()
        {
            context = new MyobMockContext();
            controller = new EmployeeController(context);
        }


        //[TestMethod]
        //public void CalculateIncomeTax_from_100_to_1000()
        //{
        //    var result = controller.CalculateIncomeTax(520);
        //    Assert.AreEqual(125, result);
        //}


        [TestMethod]
        public void CalculateIncomeTax_calculate_from_100_to_1000()
        {
            EmployeePayslipViewModel viewModel = new EmployeePayslipViewModel()
            {
                Employee = new Employee() {
                    Id = Guid.NewGuid(),
                    FirstName = "David",
                    LastName = "Rudd",
                    AnnualSalary = 60050,
                    SuperRate = 9,
                    PaymentDateId = Guid.Parse("71DFC804-1F03-4A3E-B979-457D4142D480")
                }
            };

            var result = controller.Calculate(viewModel) as ViewResult;
            var modelResult = (EmployeePayslipViewModel)result.Model;
            Assert.AreEqual(5004, modelResult.GrossIncome);
            
            //Assert.AreEqual(5004M ,922M, 4082.ToString(), 450M, modelResult.GrossIncome ,modelResult.IncomeTax, modelResult.NetIncome, modelResult.Super );
        }
    }
}
