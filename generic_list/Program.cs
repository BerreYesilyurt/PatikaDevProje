// See https://aka.ms/new-console-template for more information
List<int> sayiListesi=new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(24);
sayiListesi.Add(25);
sayiListesi.Add(26);
sayiListesi.Add(27);

List<string>  stringListesi=new List<string>();

stringListesi.Add("hello");
stringListesi.Add("world");
stringListesi.Add("merhaba");

Console.WriteLine(sayiListesi.Count);
Console.WriteLine(stringListesi.Count);

foreach (var sayilar in sayiListesi)
{
    Console.WriteLine(sayilar);   
}


stringListesi.Remove("hello");
stringListesi.RemoveAt(1);

foreach (var stringler in stringListesi)
{
    Console.WriteLine(stringler);
    
}


if(sayiListesi.Contains(23)){

    Console.WriteLine("Aranan değer bulundu.");
}


string[] harfler={"a","b","c","d","e","f"};

List<string> harflerListesi=new List<string>(harfler);

foreach (var harf in harflerListesi)
{
    Console.WriteLine(harf);
    
}


List<Kullanicilar> kullanicilar1=new List<Kullanicilar>();

Kullanicilar kullanicilar=new Kullanicilar();

kullanicilar.Isim="Beyza";
kullanicilar.Soyisim="Yeşilyurt";
kullanicilar.Yas=16;

kullanicilar1.Add(kullanicilar);


Kullanicilar kullanicilar2=new Kullanicilar();

kullanicilar2.Isim="Erva";
kullanicilar2.Soyisim="Yeşilyurt";
kullanicilar2.Yas=7;

kullanicilar1.Add(kullanicilar2);


foreach(var deneme in kullanicilar1){
    Console.WriteLine(deneme.Isim);
    Console.WriteLine(deneme.Soyisim);
    Console.WriteLine(deneme.Yas);
}



public class Kullanicilar{

    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}