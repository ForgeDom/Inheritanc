using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanc.Classes
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Gender: {Gender}");
        }
    }

    public class Builder : Human
    {
        public string Profession { get; } = "Builder";

        public void Build()
        {
            Console.WriteLine($"{Name} is building.");
        }
    }

    public class Sailor : Human
    {
        public string Profession { get; } = "Sailor";

        public void Sail()
        {
            Console.WriteLine($"{Name} is sailing.");
        }
    }

    public class Pilot : Human
    {
        public string Profession { get; } = "Pilot";

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }
}
