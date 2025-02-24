using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanc.Classes
{
    public class Passport
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public void Display()
        {
            Console.WriteLine("Passport Information");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"BirthDate: {BirthDate}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"City: {City}");
        }
    }

    public class ForeignPassport : Passport
    {
        public string Visa { get; set; }
        public string ExpiryDate { get; set; }
        public string PassportNumber { get; set; }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Foreign Passport Information");
            Console.WriteLine($"Visa: {Visa}");
            Console.WriteLine($"ExpiryDate: {ExpiryDate}");
            Console.WriteLine($"PassportNumber: {PassportNumber}");
        }
    }
}
