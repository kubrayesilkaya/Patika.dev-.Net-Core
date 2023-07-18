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


    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double total_cost;
        total_cost = meal_cost + (tip_percent*(meal_cost/100)) + (tax_percent*(meal_cost/100));
        
        Console.WriteLine(Math.Round(total_cost));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        //Console.ReadLine() ifadesi, kullanıcının girdiği değeri okur.
        //Trim(), kullanıcının girdiği değerin başındaki ve sonundaki gereksiz boşlukları kaldırır.
        //Convert.ToDouble(), girilen değeri double veri tipine dönüştürür.

        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}

