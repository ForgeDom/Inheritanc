using Inheritanc.Classes;

namespace Inheritanc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[]
           {
                new Rectangle(5, 10),
                new Circle(5),
                new Triangle(5, 10)
           };

            foreach (var figure in figures)
            {
                figure.GetArea();
            }
        }
    }
}
