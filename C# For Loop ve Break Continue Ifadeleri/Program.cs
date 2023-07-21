using System;

namespace C__For_Loop_ve_Break_Continue_Ifadeleri
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for(int i=1; i<=sayac; i++)
            {
                if(i%2 == 1)
                    Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for(int i = 1; i<=1000; i++)
            {
                if(i%2 == 1)
                    tekToplam += i;  // tekToplam = tekToplam + i;
                else
                    ciftToplam += i; // tekToplam = tekToplam + i;
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: "+ ciftToplam);

            // break, continue

            for(int i = 1; i<10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }

            for(int i = 1; i<10; i++)
            {
                if(i==4)
                  continue;
                Console.WriteLine(i);
            }

            //Döngü içerisinde döngü kullanmamız gereken durumlarda direkt sadece kendi içindeki current loop'u (o an içinde olduğu loopu) sonlandırır.
            //Eğer iç içe üç tane loop varsa ve en içteki loop içerisinde bir case'e bağlı olarak bir tane break ifadesi kullanıldıysa, 
            //tüm üstteki iki loop sonlanmaz, orası devam eder ve her zaman en içteki loptan çıkmmış olur.

        }
    }
}
