using System;

namespace C__Datetime_ve_Math_S_n_flar_
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın gününü string halde getirir.
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString);
            Console.WriteLine(DateTime.Now.ToShortTimeString);
            Console.WriteLine(DateTime.Now.ToLongTimeString);
            Console.WriteLine(DateTime.Now.ToShortTimeString); 

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format

            Console.WriteLine(DateTime.Now.ToString("dd"));    //ayın kaçı olduğunun integer karşılığını getirir (örn. 15.08.2023 için 25 getirir).
            Console.WriteLine(DateTime.Now.ToString("ddd"));   // ayın gününün string karşılığını 3 karakter olarak getitir. örn. salı -> sal
            Console.WriteLine(DateTime.Now.ToString("dddd"));  // ayın gününün string karşılığını getirir.

            Console.WriteLine(DateTime.Now.ToString("MM"));    // 05
            Console.WriteLine(DateTime.Now.ToString("MMMM"));  // Ağu
            Console.WriteLine(DateTime.Now.ToString("MMMM"));  //Ağustos

            Console.WriteLine(DateTime.Now.ToString("yy"));    //23
            Console.WriteLine(DateTime.Now.ToString("yyyy"));  //2023

            //Math Kütüphanesi

            Console.WriteLine("***** Math Kütüphanesi *****");

            Console.WriteLine(Math.Abs(-25)); // mutlak alır.
            Console.WriteLine(Math.Sin(10)); //sinüs alır
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); //22.3 den büyük en küçük tam sayıyı getirir, her zaman yukarıya yuvarlar.
            Console.WriteLine(Math.Round(22.3));   //22.3 e yakın olan tam sayıyı getitir, aşağıya ya da yukarıya yuvarlar.  22.3 -> 22
            Console.WriteLine(Math.Round(22.7));   //22.7 ->23
            Console.WriteLine(Math.Floor(22.7));   //22.7 den küçük en büyük tam sayıyı getirir, her zaman aşağıya yuvarlar.

            // iki sayının min ve max ını hesaplama
            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6)); 

            Console.WriteLine(Math.Pow(3,4));    // 3 üzeri 4 ü verir.
            Console.WriteLine(Math.Sqrt(9));     // karekök alır. -> 3
            Console.WriteLine(Math.Log(9));      // 9 un, e tabanındaki logaritmik karşılığını getirir.
            Console.WriteLine(Math.Exp(3));      // e üzeri 3 verir
            Console.WriteLine(Math.Log10(10));   // 10 sayısının logaritma 10 tabanındaki karşılığı
            
        }
    }
}