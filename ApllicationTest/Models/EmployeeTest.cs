using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Apllication.Models;

using NUnit.Framework; //Obrigatório

namespace ApllicationTest.Models
{
    [TestFixture]
    public class EmployeeTest
    {
        [Test]
        public void MyFirstTestMethod()
        {
            Assert.Pass();
            //Assert.Fail();

        }

        [Test]
        public void IntroduceMethodShouldWorkCorrectly()
        {
            var sut = new Employee("Alice", "Programmer", 100000);

            var expected = "Hi! My name is Alice and I work as a Programmer.";

            string result = sut.Introduce();

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GiveTenPercentRaiseShouldRaiseTheSalaryFrom100To110()
        {
            var raise = 10;
            var sut = new Employee("Bob", "Tester", 100);
            var expected = 110;

            sut.GiveRaise(raise);
            var newSalary = sut.Salary;

            Assert.AreEqual(expected, newSalary);
        }
    }
}