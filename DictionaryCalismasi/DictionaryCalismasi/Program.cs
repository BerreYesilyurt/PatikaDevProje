using System;
using System.Collections.Generic;

namespace DictionaryCalismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(1, "Hello World");
            kullanicilar.Add(2, "Merhaba Dünya");

            Console.WriteLine(kullanicilar[2]);



            Console.WriteLine(kullanicilar.Count);

            Console.WriteLine(kullanicilar.ContainsKey(1));
            Console.WriteLine(kullanicilar.ContainsValue("hello"));

            kullanicilar.Remove(1);

            foreach (var yazi in kullanicilar)
            {
                Console.WriteLine(yazi);
            }
        }
    }
}
