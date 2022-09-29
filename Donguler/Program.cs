 using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] kurslar = new string[] {"YAzilim Gelistirici Kursu",
                "Programlamaya baslangic",
                "Java" , "Python"};     


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            foreach (string kurs in kurslar)  //Arraylara uygulanir
            {
                Console.WriteLine(kurs);
            }





        }
    }
}
