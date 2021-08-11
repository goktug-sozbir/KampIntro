using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "c#";
            kurs1.Egitmen = "Göktuğ Sözbir";
            kurs1.IzlenmeOrani = 1000;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmen = "Zeynel";
            kurs2.IzlenmeOrani = 45;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egitmen = "Furkan";
            kurs3.IzlenmeOrani = 85;

            Kurs[] kurslar = new Kurs[] //dizi yaptık
            {
                kurs1, 
                kurs2,
                kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("kurs adı:" + kurs.KursAdı+ " // " + "kurs eğitmen:" + kurs.Egitmen + " // " + "kurs izlenme oranı:" + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
