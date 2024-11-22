using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Dongusu_ile_Liste_Elemanlarini_Yazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList olarak Sort() Metodunu kullandım.
            int[] sayılar = { 1, 96, 18, 1024, 128, 41, 72, 8, 52, 524, 25, 968 };
            Array.Sort(sayılar);
            
            foreach (int i in sayılar)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine();

            int toplam = 0;
            foreach (int i in sayılar)
            {
                toplam = toplam + i;
            }

            Console.WriteLine("Listede Girilen Sayıların Toplamı: " + toplam);

            Console.ReadKey();
        }
    }
}
