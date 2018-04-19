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

        [TestMethod]
        public void Calculate_for_AnnualSalary_0_to_18200()
        {
            EmployeePayslipViewModel viewModel = new EmployeePayslipViewModel()
            {
                Employee = new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Sarah",
                    LastName = "Smith",
                    AnnualSalary = 13000,
                    SuperRate = 3,
                    PaymentDateId = Guid.Parse("{2C5473E9-276C-4204-9DD4-6FDE1238C89D}")
                }
            };

            var result = controller.Calculate(viewModel) as ViewResult;
            var modelResult = (EmployeePayslipViewModel)result.Model;
            Assert.AreEqual("Sarah Smith", modelResult.Name);
            Assert.AreEqual("01 Januray to 31 January", modelResult.PaymentDateDescription);
            Assert.AreEqual(1083, modelResult.GrossIncome);
            Assert.AreEqual(0, modelResult.IncomeTax);
            Assert.AreEqual(1083, modelResult.NetIncome);
            Assert.AreEqual(32, modelResult.Super);

        }

        [TestMethod]
        public void Calculate_for_AnnualSalary_18201_to_37000()
        {
            EmployeePayslipViewModel viewModel = new EmployeePayslipViewModel()
            {
                Employee = new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Robert",
                    LastName = "Naomi",
                    AnnualSalary = 20000,
                    SuperRate = 5,
                    PaymentDateId = Guid.Parse("{71DFC804-1F03-4A3E-B979-457D4142D480}")
                }
            };

            var result = controller.Calculate(viewModel) as ViewResult;
            var modelResult = (EmployeePayslipViewModel)result.Model;
            Assert.AreEqual("Robert Naomi", modelResult.Name);
            Assert.AreEqual("01 October to 31 October", modelResult.PaymentDateDescription);
            Assert.AreEqual(1667, modelResult.GrossIncome);
            Assert.AreEqual(29, modelResult.IncomeTax);
            Assert.AreEqual(1638, modelResult.NetIncome);
            Assert.AreEqual(83, modelResult.Super);

        }

        [TestMethod]
        public void Calculate_for_AnnualSalary_37001_to_87000()
        {
            EmployeePayslipViewModel viewModel = new EmployeePayslipViewModel()
            {
                Employee = new Employee() {
                    Id = Guid.NewGuid(),
                    FirstName = "David",
                    LastName = "Rudd",
                    AnnualSalary = 60050,
                    SuperRate = 9,
                    PaymentDateId = Guid.Parse("{DF929BE5-8AF5-449A-9C0E-C6014B6894E7}")
                }
            };

            var result = controller.Calculate(viewModel) as ViewResult;
            var modelResult = (EmployeePayslipViewModel)result.Model;
            Assert.AreEqual("David Rudd", modelResult.Name);
            Assert.AreEqual("01 March to 31 March", modelResult.PaymentDateDescription);
            Assert.AreEqual(5004, modelResult.GrossIncome);
            Assert.AreEqual(922, modelResult.IncomeTax);
            Assert.AreEqual(4082, modelResult.NetIncome);
            Assert.AreEqual(450, modelResult.Super);
            
        }

        [TestMethod]
        public void Calculate_for_AnnualSalary_87001_to_180000()
        {
            EmployeePayslipViewModel viewModel = new EmployeePayslipViewModel()
            {
                Employee = new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Ryan",
                    LastName = "Chen",
                    AnnualSalary = 120000,
                    SuperRate = 10,
                    PaymentDateId = Guid.Parse("{DF929BE5-8AF5-449A-9C0E-C6014B6894E7}")
                }
            };

            var result = controller.Calculate(viewModel) as ViewResult;
            var modelResult = (EmployeePayslipViewModel)result.Model;
            Assert.AreEqual("Ryan Chen", modelResult.Name);
            Assert.AreEqual("01 March to 31 March", modelResult.PaymentDateDescription);
            Assert.AreEqual(10000, modelResult.GrossIncome);
            Assert.AreEqual(2669, modelResult.IncomeTax);
            Assert.AreEqual(7331, modelResult.NetIncome);
            Assert.AreEqual(1000, modelResult.Super);

        }

        [TestMethod]
        public void Calculate_for_AnnualSalary_180001_to_indefinite()
        {
            EmployeePayslipViewModel viewModel = new EmployeePayslipViewModel()
            {
                Employee = new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Joe",
                    LastName = "Jackson",
                    AnnualSalary = 190000,
                    SuperRate = 10,
                    PaymentDateId = Guid.Parse("{AB483398-D570-4974-8D60-AA1534CA32E4}")
                }
            };

            var result = controller.Calculate(viewModel) as ViewResult;
            var modelResult = (EmployeePayslipViewModel)result.Model;
            Assert.AreEqual("Joe Jackson", modelResult.Name);
            Assert.AreEqual("01 April to 30 April", modelResult.PaymentDateDescription);
            Assert.AreEqual(15833, modelResult.GrossIncome);
            Assert.AreEqual(4894, modelResult.IncomeTax);
            Assert.AreEqual(10939, modelResult.NetIncome);
            Assert.AreEqual(1583, modelResult.Super);

        }

        

        

    }
}
