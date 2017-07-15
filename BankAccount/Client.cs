using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        private string hairColor;
        private string eyeColor;
        private string name;

        public string HairColor { get; }
        public string EyeColor { get; }
        public string Nmae { get; }

        public Client()
        {
            //defalt
        }
        
        public Client(string hairColor, string eyeColor, string name)
        {
            this.name = name;
            this.hairColor = hairColor;
            this.eyeColor = eyeColor;
        }
        public virtual void GetClientInfo()
        {
            Console.WriteLine("Name: " + name + "\nHair Color: " + hairColor + "\nEye Color: " + eyeColor);
        }
    }
}
