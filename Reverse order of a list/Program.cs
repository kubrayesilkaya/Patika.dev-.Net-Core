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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
        List<int> reverseArr = new List<int>();
        int k=n-1;
        foreach(int number in arr)
        {
            reverseArr.Add(arr[k]);
            k--;
        }
        foreach(int reverseNumber in reverseArr)
        {
            Console.Write(reverseNumber + " ");
        }
        
    }
}
