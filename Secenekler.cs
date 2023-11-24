using System;
using System.Collections.Generic;
using System.Linq;

namespace telefon_rehberi;

class Secenekler : Yardimci
{
    private string[] bilgiler;
    private List<Kisi> bulunanlar;
    private Kisi kisi;

    protected void Ekle()
    {
        string[] bilgiler = base.BilgiAl();
        kisiler.Add(new Kisi(bilgiler[0], bilgiler[1], bilgiler[2]));
        Console.WriteLine("Kişi eklendi!");
    }

    protected void Sil()
    {
        Tekrar:
        Console.WriteLine("Silinecek kişinin isim ve soyisim bilgilerini arada boşluk olacak şekilde giriniz!");
        bilgiler = BilgiAl();
        
        bulunanlar = Ara(bilgiler[0], bilgiler[1]);
        switch (bulunanlar.BosMu())
        {
            case true:
                Yazdir(Sabitler.Bulunamadi);
                if (EvetHayir())
                    goto Tekrar;
                break;
            case false:
                kisi = bulunanlar[0];
                Console.WriteLine($"{kisi.Isim} {kisi.Soyisim} rehberden silinsin mi?");
                switch (EvetHayir())
                {
                    case true:
                        kisiler.Remove(kisi);
                        Console.WriteLine("Kişi silindi!");
                        break;
                    case false:
                        Yazdir(Sabitler.Iptal);
                        break;
                }
                break;
        }
    }
    
    protected void Guncelle()
    {
        Tekrar:
        bilgiler = BilgiAl();
        bulunanlar = Ara(bilgiler[0], bilgiler[1]);
        switch (bulunanlar.BosMu())
        {
            case true:
                Yazdir(Sabitler.Bulunamadi);
                if (EvetHayir())
                    goto Tekrar;
                break;
            case false:
                kisi = bulunanlar[0];
                Console.WriteLine("Güncellemek istediğiniz bilgileri doldurunuz. Güncellemek istemediklerinizi boş bırakabilirsiniz!");
                
                bilgiler = base.BilgiAl();
                kisi.Isim = !string.IsNullOrEmpty(bilgiler[0]) ? bilgiler[0] : kisi.Isim;
                kisi.Soyisim = !string.IsNullOrEmpty(bilgiler[1]) ? bilgiler[1] : kisi.Soyisim;
                kisi.TelefonNo = !string.IsNullOrEmpty(bilgiler[1]) ? bilgiler[2] : kisi.TelefonNo;

                int i = kisiler.IndexOf(bulunanlar[0]);
                kisiler[i] = kisi;
                Console.WriteLine("Kişi güncellendi!");
                break;
        }
    }

    protected void Listele()
    {
        Tekrar:
        Console.WriteLine("(1) A - Z sıralı listele");
        Console.WriteLine("(2) Z - A sıralı listele");
        switch (Console.ReadLine())
        {
            case "1":
                kisiler = kisiler.OrderBy(I => I.Isim + I.Soyisim + I.TelefonNo).ToList();
                break;
            case "2":
                kisiler = kisiler.OrderByDescending(I => I.Isim + I.Soyisim + I.TelefonNo).ToList();
                break;
            default:
                Yazdir(Sabitler.Gecersiz);
                goto Tekrar;
        }
        Console.WriteLine("Telefon Rehberi");
        Yazdir(Sabitler.Cizgi);
        kisiler.ForEach(I => Console.WriteLine(I));
        Console.WriteLine("Kişiler listelendi!");
    }

    protected void KisiAra()
    {
        Tekrar:
        Console.WriteLine("(1) İsim ve soyisim ile ara / (2) Numara ile ara");
        switch (Console.ReadLine())
        {
            case "1":
                bilgiler = BilgiAl();
                bulunanlar = base.Ara(bilgiler[0], bilgiler[1]);
                break;
            case "2":
                    Console.Write("Telefon No: ");
                    bulunanlar = base.Ara(Console.ReadLine());
                break;
            default:
                Yazdir(Sabitler.Gecersiz);
                goto Tekrar;
        }
        if (bulunanlar.BosMu())
        {
            Yazdir(Sabitler.Bulunamadi);
            switch (EvetHayir())
            {
                case true:
                    goto Tekrar;
            }
        }
        else
        {
            Console.WriteLine("Arama Sonuçlarınız:");
            Yazdir(Sabitler.Cizgi);
            bulunanlar.ForEach(I => Console.WriteLine(I));
        }
    }

//      Kalıtımla gelip düzenlenen sanal metotlar
    protected override string[] BilgiAl()
    {
        Tekrar:
        Console.Write("İsim - Soyisim: ");
        bilgiler = Console.ReadLine().DiziYap();
        if (bilgiler.Length != 2)
        {
            Yazdir(Sabitler.Gecersiz);
            goto Tekrar;
        } 
        return bilgiler;
    }

    protected override List<Kisi> Ara(string isim, string soyisim)
    {
        return kisiler.FindAll(I => I.Isim == isim && I.Soyisim == soyisim);
    }
}