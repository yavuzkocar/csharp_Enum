using System;

namespace csharp_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Gunler.pazar);
           Console.WriteLine((int)Gunler.pazar);//pazarın indexisini gör

           int sıcaklık= 32;

           if (sıcaklık<=(int) HavaDurumu.normal)
               Console.WriteLine("dışarıya cıkmak için havanın biraz daha ısınmasını beklemelisin.");
           else if (sıcaklık>=(int)HavaDurumu.sıcak)
               Console.WriteLine("dışarıya cıkmak için çok sıcak bir gün.");
            else if (sıcaklık>= (int)HavaDurumu.normal && sıcaklık<(int) HavaDurumu.coksıcak)
                Console.WriteLine("Hadi dışarıya çıkalım.");

          

        }
    }
    enum Gunler// her değişken index alır 1 artarak ilerler imleci üzerine tut indexsi gör istersen yeni değer gir.
    {
        Pazartesi=1,

        salı,

        carsamba,
        persembe,
        cuma,
        cumartesi,
        pazar

    }

enum HavaDurumu
{
    soguk=5,
    normal=20,
    sıcak=25,
    coksıcak=30,
}
}
