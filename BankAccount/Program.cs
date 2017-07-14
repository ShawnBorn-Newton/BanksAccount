using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {   // do while until exit
            // menu switch case calls methods
            Console.WriteLine("\tWeclome to FakeBank, please enter a selection.\n");
            Console.WriteLine("\t\t[1]We know what you look like.\n\n\t\t[2] View account balences."
                + "\n\n\t\t[3]Deposit Funds \n\n\t\t[4]Withdraw Funds \n\n\t\t[5]Exit");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    //call client info
                    break;
                case "2":
                    Console.WriteLine("");
                    break;
                case "3":

                    break;
                case "4":

                    break;

                    


            }
            
            // instantiate client, checking, saveings

        }
    }
}
