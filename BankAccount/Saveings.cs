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
        //constuctors
        public Saveings()
        {
            //default
        }

        public Saveings(int saveingsNumber, double saveingsBalance)
        {
            this.saveingsBalance = saveingsBalance;
            this.saveingsNumber = saveingsNumber; 
        }
        //methods
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
            if (saveingsBalance - withdraw < 25)
            {
                Console.WriteLine("You broke, can not withdraw bellow $25.");
            }
            else
            {
                saveingsBalance = saveingsBalance - withdraw;
            }
            return saveingsBalance;
        }

        //needed to make abstact Accounts works, someing is wrong here
        public override double DisplayBalance()
        {
            throw new NotImplementedException();
        }
    }
}
