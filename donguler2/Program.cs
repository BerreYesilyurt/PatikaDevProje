// See https://aka.ms/new-console-template for more information
Console.Write("Bir sayı giriniz");
int sayi=int.Parse(Console.ReadLine());
int sayac=1;
int toplam=0;
float ort;
int i=1;


/*for(int i=0;i<=sayi;i++){
    toplam+=i;
    sayac++;
}

ort=(toplam)/(sayac-1);*/



while(i<=sayi){
    toplam+=i;
    sayac++;
    i++;

}

ort=toplam/(sayac);

Console.WriteLine("Ortalama : "+ort);



string[] arabalar={"Honda","Bmw","Mercedes"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);

}

