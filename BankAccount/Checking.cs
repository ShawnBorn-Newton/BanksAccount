using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
        //fields
        protected int checkingNumber;
        protected double checkingBalance;
        //properties
        public int CheckingNumber { get; }
        public double CheckingBalance { get; set; }

        public Checking()
        {
            //default
        }

        public Checking(int checkingNumber, double checkingBalance)
        {
            this.checkingBalance = checkingBalance;
            this.checkingNumber = checkingNumber;
        }

        public virtual void GetChecking()
        {
            Console.WriteLine("Your checking balace is: " + checkingBalance);
        }

        public override double MakeDeposit(double chechingBalance, double deposit)
        {
            checkingBalance = checkingBalance + deposit;
            return checkingBalance;

        }

        public virtual double MakeWithdraw(double chechingBalance, double withdraw)
        {
            checkingBalance = checkingBalance - withdraw;
            return checkingBalance;
        }

        public override double DisplayBalance()
        {
            throw new NotImplementedException();
        }

  
    }
}
