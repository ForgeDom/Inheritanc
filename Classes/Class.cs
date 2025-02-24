using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanc.Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }

        public Animal(string name, string habitat, string diet)
        {
            Name = name;
            Habitat = habitat;
            Diet = diet;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Habitat: {Habitat}, Diet: {Diet} ");
        }
        public class Tiger : Animal
        {
            public Tiger(string name, string habitat, string diet) : base(name, habitat, diet)
            {
            }

            public void Roar()
            {
                Console.WriteLine($"{Name} is roraring");
            }
        }

        public class Crocodile : Animal
        {
            public Crocodile(string name, string habitat, string diet) : base(name, habitat, diet)
            {
            }
            public void Swim()
            {
                Console.WriteLine($"{Name} is swimming");
            }
        }

        public class Kenguru : Animal
        {
            public Kenguru(string name, string habitat, string diet) : base(name, habitat, diet)
            {
            }
            public void Jump()
            {
                Console.WriteLine($"{Name} is jumping");
            }
        }
    }
}
