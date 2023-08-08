﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace C__ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            
            ArrayList liste = new ArrayList();
            liste.Add("Kübra");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisinde verilere erişim
            Console.WriteLine(liste[1]);

            foreach(var item in liste)
                Console.WriteLine(item);

            //AddRange
            Console.WriteLine("***** Add Range *****");
            string[] renkler = {"kırmızı","sarı","yesil"};
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach(var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("***** Sort *****");
            liste.Sort(); // arraydaki farklı türler karşılaştırılamaz! run time error

            //Binary Search
            Console.WriteLine("***** Binary Search");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("***** Reverse *****");
            liste.Reverse();
            foreach(var item in liste)
                Console.WriteLine(item);

            //Clear --> listeyi temizler
            liste.Clear();

            foreach(var item in liste)  
                Console.WriteLine(item);
        }
    }
    
}