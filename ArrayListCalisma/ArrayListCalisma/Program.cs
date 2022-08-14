using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            liste.Add("Merhaba");
            liste.Add(7);
            liste.Add(true);

            Console.WriteLine(liste[2]);

            string[] renkler = {"Beyaz","Yeşil","Mavi"};

            List<object> degerler = new List<object>() { 1, 2, 3, "Hello", "world", 4, 5, 6, 7 };

            liste.AddRange(renkler);
            liste.AddRange(degerler);

            foreach(var deger in liste)
            {
                Console.WriteLine(deger);
            }

        }
    }
}
