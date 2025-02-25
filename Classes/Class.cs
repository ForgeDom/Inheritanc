using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanc.Classes
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public Worker(string name, int age, string position, double salary)
        {
            Name = name;
            Age = age;
            Position = position;
            Salary = salary;
        }
        public abstract void Print();
    }

    public class President : Worker
    {
        public President(string name, int age, string position, double salary) : base(name, age, position, salary)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Position: {Position}, Salary: {Salary}");
        }
    }
    public class Manager : Worker
    {
        public Manager(string name, int age, string position, double salary) : base(name, age, position, salary)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Position: {Position}, Salary: {Salary}");
        }
    }

    public class Engineer : Worker
    {
        public Engineer(string name, int age, string position, double salary) : base(name, age, position, salary)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Position: {Position}, Salary: {Salary}");
        }
    }
}
