using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Algoritma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            for(int i = 0; i < 20;  i++)
            {
                Console.WriteLine($"Lütfen {i+1}. sayıyı girin: ");
                sayilar[i] = Convert.ToInt32( Console.ReadLine());
            }

            Array.Sort(sayilar); // Sayıları küçükten büyüğe sırala

            int enKucukToplam = 0;
            int enBuyukToplam = 0;

            // En küçük 3 sayının toplamını ve en büyük 3 sayının toplamını hesapla
            for(int i = 0; i < 3; i++)
            {
                enKucukToplam += sayilar[i];
                enBuyukToplam += sayilar[sayilar.Length - 1 - i];
            }

            // Ortalamalarını hesapla
            double enKucukOrtalama = (double)enKucukToplam / 3;
            double enBuyukOrtalama = (double)enBuyukToplam / 3;

            // Sonuçları ekrana yazdır 
            Console.WriteLine($"En küçük 3 sayının toplamı: {enKucukToplam}");
            Console.WriteLine($"En küçük 3 sayının ortalaması: {enKucukOrtalama}");
            Console.WriteLine($"En büyük 3 sayının toplamı: {enBuyukToplam}");
            Console.WriteLine($"En büyük 3 sayının ortalaması: {enBuyukOrtalama}");

            Console.ReadLine();
        }
    }
}
