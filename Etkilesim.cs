using System;

namespace telefon_rehberi;

sealed class Etkilesim : Secenekler
{
    internal void Arayuz()
    {
        Tekrar:
        string secim = Giris();
        switch (secim)
        {
            case "1":
                Ekle();
                goto Tekrar;
            case "2":
                Sil();
                goto Tekrar;
            case "3":
                Guncelle();
                goto Tekrar;
            case "4":
                Listele();
                goto Tekrar;
            case "5":
                KisiAra();
                goto Tekrar;
            case "6":
                break;
            default:
                Yazdir(Sabitler.Gecersiz);
                goto Tekrar;
        }
    }
}