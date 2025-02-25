using Inheritanc.Classes;
using System.Security.Cryptography.X509Certificates;

namespace Inheritanc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Skripka skripka = new Skripka("Skripka", "Strunniy", "Skripka", "Skripka is a string instrument", "Skripka is a very old instrument");
            Trambon trambon = new Trambon("Trambon", "Duhovoy", "Trambon", "Trambon is a wind instrument", "Trambon is a very old instrument");
            Okulele okulele = new Okulele("Okulele", "Strunniy", "Okulele", "Okulele is a string instrument", "Okulele is a very old instrument");
            Violonchel violonchel = new Violonchel("Violonchel", "Strunniy", "Violonchel", "Violonchel is a string instrument", "Violonchel is a very old instrument");

            Display(skripka);
            Display(trambon);
            Display(okulele);
            Display(violonchel);

            static void Display(MusicalInstrument musicalInstrument)
            {
                musicalInstrument.Show();
                musicalInstrument.Desc();
                musicalInstrument.HistoryInfo();
                musicalInstrument.MakeSound();
            }

        }
    }
}
