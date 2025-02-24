using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanc.Classes
{
    public abstract class Figure
    {
        public abstract void GetArea();
    }

    public class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override void GetArea()
        {
            Console.WriteLine($"The area of rectanle is {Width * Height}");
        }
    }
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override void GetArea()
        {
            Console.WriteLine($"The area of circle is {Math.PI * Math.Pow(Radius, 2)}");
        }
    }
    public class Triangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
        public override void GetArea()
        {
            Console.WriteLine($"The area of triangle is {Base * Height / 2}");
        }
    }
    public class Trapezoid : Figure
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }
        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }
        public override void GetArea()
        {
            Console.WriteLine($"The area of trapezoid is {(Base1 + Base2) * Height / 2}");
        }
    }
}
