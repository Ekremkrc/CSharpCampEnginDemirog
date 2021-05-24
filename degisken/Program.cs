using System;

namespace Deneme1
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategori";
            int ogrencisayisi = 32000;
            double FaizOrani = 1.45;
            bool SistemeGirisYapmisMi = true;



            if (SistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

        }
    }
}
