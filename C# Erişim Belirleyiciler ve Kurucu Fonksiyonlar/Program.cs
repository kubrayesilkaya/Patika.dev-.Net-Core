using System;

namespace C__Eri_im_Belirleyiciler_ve_Kurucu_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kurucu metotlar bir sııfın nesnesi oluşturulduğunda, yani new ile yeni bir nesnesini oluşturduğumuzda,
               arka planda otomatik olarak çalıştırılan metotlardır.
               Kurucu = yapıcı metotlar = constructorlar

               Biz bir nesne oluşturduğumuzda otomatik olarak arka planda yapılmasını istediğimiz işlemler varsa, bir nesne ayağa kalktığında,
               bunları kurucu metotlar içerisinde yaparız.
            */

            /* Kurucu metotlar nasıl tanımlanır?
               
               * Kurucu metotların isimleri sınıf ismi ile aynı olmak zorundadır. 

               * Kurucu metotların erişim belirleyicileri mutlaka public olmak zorunda; private olarak tanımlanamaz.

               * Kurucu metotların geri dönüş tipi yoktur.Geri dönüş tipi yazılmaz. 

               * Kurucu fonksiyonlar normal fonksiyonlar gibi overload edilebilirler.
            */

            Calisan calisan1 = new Calisan("Ayşe","Kara", 23425634, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("**********************************************************");
            
            Calisan calisan2 = new Calisan("Deniz", "Arda", 25646789, "Satın Alma");
            calisan2.CalisanBilgileri();

            Console.WriteLine("**********************************************************");

            Calisan calisan3 = new Calisan("Ali", "Deniz");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        //Constructor - kurucu metot 
        public Calisan(string ad, string Soyad, int No, string Departman)
        {
            this.Ad = ad;
            this.Soyad = Soyad;
            this.No = No;
            this.Departman = Departman;
        }

        // Constructor'ı aşırı yükleyelim
        public Calisan(string ad, string Soyad)
        {
            this.Ad = ad;
            this.Soyad = Soyad;
        }

        //Parametresiz constructor
        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}",Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}",No);
            Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }
    }
}
