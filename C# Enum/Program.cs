using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum -> enumeration'ın kısaltması. (sıralama anlamına geliyor)
            //Sıralı olan verilerde, ardışık indexler ile çalışılması gereken noktalarda çok kurtarıcı oluyor.
            //Birden fazla sabite aynı anda ihtiyacınız varsa (değeri belli olan değişşkenler), noktasında kodun okunabilirliğini arttımak için kullanılır.
            //Programda birçok yerde değişken tanımlayıp onlara tek tek değerlerini atamak yerine enum kullanılabilir.

            //Ardışık olan, indexin tek tek arttığı ve hiç değişmeyeceğini düşündüğümüz bir örnek : Günler.

            //Söz dizimi: enum anahtar kelimesi - enum ın adı - {}

            //Uygulama içerisinde hızlıca erişebileceğimiz, çok kullandığımız ve anlamlı olarak tutmak istediğimiz değişkenleri enumlar ile tutabiliriz.

            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);

            int sıcaklık = 32;

            if(sıcaklık <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            else if(sıcaklık >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hadi dışarıya çıkalım!");

        }

        enum Gunler 
        {
            Pazartesi, // default 0 dan başlar. Pazaretesi=1 diyerek de belirtebiliriz
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi = 23, // ct 23 olduğu için, hep bir ardışık gider ve pazar 24 olur.
            Pazar
        }

        enum HavaDurumu
        {
            Soguk = 5,        //Uygulama içerisinde kullanacağımız normları belirliyoruz.
            Normal = 20,
            Sıcak = 25,
            CokSıcak = 30
        }
    }
}