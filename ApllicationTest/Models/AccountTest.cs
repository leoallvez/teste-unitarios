using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Apllication.Models;

using NUnit.Framework;

namespace ApllicationTest.Models
{
    [TestFixture] // to indicate that the class contains test code
    public class AccountTest
    {
        [Test]
        public void TransferFunds()
        {
            Account source = new Account();
            source.Deposit(200m);

            Account destination = new Account();
            destination.Deposit(150m);

            source.TransferFunds(destination, 100m);

            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
        }
    }
}