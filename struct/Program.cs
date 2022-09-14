Dikdortgen dikdortgen=new Dikdortgen();
dikdortgen.kisaKenar=3;
dikdortgen.uzunKenar=4;

Console.WriteLine("Class Alan Hesabı : ",dikdortgen.alanHesapla());

//Dikdortgen_Struct dikdortgen_struct=new Dikdortgen_Struct();
Dikdortgen_Struct dikdortgen_struct; // new yazmadan bu şekilde de tanımlanabilir.

dikdortgen_struct.kisaKenar=3;
dikdortgen_struct.uzunKenar=4;

Console.WriteLine("Struct alan hesabı : ",dikdortgen_struct.alanHesapla());



class Dikdortgen{
    public int kisaKenar;
    public int uzunKenar;

    public long alanHesapla(){
        return this.kisaKenar*this.uzunKenar;
    }
}

struct Dikdortgen_Struct{
    public int kisaKenar;
    public int uzunKenar;

    public long alanHesapla(){
        return this.kisaKenar*this.uzunKenar;
    }
}