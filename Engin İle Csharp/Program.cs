using System;

namespace Engin_İle_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string KategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool SistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
            


            if (SistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Sisteme Giriş Yapılmıştır!!");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yapılmamıştır!!");
            }

            Console.WriteLine(KategoriEtiketi);

             
        }
    }
}
