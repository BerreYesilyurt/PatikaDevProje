// See https://aka.ms/new-console-template for more information
string kelime=Console.ReadLine();

Console.WriteLine(kelime.Length);

Console.WriteLine(kelime.ToUpper());

Console.WriteLine(kelime.ToLower());

Console.WriteLine(String.Concat(kelime,"Hello world"));

Console.WriteLine(kelime.CompareTo("Merhaba"));

Console.WriteLine(String.Compare(kelime,"Merhaba"));

Console.WriteLine(kelime.EndsWith("hey"));

Console.WriteLine(kelime.StartsWith("hey"));

Console.WriteLine(kelime.Contains("hey"));

Console.WriteLine(kelime.IndexOf("di")); //Bulduğu ilk indeksi döner.

Console.WriteLine(kelime.Insert(0,"y"));

Console.WriteLine(kelime.LastIndexOf("e"));

Console.WriteLine(kelime.PadLeft(20));
Console.WriteLine(kelime.PadRight(20));

Console.WriteLine(kelime.Remove(0,2));

Console.WriteLine(kelime.Replace("e","a"));

Console.WriteLine(kelime.Split(" ",kelime[0]));