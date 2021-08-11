using System;
using System.Collections.Generic;
using System.Text;

namespace _3_gun3_odev
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Krediniz Eklendi!!!" + " " + musteri.Ad + "Bey");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("Krediniz Listelendi!!!" + " " + musteri.Ad + "Bey");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Krediniz Silindi!!!" + " " + musteri.Ad + "Bey");
        }
    }
}
