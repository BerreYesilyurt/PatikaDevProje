// See https://aka.ms/new-console-template for more information
int deger=2;

string degisken=null;
string Degisken=null;

byte b=5;
sbyte c=6;

short d=5;
ushort e=5;

Int16 i16=5;
int i=7;
Int32 i32=7;
Int64 i64=7;

uint i2=7;
long l=7;
ulong ul=7;

float r=5;
double h=5.0;
decimal de=7;

char f='f';

string kelime="Hello";

bool b1=true;
bool b2=false;

DateTime dt=DateTime.Now;

Console.WriteLine(dt);


object o1=4;
object o2=4.6;
object o3="hey";
object o4='5';

string str1=string.Empty;
str1="Berre Yeşilyurt";
string isim="Berre";
string soyisim="Yeşilyurt";
string tamIsim=isim+"  "+soyisim;

int integer1=4;
int integer2=integer1*7;

bool bool1=10<2;

Console.WriteLine(bool1);

string str20="20";
int sayi20=20;

string birlesim=str20+sayi20.ToString();

Console.WriteLine(birlesim);

int int21=sayi20+Convert.ToInt32(str20);

Console.WriteLine(int21);

int sayi22=sayi20+int.Parse(str20);

string datetime=DateTime.Now.ToString("dd-MM-yyyy");
Console.WriteLine(datetime);

string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string hour=DateTime.Now.ToString("HH-mm");
Console.WriteLine(hour);

