using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_Menüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int islem;
            Console.WriteLine("**** Matematik Dünyasına Hoşgeldiniz ...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**** Menü ****");
            Console.WriteLine();
            Console.WriteLine("1- Aritmetik Dört İşlem");
            Console.WriteLine("2- Üs Alma");
            Console.WriteLine("3- Kök Alma");
            Console.WriteLine("4- Karenin Çevre ve Alanını Hesaplama");
            Console.WriteLine("5- Dikdörtgende Çevre ve Alan Hesaplama");
            Console.WriteLine("6-Eşkenar üçgende çevre");
            Console.WriteLine();
            Console.WriteLine("****      ****");
            Console.WriteLine("Lütfen Yukarıdaki Menüden Yapmak İstediğiniz İşlemin Numarasını Giriniz: ");
            Console.WriteLine();
            islem = Convert.ToInt32(Console.ReadLine());
            if (islem == 1)
            {
                int topla, cıkar, çarp, böl, s1, s2;
                Console.WriteLine("1. Sayıyı Giriniz: ");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sayıyı Giriniz: ");
                s2 = Convert.ToInt32(Console.ReadLine());

                topla = s1 + s2;
                cıkar = s1 - s2;
                çarp = s1 * s2;
                böl = s1 / s2;
                Console.WriteLine("Toplam : "+topla);
                Console.WriteLine("Cıkarma: "+cıkar);
                Console.WriteLine("Çarpma: "+çarp);
                Console.WriteLine("Bölme: "+böl);
            }
            if (islem == 2)
            {
                int sayi1, sayi2,sonuc;
                Console.WriteLine("Üssü Alınacak Değeri Giriniz: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Üs Değerini Giriniz: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sonuç: " + Math.Pow(sayi1, sayi2));
            }
            if (islem == 3)
            {
                int kök;
                Console.WriteLine("Kökü Alınacak Sayıyı Giriniz: ");
                kök = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sonuç: " + Math.Sqrt(kök));
            }
            if (islem == 4)
            {
                int kare,alan,çevre;
                Console.WriteLine("Karenin Kenarını Giriniz: ");
                kare = Convert.ToInt32(Console.ReadLine());

                alan = kare * kare;
                çevre = kare * 4;
                Console.WriteLine("Karenin Alanı: "+alan);
                Console.WriteLine("Karenin Çevresi: "+çevre);
            }
            if (islem == 5)
            {
                int kk, uk, dalan, dcevre;
                Console.WriteLine("Kısa Kenarı Giriniz: ");
                kk = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Uzun Kenarı Giriniz: ");
                uk = Convert.ToInt32(Console.ReadLine());
                dalan = kk * uk;
                dcevre = (kk * 2) + (uk * 2);
                Console.WriteLine("Dikdörtgenin Alanı: "+dalan);
                Console.WriteLine("Dikdörtgenin Çevresi: "+dcevre);
            }
            if (islem == 6)
            {
                int ücgen, üccevre;
                Console.WriteLine("Üçgenin Kenarını Giriniz: ");
                ücgen = Convert.ToInt32(Console.ReadLine());
                üccevre = ücgen * 3;
                Console.WriteLine("Üçgenin Çevresi: "+üccevre);

            }
            Console.Read();
        }
    }
}
