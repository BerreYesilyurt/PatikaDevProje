Console.WriteLine("Çalışan Sayısı: ",Calisan.CalisanSayisi);

Calisan calisan=new Calisan("Berre","Yeşilyurt","Yazılım");

Console.WriteLine("Çalışan Sayısı: ",Calisan.CalisanSayisi);


Islemler.Topla(5,3);
Islemler.Cikart(5,3);



class Calisan{

    private static int calisanSayisi;

    public static int CalisanSayisi{
        get {return calisanSayisi;}
    }

    private string isim;
    private string soyisim;
    private string departman;

    static Calisan(){ 
        // Static kurucuların erişim belirteçleri olmaz.
        calisanSayisi=0;


    }

    public Calisan(string isim, string soyisim,string departman){
        this.isim=isim;
        this.soyisim=soyisim;
        this.departman=departman;
        calisanSayisi++;
    }

}

static class Islemler{
    public static long Topla(int sayi1, int sayi2){
        Console.WriteLine(sayi1+sayi2);
        return sayi1+sayi2;

        
    }

    public static long Cikart(int sayi1, int sayi2){
        Console.WriteLine(sayi1-sayi2);
        return sayi1-sayi2;

    }

}