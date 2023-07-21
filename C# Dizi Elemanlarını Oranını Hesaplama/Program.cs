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

     // The plusMinus function accepts INTEGER_ARRAY arr as parameter.

    public static void plusMinus(List<int> arr)
    {
        float positive_numbers=0;
        float negative_numbers=0;
        float zeros_numbers=0;
        
        for(int i=0; i<arr.Count;i++)
        {
            if(arr[i] <0)
            {
                negative_numbers++;
            }
            else if(arr[i]==0)
            {
                zeros_numbers++;
            }
            else if(arr[i]>0)
            {
                positive_numbers++;
            }
        }
        float ratio_positive_numbers = positive_numbers/arr.Count;
        float ratio_negative_numbers = negative_numbers/arr.Count;
        float ratio_zeros_numbers = zeros_numbers/arr.Count;
        
        Console.WriteLine(ratio_positive_numbers.ToString("F6"));
        Console.WriteLine(ratio_negative_numbers.ToString("F6"));
        Console.WriteLine(ratio_zeros_numbers.ToString("F6"));

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
