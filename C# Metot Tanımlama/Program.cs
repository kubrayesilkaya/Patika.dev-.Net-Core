using System;

namespace C__Metot_Tan_mlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
            //{
                ////komutlar;
                 // return;
            //}
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(ref a,ref b); //ref
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));
        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1,ref int deger2) //referans 
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }

        //referansını vermek = a ile b'nin değerlerini değil; bellekteki karşılıklarını vermek, işaret etmek.
        //Parametlerin adreslerini veriyor ve referanslar üzerinde, orijinal değişkenler üzerinde değişiklik yapılıyor; kopyalar üzerinde çalışılmıyor.
    }
}