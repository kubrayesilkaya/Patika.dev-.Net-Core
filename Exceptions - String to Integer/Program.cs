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
        //Read a string, S , and print its integer value; if S cannot be converted to an integer, print Bad String.
        
        string S = Console.ReadLine();
        
        try 
        {
            int i = int.Parse(S);
            Console.WriteLine(i);
        }
        catch(FormatException)
        {
            Console.WriteLine("Bad String");
        }
    }
}
