// See https://aka.ms/new-console-template for more information
byte a=2;
short b=5;
sbyte c=4;

int d=a+b+c;

Console.WriteLine(d);

long h=d;

float i=h;

string x="hello";
char y='z';
object z=x+y;

Console.WriteLine(z);

int p=4;

byte l=(byte)p;

int xx=5;
string yy=xx.ToString();

Console.WriteLine(yy);

int sayi=10;
string yazi="50";

Console.WriteLine(sayi+Convert.ToInt32(yazi));

static void ParseMethod(){
    string yazim="10.25";
    int rakam=Int32.Parse(yazim);
    Console.WriteLine(rakam);


}

ParseMethod();