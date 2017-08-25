using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apllication.Models
{
    public class Account
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }

        private decimal minimumBalance = 1;

        public decimal MinimumBalance
        {
            get { return minimumBalance; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
            if (balance - amount < minimumBalance)
                throw new InsufficientExecutionStackException();
            destination.Deposit(amount);
            Withdraw(amount);
        }

       
    }
}