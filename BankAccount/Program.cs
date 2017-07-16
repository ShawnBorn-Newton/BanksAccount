using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        private static double checkingBalance;
        private static double saveingsBalance;
        static void Main(string[] args)
        {

            // instantiate client, checking, saveings
            Client steveSteve = new Client("Grey", "Grey", "Steve Steve");
            
            Saveings saveStare = new Saveings(0001, 50.00d);
            Checking makeItRain = new Checking(4987, 123456.99d);
            bool exit = false;
            string toMM = "";
            
            // do while until exit
            do
            {
                // menu switch case calls methods
                Console.WriteLine("\tWeclome to FakeBank, please enter a selection.\n");
                Console.WriteLine("\t\t[1]We know what you look like.\n\n\t\t[2]View account balences."
                    + "\n\n\t\t[3]Deposit Funds \n\n\t\t[4]Withdraw Funds \n\n\t\t[5]Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        do
                        {                          
                                Console.WriteLine("Welcom: ");
                                steveSteve.GetClientInfo();
                                Console.WriteLine("\n[R] to main menu.");
                                toMM = Console.ReadLine().ToLower();
                                                      
                        }
                        while (toMM != "r" );
                        break;
                        
                    case "2":
                        Console.WriteLine("\t Which balance would you like?"
                            + "\n\t\t[A] Checking Account\n\t\t[B] Saveings Account");
                        string accountSelect = Console.ReadLine().ToLower();
                        if (accountSelect == "a")
                        {
                            makeItRain.GetChecking();
                        }
                        if(accountSelect == "b")
                        {
                            saveStare.GetSaveings();
                        }
                        
                        break;
                    case "3":
                        Console.WriteLine("\t For which account would you like make a deposit?"
                       + "\n\t\t[A] Checking Account\n\t\t[B] Saveings Account");
                        string depositSelect = Console.ReadLine().ToLower();
                        if(depositSelect == "a")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            double deposit = double.Parse(Console.ReadLine());
                            makeItRain.MakeDeposit(checkingBalance, deposit);
                            makeItRain.GetChecking();
                        }
                        if (depositSelect == "b")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            double deposit = double.Parse(Console.ReadLine());
                            saveStare.MakeDeposit(checkingBalance, deposit);
                            saveStare.GetSaveings();
                        }
                        break;
                    case "4":
                        Console.WriteLine("\t For which account would you like to make a withdraw?"
                     + "\n\t\t[A] Checking Account\n\t\t[B] Saveings Account");
                        string withdrawSelect = Console.ReadLine();
                        if (withdrawSelect == "a")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            double withdraw = double.Parse(Console.ReadLine());
                            makeItRain.MakeWithdraw(checkingBalance, withdraw);
                            makeItRain.GetChecking();
                        }
                        if (withdrawSelect == "b")
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            double withdraw = double.Parse(Console.ReadLine());
                            saveStare.MakeWithdraw(checkingBalance, withdraw);
                            saveStare.GetSaveings();
                        }
                        break;
                    case "5":
                        Console.WriteLine("Thank you for banking with FakeBank.");
                        exit = true;
                        break;
                }

            }
            while (exit == false);   
        }

    }
}
