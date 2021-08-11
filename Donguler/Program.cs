using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirme kampı";
            string kurs2 = "programlamaya giriş";
            string kurs3 = "java kursu";

            string[] kurslar = new string[]
            {
                "yazılım geliştirme kampı",
                "programlamaya giriş",
                "java kursu",
                "pyhton", 
                "mallar için kurs"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine("Kurs:" + kurslar[i]);
            }
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("+++++++++++++sayfa sonuuuu++++++++++++++++++");
        }
    }
}
