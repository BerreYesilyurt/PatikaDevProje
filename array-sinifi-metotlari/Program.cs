// See https://aka.ms/new-console-template for more information
int[] rakamlar={1,2,3,4,5,6,7};

Array.Sort(rakamlar);

Array.Clear(rakamlar,3,3);

foreach (var no in rakamlar)
{
    Console.Write(no);
    Console.WriteLine(" ");
    
}

Array.Reverse(rakamlar);

foreach (var no in rakamlar)
{
    Console.Write(no);
    Console.WriteLine(" ");
    
}

Console.WriteLine(Array.IndexOf(rakamlar,7));

 