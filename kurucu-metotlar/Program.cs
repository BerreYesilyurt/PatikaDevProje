
/*Calisan calisan1=new Calisan("Berre","Yeşilyurt",2054,"Bilgisayar Mühendisliği");
calisan1.CalisaninBilgileri();*/

/*calisan1.ad="Berre";
calisan1.soyad="Yeşilyurt";
calisan1.no=23;
calisan1.departman="Bilişim";

calisan1.CalisaninBilgileri();*/

Calisan calisan1=new Calisan("Berre","Yeşilyurt");
calisan1.CalisaninBilgileri();




class Calisan{

    public string ad;
    public string soyad;
    public int no;
    public string departman;

    public Calisan(string Ad, string Soyad, int No, string Departman)
    {
        this.ad=Ad;
        this.soyad=Soyad;
        this.no=No;
        this.departman=Departman;
    }

    public Calisan(string Ad, string Soyad)
    {
        this.ad=Ad;
        this.soyad=Soyad;
    }

    public Calisan() { }

    public void CalisaninBilgileri(){

        Console.WriteLine("Çalışanın Adı : {0}",ad);
        Console.WriteLine("Çalışanın Soyadı : {0}",soyad);
        Console.WriteLine("Çalışanın Numarası : {0}",no);
        Console.WriteLine("Çalışanın Departmanı : {0}",departman);
    }
}