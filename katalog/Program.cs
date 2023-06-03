using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katalog
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("kaç adet ürün gireceksiniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            string[] urun_adi = new string[sayi];
            int[] urun_fiyatı = new int[sayi];

            for (int i = 1; i <= sayi; i++)
            {
                Console.WriteLine(i + ". ürünün adının giriniz");
                urun_adi[i] = Console.ReadLine();
                Console.WriteLine( i + ". ürünün fiyatınnı giriniz");
                urun_fiyatı[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            for (int i = 1;i <= sayi; i++)
            {
                Console.WriteLine(urun_adi[i]+" " + urun_fiyatı[i]);
                Console.WriteLine();

            }































            Console.ReadLine();
        }
    }
}
