using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Espression
            switch (month)
            {
                case 1: 
                    Console.WriteLine("Ocak Ayındasınız!");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız!");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayındasınız");
                    break ;
                case 3:
                    Console.WriteLine("Mart Ayındasınız!");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girdiniz!"); 
                break;
            }

            // Birden fazla case ifadesi tek bir kod bloğunu çalıştıracak şekilde yazılabilir:
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                  Console.WriteLine("Kış ayındasınız!");
                  break;
                
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındasınız!");
                    break;
                
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındasınız!");
                    break;
                
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayındasınız!");
                    break;
                default:
                break;
            }
        }
    }
}