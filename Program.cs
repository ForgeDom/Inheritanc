using Inheritanc.Classes;

namespace Inheritanc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Tiger", "Jungle", "Meat");
            tiger.Display();
            tiger.Roar();

            Crocodile crocodile = new Crocodile("Crocodile", "River", "Meat");
            crocodile.Display();
            crocodile.Swim();

            Kenguru kenguru = new Kenguru("Kenguru", "Australia", "Grass");
            kenguru.Display();
            kenguru.Jump();
        }
    }
}
