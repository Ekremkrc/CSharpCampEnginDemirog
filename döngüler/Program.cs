using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"kurs1", "kurs2", "kurs3", "kurs4"
           };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
              
        }
    }
}
