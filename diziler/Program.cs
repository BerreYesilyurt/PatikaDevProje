// See https://aka.ms/new-console-template for more information
string[] renkler=new string[10];

renkler[0]="mavi";

Console.WriteLine(renkler[0]);

int[] sayilar;
sayilar=new int[7];;
sayilar[4]=55;

Console.WriteLine(sayilar[4]);


Console.Write("Dizinin uzunluğunu giriniz ");
int uzunluk=int.Parse(Console.ReadLine());

int[] rakamlar=new int[uzunluk];

for(int i=0;i<uzunluk;i++){
    Console.Write("Eleman giriniz ");
    
    rakamlar[i]=int.Parse(Console.ReadLine());
    
}

foreach (var rakam in rakamlar)
{
    Console.WriteLine(rakam);
    
}
     