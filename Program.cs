using Inheritanc.Classes;
using System.Security.Cryptography;

namespace Inheritanc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human
            {
                Name = "John",
                Surname = "Doe",
                Age = 30,
                Gender = "Male"
            };
            human.DisplayInfo();

            Builder builder = new Builder
            {
                Name = "Bob",
                Surname = "Pagani",
                Age = 45,
                Gender = "Male"
            };
            builder.DisplayInfo();
            builder.Build();

            Sailor sailor = new Sailor
            {
                Name = "Jack",
                Surname = "Sparrow",
                Age = 50,
                Gender = "Male"
            };
            sailor.DisplayInfo();
            sailor.Sail();

            Pilot pilot = new Pilot
            {
                Name = "Siri",
                Surname = "Travolta",
                Age = 60,
                Gender = "Female"
            };
            pilot.DisplayInfo();
            pilot.Fly();
        }
    }
}
