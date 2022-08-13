// See https://aka.ms/new-console-template for more information
int time=DateTime.Now.Hour;

if(time<18){
    Console.WriteLine("İyi Günler");

}

else{
    Console.WriteLine("İyi Akşamlar");
}


string sonuc=time<18 ? "İyi Günler":"İyi Akşamlar";