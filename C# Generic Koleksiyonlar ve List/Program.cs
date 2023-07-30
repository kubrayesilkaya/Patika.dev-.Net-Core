﻿using System;
using System.Collections.Generic;

namespace C__Generic_Koleksiyonlar_ve_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T-> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.ForEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            //index ile eleman çıkarma
            sayiListesi.RemoveAt(0); 
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste içerisinde arama     
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde bulundu!");

            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));    

            //Diziyi List'e çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi= new List<Kullanıcılar>();
           
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim ="Ayşe";
            kullanıcı1.Soyisim ="Yılmaz";
            kullanıcı1.Yas=26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı1.Isim ="Ali";
            kullanıcı1.Soyisim ="Yılmaz";
            kullanıcı1.Yas=26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

                   
        }

        public class Kullanıcılar{
            private string isim;
            private string soyisim;
            private int yas;

            public string Isim { get => isim; set => isim = value;}
            public string Soyisim { get => soyisim; set => soyisim = value;}
            public int Yas { get => yas; set => yas = value;}
        }
    }
}