using Inheritanc.Classes;

namespace Inheritanc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(10, 50, Currency.USD, Cent.Cents);
            money.Display();

            Product product = new Product("Laptop", money);
            product.ReducePrice(5, 20);
            product.Display();

        }
    }
}
