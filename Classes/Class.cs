using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanc.Classes
{
    public enum Currency
    {
        USD,
        EUR,
        GBP,
        JPY
    }
    public enum Cent
    {
        Cents,
        Pence,
        EuroCent,
        Yen
    }
    public class Money
    {
        public int WholePart { get; set; }
        public int FractionalPart { get; set; }
        public Currency CurrencyType { get; set; }
        public Cent CentType { get; set; }
        public Money(int WwolePart, int fractionalPart, Currency currencyType, Cent centType)
        {
            WholePart = WwolePart;
            FractionalPart = fractionalPart;
            CurrencyType = currencyType;
            CentType = centType;
        }
        public void SetMoney(int wholePart, int fractionalPart, Currency currencyType, Cent centType)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
            CurrencyType = currencyType;
            CentType = centType;
        }
        public void Display()
        {
            Console.WriteLine($"{WholePart} {CurrencyType} and {FractionalPart} {CentType}");
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }
        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }
        public void ReducePrice(int wholePart, int fractionalPart)
        {
            int totalFractionalPart = Price.FractionalPart - fractionalPart;
            int totalWholePart = Price.WholePart - wholePart;

            if (totalFractionalPart < 0)
            {
                totalWholePart -= 1;
                totalFractionalPart += 100;
            }

            Price.SetMoney(totalWholePart, totalFractionalPart, Price.CurrencyType, Price.CentType);
        }
        public void Display()
        {
            Console.WriteLine($"Product: {Name}");
            Price.Display();
        }
    }
}