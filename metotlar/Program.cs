// See https://aka.ms/new-console-template for more information

int a=3;
int b=2;

string c=Console.ReadLine();

Hello hello=new Hello();
hello.EkranaYazdir(c);

Topla(a,b);



int Topla(int sayi1,int sayi2){

    Console.WriteLine(a+b);

    return a+b;

}

class Hello{
    public void EkranaYazdir(string a){
        Console.WriteLine(a);

    }


}