using System;

namespace _3_gun3_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Göktuğ";
            musteri1.Soyad = "Sözbir";
            musteri1.KrediLimit = 1000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Sözbir";
            musteri2.KrediLimit = 20500;

            Musteri[] musteriler = new Musteri[]
            {
                musteri1,
                musteri2
            };

            foreach (var x in musteriler)
            {
                Console.WriteLine(x.Id);
                Console.WriteLine(x.Ad);
                Console.WriteLine(x.Soyad);
                Console.WriteLine(x.KrediLimit);
                Console.WriteLine("-----------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.List(musteri1);
            musteriManager.List(musteri2);




        }
    }
}
