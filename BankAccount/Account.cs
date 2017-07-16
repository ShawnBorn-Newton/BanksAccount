using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount 
{
    abstract class Account : Program
    {
        //fields
        protected int accountNumber;
        protected double accountBalance;
        //properties
        public int AccountNumber { get; }
        public double AccountBalance { get; }
        //constuctors
        public Account()
        {
            //defalt
        }
        public Account(int accountNumber, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
        }
        //methods
        public abstract double DisplayBalance();
       
        public virtual double MakeDeposit(double accountBalace, double deposit)
          {
            accountBalance = accountBalance + deposit;
            return accountBalance;
          }
}
}
