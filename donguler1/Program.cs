// See https://aka.ms/new-console-template for more information
int sayac=int.Parse(Console.ReadLine());

int tekToplam=0;
int ciftToplam=0;


for(int i=0;i<=sayac;i++){

    if(i%2==0){
        Console.WriteLine(i+" - Çift Sayı");
        ciftToplam+=i;

    }

    else{
        Console.WriteLine(i+"  Tek Sayı");
        tekToplam+=i;
    }

}

Console.WriteLine("Tek sayıların toplamı : "+tekToplam);
Console.WriteLine("Çift sayıların toplamı : "+ciftToplam);

int sayi=int.Parse(Console.ReadLine());

for(int j=0;j<sayi;j++){

    if(j==2){
        continue;
    }
    Console.WriteLine(j);
}



