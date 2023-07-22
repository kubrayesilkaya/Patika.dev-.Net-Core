using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * The function returns an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */
     
     /* Fonksiyonun calisma mantigi:
        Ilk olarak listeyi kucukten buyuge Sort metodu ile siraliyorum.
        Ardindan listenin son indeksindeki elemana, yani dizinin en buyuk elamanina
        isaret etmek icin, dizinin boyutundan (indeksi icin -1) yararlaniyorum.    
        Listedeki tum elemanlari for dongusu ile geziyorum ve eger listede en buyuk 
        eleman ile ayni degeri sahip bir eleman var ise sum degiskenini 
        arttiriyorum.   
    */
     
   

    public static int birthdayCakeCandles(List<int> candles)
    {
        int sum=0;
        candles.Sort();
        for(int i=0; i<candles.Count;i++)
        {
            if(candles[i] == candles[candles.Count-1])
            {
                sum++;
            }
            
        }
        return sum;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
