using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Telefon_Rehberi_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonRehberi telefonRehberi = new TelefonRehberi();

            telefonRehberi.BaslangicRehberi();

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz : ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak﻿");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        telefonRehberi.YeniNumaraKaydet();
                        break;
                    case 2:
                        telefonRehberi.NumaraSil();
                        break;
                    case 3:
                        telefonRehberi.NumaraGuncelle();
                        break;
                    case 4:
                        telefonRehberi.RehberiListele();
                        break;
                    case 5:
                        telefonRehberi.RehberdeAramaYap();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
    class Kisi
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelefonNumarasi { get; set; }
    }

    class TelefonRehberi
    {
        private List<Kisi> rehber = new List<Kisi>();

        public void BaslangicRehberi()
        {
            rehber.Add(new Kisi { Isim = "Ayşem", Soyisim = "Keskin", TelefonNumarasi = "555-555-5555" });
            rehber.Add(new Kisi { Isim = "Ömer", Soyisim = "Karatepe", TelefonNumarasi = "555-555-5555" });
            rehber.Add(new Kisi { Isim = "Safiye", Soyisim = "Keskin", TelefonNumarasi = "555-555-5555" });
            rehber.Add(new Kisi { Isim = "Fahriye", Soyisim = "Paksoy", TelefonNumarasi = "555-555-5555" });
            rehber.Add(new Kisi { Isim = "Nail", Soyisim = "Keskin", TelefonNumarasi = "555-555-5555" });
        }

        public void YeniNumaraKaydet()
        {
            Console.WriteLine("Lütfen isim giriniz : ");
            string isim = Console.ReadLine();

            Console.WriteLine("Lütfen soyisim giriniz : ");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Lütfen teleofon numarası giriniz : ");
            string telefonNumarasi = Console.ReadLine();

            rehber.Add(new Kisi { Isim = isim, Soyisim = soyisim, TelefonNumarasi = telefonNumarasi });

            Console.WriteLine("Yeni numara kaydedildi.");
        }

        public void NumaraSil()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string aramaKelimesi = Console.ReadLine();

            Kisi kisi = rehber.Find(x => x.Isim == aramaKelimesi || x.Soyisim == aramaKelimesi);

            if(kisi == null)
            {
                Console.WriteLine("Aranan kişi rehberde bulunamadı. İşlemi sonlandırmak için (1), yeniden denemek için (2) tuşlayın.");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                    return;
            }
            else
            {
                Console.WriteLine($"{kisi.Isim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
                string onay = Console.ReadLine();

                if(onay.ToLower() == "y")
                {
                    rehber.Remove(kisi);
                    Console.WriteLine("Kişi rehberden silindi.");
                }
            }
        }

        public void NumaraGuncelle()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string aramaKelimesi = Console.ReadLine();

            Kisi kisi = rehber.Find(x => x.Isim == aramaKelimesi || x.Soyisim == aramaKelimesi);

            if(kisi == null)
            {
                Console.WriteLine("Aranan kişi rehberde bulunamadı. İşlemi sonlandırmak için (1), yeniden denemek için (2) tuşlayın.");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                    return;
            }
            else
            {
                Console.WriteLine($"Lütfen yeni telefon numarasını giriniz: ");
                string yeniTelefonNumarasi = Console.ReadLine();

                kisi.TelefonNumarasi = yeniTelefonNumarasi;

                Console.WriteLine("Telefon numarası güncellendi.");
            }
        }

        public void RehberiListele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*********************************************");

            foreach(var kisi in rehber)
            {
                Console.WriteLine($"İsim: {kisi.Isim} Soyisim: {kisi.Soyisim} Telefon Numarası: {kisi.TelefonNumarasi}");
            }
        }

        public void RehberdeAramaYap()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
            Console.WriteLine("****************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int secim = Convert.ToInt32(Console.ReadLine());

            if(secim == 1)
            {
                Console.WriteLine("Lütfen aramak istediğiniz isim veya soyisimi giriniz: ");
                string aramaKelimesi = Console.ReadLine();  

                var sonuclar = rehber.FindAll(x => x.Isim.Contains(aramaKelimesi) || x.Soyisim.Contains(aramaKelimesi));

                if(sonuclar.Count == 0)
                {
                    Console.WriteLine("Arama sonucuna uygun veri bulunamadı.");
                }
                else
                {
                    Console.WriteLine("Arama sonuçlarınız: ");
                    Console.WriteLine("************************************************");

                    foreach(var kisi in sonuclar)
                    {
                        Console.WriteLine($"İsim: {kisi.Isim} Soyisim: {kisi.Soyisim} Telefon Numarası: {kisi.TelefonNumarasi}");
                    }
                }
            }
            else if(secim == 2)
            {
                Console.WriteLine("Lütfen aramak istediğiniz telefon numarasını giriniz: ");
                string aramaKelimesi = Console.ReadLine();

                var sonuclar = rehber.FindAll(x => x.TelefonNumarasi.Contains(aramaKelimesi));

                if(sonuclar.Count == 0)
                {
                    Console.WriteLine("Arama sonucuna uygun veri bulunamadı.");
                }
                else
                {
                    Console.WriteLine("Arama Sonuçlarınız: ");
                    Console.WriteLine("************************************************");

                    foreach(var kisi in sonuclar)
                    {
                        Console.WriteLine($"İsim: {kisi.Isim} Soyisim: {kisi.Soyisim} Telefon Numarası: {kisi.TelefonNumarasi}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            }
        }
    }
}
