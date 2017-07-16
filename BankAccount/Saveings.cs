using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Saveings : Account
    {
        //fields
        protected int saveingsNumber;
        protected double saveingsBalance;
        //properties
        public int SaveingsNumber { get; }
        public double SaveingstBalance { get; }

        public Saveings()
        {
            //default
        }

        public Saveings(int saveingsNumber, double saveingsBalance)
        {
            this.saveingsBalance = saveingsBalance;
            this.saveingsNumber = saveingsNumber; 
        }

        public virtual void GetSaveings()
        {
            Console.WriteLine("Your saveing balace is: " + saveingsBalance);
        }
        public override double MakeDeposit(double saveingsBalance, double deposit)
        {
            saveingsBalance = saveingsBalance + deposit;
            return saveingsBalance;

        }
        public virtual double MakeWithdraw(double saveingsBalancee, double withdraw)
        {
            saveingsBalance = saveingsBalance - withdraw;
            return saveingsBalance;
        }

        public override double DisplayBalance()
        {
            throw new NotImplementedException();
        }
    }
}
