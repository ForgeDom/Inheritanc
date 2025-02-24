using Inheritanc.Classes;

namespace Inheritanc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passport passport = new Passport
            {
                Name = "John",
                Surname = "Doe",
                BirthDate = "01/01/1990",
                Country = "USA",
                City = "New York"
            };
            passport.Display();

            Console.WriteLine();

            ForeignPassport foreignPassport = new ForeignPassport
            {
                Name = "Jane",
                Surname = "Smith",
                BirthDate = "02/02/1985",
                Country = "USA",
                City = "Los Angeles",
                Visa = "Tourist",
                ExpiryDate = "12/31/2025",
                PassportNumber = "A12345678"
            };
            foreignPassport.Display();
        }
    }
}
