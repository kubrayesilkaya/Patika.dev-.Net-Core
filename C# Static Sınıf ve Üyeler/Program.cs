using System;

namespace C__Static_S_n_f_ve__yeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir sınıf içerisindeki static olmayan fieldlara, metotlara, özelliklere o sınıftan oluşturduğunuz nesne aracılığıyla ulaşırsınız.
            //Static olan elemanlara ise o sınıfın adı ile erişilir; bir nesne oluşturmaya gerek yoktur ki oluşturulamaz.
            //O sınıfın adı .(nokta) erişmek istenilen metot ya da özellik denilerek erişilebilir.

            //Bir sınıf static ise, o sınıf içerisindeki tüm proportyler, tüm fieldlar, tüm metotlar mutlaka static olmak zorunda.
            //Static classlar içerisinde static olmayan herhangi bir üye kullanılamaz.

            //Static sınıfların içerisinde static olmayan herhangi bir metot ve proporty kullanamayız, tanımlayamayız.
            //Static sınıflara kalıtım işşlemi uygulanamaz.

            Console.WriteLine("Çalışan Sayısı :{0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe","Yılmaz","IK");
            Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz","Arda","IK");
            Calisan calisan2 = new Calisan("Ali","Güneş","IK");

            Console.WriteLine("Çalışan Sayısı : {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Çıkar(400,50));
        }

    }

            class Calisan 
            {
                private static int calisanSayisi;

                public static int CalisanSayisi {get => calisanSayisi; }

                private string Isim;
                private string Soyisim;
                private string Departman;

                static Calisan(){
                    calisanSayisi = 0;
                }

                public Calisan(string isim, string soyisim, string departman )
                {
                    this.Isim = isim;
                    this.Soyisim = soyisim;
                    this.Departman = departman;
                    calisanSayisi ++;
                }
            } 


            static class Islemler
            {
                public static long Topla(int sayi1, int sayi2)
                {
                    return sayi1 + sayi2;
                }
                public static long Çıkar(int sayi1, int sayi2)
                {
                    return sayi1 - sayi2;
                }
            }
        }
    
