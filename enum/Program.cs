

Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);

int sicaklik=Convert.ToInt32(Console.ReadLine());

if(sicaklik<=(int)havaDurumu.Normal){
    Console.WriteLine("Hava soğuk");
}
enum Gunler{
    Pazartesi=1, 
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum havaDurumu{
    Soguk=5,
    Normal=20,
    Sıcak=25,
    ÇokSıcak=30

}