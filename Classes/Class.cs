using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanc.Classes
{
    public class  MusicalInstrument
    {
        private string Name { get; set; }
        private string Type { get; set; }
        private string Sound { get; set; }
        private string Description { get; set; }
        private string History { get; set; }
        public MusicalInstrument(string name, string type, string sound, string description, string history)
        {
            Name = name;
            Type = type;
            Sound = sound;
            Description = description;
            History = history;
        }
        public void MakeSound()
        {
            Console.WriteLine(Sound);
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}");
        }

        public void Desc()
        {
            Console.WriteLine(Description);
        }

        public void HistoryInfo()
        {
            Console.WriteLine(History);
        }
    }

    public class Skripka : MusicalInstrument
    {
        public Skripka(string name, string type, string sound, string description, string history)
            : base(name, type, sound, description, history) { }
    }

    public class Trambon : MusicalInstrument
    {
        public Trambon(string name, string type, string sound, string description, string history)
            : base(name, type, sound, description, history) { }
    }

    public class Okulele : MusicalInstrument
    {
        public Okulele(string name, string type, string sound, string description, string history)
            : base(name, type, sound, description, history) { }
    }

    public class Violonchel : MusicalInstrument
    {
        public Violonchel(string name, string type, string sound, string description, string history)
            : base(name, type, sound, description, history) { }
    }
}
