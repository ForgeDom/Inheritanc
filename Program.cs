using Inheritanc.Classes;

namespace Inheritanc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            President president = new President("John", 45, "President", 100000);
            Manager manager = new Manager("Jane", 35, "Manager", 50000);
            Engineer engineer = new Engineer("Jack", 25, "Engineer", 30000);

            president.Print();
            manager.Print();
            engineer.Print();
        }
    }
}
