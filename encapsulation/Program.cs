Ogrenci ogrenci=new Ogrenci();
ogrenci.Isim="Ayşe";
ogrenci.Soyisim="Yılmaz";
ogrenci.OgrenciNo=254;
ogrenci.Sinif=3;

ogrenci.OgrenciBilgileriniGetir();
ogrenci.SinifAtlat();
ogrenci.OgrenciBilgileriniGetir();


class Ogrenci{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim{
        get{return isim;}
        set{isim=value;}
    }

    public string Soyisim{
        get{return soyisim;}
        set{soyisim=value;}
    }

    public int OgrenciNo{
        get{return ogrenciNo;}
        set{ogrenciNo=value;}
    }

    public int Sinif{
        get{return sinif;}
        set{
            if(value<1){


                Console.WriteLine("Sınıf en düşük 1 olabilir.");
                sinif=1;
            }
            else       
                sinif=value;
        }

            
        
    }

    public Ogrenci(){}

    public Ogrenci(string isim,string soyisim,int ogrenciNo,int sinif){
        this.isim=isim;
        this.soyisim=soyisim;
        this.ogrenciNo=ogrenciNo;
        this.sinif=sinif;
        
    }

    public void OgrenciBilgileriniGetir(){
        Console.WriteLine("Öğrenci Adı : "+this.Isim);
        Console.WriteLine("Öğrenci Soyadı : "+this.Soyisim);
        Console.WriteLine("Öğrenci Numara : "+this.OgrenciNo);
        Console.WriteLine("Öğrenci Sınıf : "+this.Sinif);
    }

    public void SinifAtlat(){
        this.Sinif=this.Sinif+1;
    }

    public void SinifDusur(){

        this.Sinif=this.Sinif-1;
    }

}