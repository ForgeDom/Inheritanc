using Inheritanc.Classes;

namespace Inheritanc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kettle kettle = new Kettle("Bravo", "Ketlle is making sound", "Kettle", "An electric kettle");
            Microwave microwave = new Microwave("Samsung", "Microwave is making sound", "Microwave", "A microwave oven");
            Car car = new Car("Toyota", "Car is making sound", "Car", "A car");


            DisplayDeviceDetails(kettle);
            DisplayDeviceDetails(microwave);
            DisplayDeviceDetails(car);
        }
        static void DisplayDeviceDetails(Device device)
        {
            device.DisplayShow();
            device.MakeSound();
            device.DisplayDescription();
            Console.WriteLine();
        }
    }
    
}