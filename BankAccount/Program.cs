﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            // instantiate client, checking, saveings
            Client steveSteve = new Client("Grey", "Grey", "Steve Steve");

            // do while until exit
            // menu switch case calls methods
            Console.WriteLine("\tWeclome to FakeBank, please enter a selection.\n");
            Console.WriteLine("\t\t[1]We know what you look like.\n\n\t\t[2]View account balences."
                + "\n\n\t\t[3]Deposit Funds \n\n\t\t[4]Withdraw Funds \n\n\t\t[5]Exit");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    Console.WriteLine("Welcom: ");
                       steveSteve.GetClientInfo();
                    break;
                case "2":
                    Console.WriteLine("\t Which balance would you like?" 
                        + "\n\t\t[A] Checking Account\n\t\t[B] Saveings Account");
                    string accountSelect = Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("\t For which account would you like make a deposit?"
                   + "\n\t\t[A] Checking Account\n\t\t[B] Saveings Account");
                    string depositSelect = Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("\t For which account would you like to make a withdraw?"
                 + "\n\t\t[A] Checking Account\n\t\t[B] Saveings Account");
                    string withdrawSelect = Console.ReadLine();
                    break;

                    


            }



        }
    }
}
