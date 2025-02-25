using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanc.Classes
{
    public class Device
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public string Show { get; set; }
        public string Description { get; set; }

        public Device() { }

        public Device(string name, string sound, string show, string description)
        {
            Name = name;
            Sound = sound;
            Show = show;
            Description = description;
        }

        public void MakeSound()
        {
            Console.WriteLine(Sound);
        }

        public void DisplayShow()
        {
            Console.WriteLine(Show);
        }

        public void DisplayDescription()
        {
            Console.WriteLine(Description);
        }
    }

    public class Kettle : Device
    {
        public Kettle(string name, string sound, string show, string description)
            : base(name, sound, show, description) { }
    }

    public class Microwave : Device
    {
        public Microwave(string name, string sound, string show, string description)
            : base(name, sound, show, description) { }
    }

    public class Car : Device
    {
        public Car(string name, string sound, string show, string description)
            : base(name, sound, show, description) { }
    }
}
