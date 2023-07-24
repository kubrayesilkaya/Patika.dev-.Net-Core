using System;

namespace C__Rek_rsif_ve_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz Yinelemeli
            // 3^4 =3*3*3*3

            //for döngüsü ile
            int result = 1;
            for (int i = 1; i <5; i++)
                result = result * 3;
                Console.WriteLine(result);
                Islemler instance = new();
                Console.WriteLine(instance.Expo(3,4));

                //Extension Metotlar
                string ifade = "Kübra Yeşilkaya";
                //Cümle içerisinde boşluk olup olmadığını dönen extension metot
                bool sonuc = ifade.CheckSpaces();
                Console.WriteLine(sonuc);

                //Eğer boşluk varsa bu boşluğu dilen ye da başka bir kararketerle değiştiren bir extension metot.
                if(sonuc)
                    Console.WriteLine(ifade.RemoveWhiteSpaces());
                Console.WriteLine(ifade.MakeUpperCase());  //Verilen ifadeyi uppercase'e çevirme
                Console.WriteLine(ifade.MakeLowerCase());  //Verilen ifadeyi lowercase'e çevirme

                //integer diziyi sıralayan bir extension metot
                int[] dizi = {9,3,6,2,1,5};
                dizi.SortArray();
                dizi.EkranaYazdir();    

                //Verilen integer sayının çift bir sayı olup olmadığını kontrol eden extension metot
                int sayi = 5;
                Console.WriteLine(sayi.IsEvenNumber());
                
                //Verilen stringin ilk karakterini getiren extension metot
                Console.WriteLine(ifade.GetFirstCharacter());
            }
        }

        public class Islemler{
            
            public int Expo(int sayi, int üs)
            {
                if(üs<2)
                    return sayi;
                return Expo(sayi,üs-1)*sayi;
            }
            //Expo(3,4)
            //Expo(3,3) * 3;
            //Expo(3,2) * 3;
            //Expo(3,1) *3 *3 *3;
            // 3*3*3*3 = 3^4;
        }

        //Extension class'lar ve extension metotlar static olmalı. Static olmaz ise bunlara erişemeyiz; 
        //Çünkü nesnesi olmadan erişebiliyor olmamız gerekiyor.

        public static class Extension{
            public static bool CheckSpaces(this string param)
            {
                //Contains bir string kütüphanesi metodudur.
                return param.Contains(" "); //içerisinde boşluk varsa bunu dön
            }

            public static string RemoveWhiteSpaces(this string param)
            {
                string[] dizi = param.Split(" "); // Bu stringi boşluklara göre ayır ve bir diziye at.
                return string.Join("",dizi); //Boşlukları, white space olmayan boş string ile değiştirmiş olacak.
                // return sting.Join("*",dizi) --> olsaydı boşlukların yerini yıldız ile değiştirirdi.
            }

            public static string MakeUpperCase(this string param)
            {
                return param.ToUpper();
            }

            public static string MakeLowerCase(this string param)
            {
                return param.ToLower();
            }

            public static int[] SortArray(this int[] param)
            {
                Array.Sort(param);
                return param;
            }

            public static void EkranaYazdir(this int[] param)
            {
                foreach(var item in param)
                Console.WriteLine(item);
            }

            public static bool IsEvenNumber(this int param)
            {
                return param%2 == 0;
            }

            public static string GetFirstCharacter(this string param)
            {
                return param.Substring(0,1); // Substring, string kütüphanesi metodudur -> start index'den bailayarak verilen değer kadar karakter döndürür.
            }
        }

    }
