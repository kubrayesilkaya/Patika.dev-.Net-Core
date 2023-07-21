using System;

namespace C__Tan_mlama__Eris_im_ve_Do_ngu_lerle_Dizi_Kullan_m_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerle dizi kullanılması
            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for (int i = 0; i<diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayısı giriniz: ", i+1); 
                sayıDizisi[i] = int.Parse(Console.ReadLine());
                // {0} --> yer tutucu (placeholer)
                // Consol’a bir string değer yazılacağı zaman string değerler içerisine değişkenlerden değer aktarımı yapmak için kullanılır.
            }

            int toplam = 0;
            foreach (var sayi in sayıDizisi)
                toplam += sayi;

            Console.WriteLine("Ortalama: "+ toplam/diziUzunlugu);
        }
    }
}