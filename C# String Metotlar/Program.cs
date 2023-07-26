using System;

namespace C__String_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string degisken = "Dersimiz CSharp, Hosgeldiniz!";
            string degisken2 = "CSharp";

            //Lenght
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper()); 
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken,"Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); 
            Console.WriteLine(String.Compare(degisken,degisken2,true) );  //ignore Case-->true
            Console.WriteLine(String.Compare(degisken,degisken2,false) ); //ignore Case -->false
            //CompareTo(0,1,-1) --> Birinci değşken ikinci değişkene eşit olursa condition 0 döndürür.
            //                  --> Birinci değişken ikinci değişkenden daha büyük bir karakter sayısına sahip ise 1 döndürür.
            //                  --> Birinci değiken ikinci değişkenden daha küçük bir karakter sayısına sahip ise -1 döndürür.

            //Contains
            Console.WriteLine(degisken.Contains(degisken2)); //degisken içerisinde degisken2 var mı.
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba'"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CSharp")); //İfadedeki ilk karakteri bulduğu indexi döner (C)
            Console.WriteLine(degisken.IndexOf("Kübra"));  //Bulunamadığında -1 döner

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba")); //Verdiğimiz start indexten itibaren stringin başına verdiğmiz ifadeyi ekler.
            Console.WriteLine(degisken.LastIndexOf("i")); //verilen ifadenin stringde bulunduğu son indexi getitir

            //PadLeft, PadRight;
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //degisken2'nin sonuna 30'a tamamlayacak kadar boşluk ekler. 
                                                                 //(degisken2'nin karakter sayısı + boşluk = 30)
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); //verilen indexden başlayarak siler
            Console.WriteLine(degisken.Remove(5,3)); //5.index'den başlayarak 3 karakter siler (aradan silme)
            Console.WriteLine(degisken.Remove(0,1)); //Baştan silme -> 0.indexden başlayarak 1 karakter sil

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#")); //CSharp'ı C# ile değiştir
            Console.WriteLine(" ","*"); //Boşlukları yıldız ile değiştir

            //Split
            Console.WriteLine(degisken.Split(' ')[1]); //Boşluklara göre parçala ve bir diziye ata, ve 1.indexteki veriyi getir.

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));


        }
    }
}