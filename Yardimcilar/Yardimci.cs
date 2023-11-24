using System;
using System.Collections.Generic;

namespace telefon_rehberi;

abstract class Yardimci : Rehber
{
    string[] ifadeler = new string[]
    {
        "*************************************",
        "Geçersiz veri girişi yaptınız, lütfen sizden istenilen talimatlara uyun!",
        "İşlem iptal edildi!",
        "Herhangi bir sonuç bulunamadı! Tekrar denemek ister misiniz?"
    };

    protected bool EvetHayir()
    {
        Tekrar:
        Console.WriteLine("(E) Evet / (H) Hayır");
        switch (Console.ReadLine().ToLower())
        {
            case "e":
                return true;
            case "h":
                Yazdir(Sabitler.Iptal);
                return false;
            default:
                Yazdir(Sabitler.Gecersiz);
                goto Tekrar;
        }
    }

    protected void Yazdir(Sabitler talep)
    {
        Console.WriteLine(ifadeler[(int)talep]);
    }

    protected string Giris()
    {
        Yazdir(Sabitler.Cizgi);
        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz!");
        Yazdir(Sabitler.Cizgi);
        Console.WriteLine("(1) Yeni Kişi Ekle");
        Console.WriteLine("(2) Kayıtlı Kişiyi Sil");
        Console.WriteLine("(3) Kayıtlı Kişiyi Güncelle");
        Console.WriteLine("(4) Kayıtlı Kişileri Listele");
        Console.WriteLine("(5) Kayıtlı Kişiler İçinde Ara");
        Console.WriteLine("(6) Rehberden Çık");
        Yazdir(Sabitler.Cizgi);
        string secim = Console.ReadLine();
        Yazdir(Sabitler.Cizgi);
        return secim;
    }

    protected virtual List<Kisi> Ara(string isim, string soyisim)
    {
        return kisiler.FindAll(I => I.Isim == isim || I.Soyisim == soyisim);
    }

    protected List<Kisi> Ara(string numara)
    {
        return kisiler.FindAll(I => I.TelefonNo == numara);
    }

    protected virtual string[] BilgiAl()
    {
        string[] dizi = new string[3];
        Console.Write("İsim: ");
        dizi[0] = Console.ReadLine();
        Console.Write("Soyisim: ");
        dizi[1] = Console.ReadLine();
        Console.Write("Numara: ");
        dizi[2] = Console.ReadLine();
        return dizi;
    }

}