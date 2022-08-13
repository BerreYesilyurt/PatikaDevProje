// See https://aka.ms/new-console-template for more information

int x=3;
int y=4;

x+=y;
y+=x;

Console.WriteLine(x+y);

x/=3;
y/=2;

bool a=true;
bool b=false;

if(a && b){
    Console.WriteLine("True");
}

if(a && !b){
    Console.WriteLine("True");
}

if(!a && b){
    Console.WriteLine("True");
}

int c=7;
int d=17;

bool sonuc=c>d;
Console.WriteLine(sonuc);

sonuc=d>c;
Console.WriteLine(sonuc);

int k=10;
int l=5;

Console.WriteLine(k+l);
Console.WriteLine(k-l);
Console.WriteLine(k*l);
Console.WriteLine(k/l);
Console.WriteLine(k%l);


