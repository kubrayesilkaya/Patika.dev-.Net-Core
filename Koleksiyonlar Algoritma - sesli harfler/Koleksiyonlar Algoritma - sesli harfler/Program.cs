using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Algoritma___sesli_harfler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle girin: ");
            string cumle = Console.ReadLine().ToLower(); // Cümlenin tüm harflerini küçük harfe çeviriyoruz

            char[] sesliHarfDizisi = cumle
                .Where(c => "aeiouAEIOU".Contains(c)) // Sadece sesli harfleri seçiyoruz
                .Distinct() // Tekrar eden harfleri kaldırıyoruz
                .OrderBy(c => c) // Harf sıralaması yapılıyor
                .ToArray(); // Sonucu bir diziye dönüştürüyoruz

            // bool sonuc = anaDize.Contains(arananAltDize);

            Console.WriteLine("Sesli harf dizisi:");
            foreach (char harf in sesliHarfDizisi)
            {
                Console.WriteLine(harf);
            }

            Console.ReadLine();
        }
    }
}
