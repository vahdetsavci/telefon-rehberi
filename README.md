# PatikaAcademy.dev / Başlangıç Seviyesi .Net Core Patikası / PROJE-1 : Console Telefon Rehberi Uygulaması
Bu proje **PatikaAcademy.dev** platformunun **Başlangıç Seviyesi .Net Core Patikası** eğitimi kapsamında **PROJE-1 : Console Telefon Rehberi Uygulaması** dersi için yapılmıştır.

| Projenin İçeriği | |
| :-:|:-: |
| 1 | README.md |
| 1 | .gitignore |
| 1 | LICENSE |
| 1 | Console Application |
| 9 | gorseller/fotograflar |

## Installation
Öncelikle projeyi klonlayın.

```
git clone https://github.com/vahdetsavci/telefon-rehberi.git
```

## Usage
Projeyi klonladıktan sonra **Visual Studio Code** programında açınız.

```
cd telefon-rehberi
code .
```

Bu proje bir telefon rehberi uygulaması olarak aşağıda yer alan özellikleri barındırır.

1. Telefon Numarası Kaydet
2. Telefon Numarası Sil
3. Telefon Numarası Güncelle
4. Rehber Listeleme (A-Z, Z-A seçimli)
5. Rehberde Arama

### Açıklama
* Uygulama ilk açıldığında varsayılan olarak 5 kişinin numarası rehbere kaydedilir ve uygulama kullanıcıya sunulur.

* Uygulama ilk açıldığında kullanıcıya seçenekler sunulur. Sunulan seçenekler arasından kullanıcının bir seçim yapması beklenir. Kullanıcı seçim yaptığında seçilen işlem çalışır.

![secenekler](gorseller/Arayuz.png)

#### (1) Yeni Kişi Ekle
![kisiEkle](gorseller/isim-soyisim-numara.png)

#### (2) Kayıtlı Kişiyi Sil
![kisiSil](gorseller/isim-soyisim.png)

* Aranan kişi rehberde bulunamazsa; 

![silinecekBulunamadi](gorseller/Silinecek-bulunamadi.png)

* Aranan kişi rehberde bulunursa;

![silinecekBulundu](gorseller/Silinsin-mi.png)

* **Not:** Uygun kriterlere sahip birden fazla kişi bulunursa ilk bulunan silinir.

#### (3) Kayıtlı Kişiyi Güncelle
![isimSoyisim](gorseller/isim-soyisim.png)

* Aranan kişi rehberde bulunamazsa;

![bulunamadi](gorseller/bulunamadi.png)

* **Not:** Uygun kriterlere sahip birden fazla kişi bulunursa ilk bulunan silinir.

#### (4) Kayıtlı Kişileri Listele
![rehberiListele](gorseller/Listele.png)

Tüm rehber aşağıdaki formatta listelenir.

![listelenmis](gorseller/Listelendi.png)

#### (5) Kayıtlı Kişiler İçinde Ara

![aramaTipi](gorseller/Arama-tipi.png)

![aramaSonuclari](gorseller/Arama-Sonuclari.png)

#### (6) Rehberden Çık
Kullanıcı bu seçeneği seçerek uygulayı sonlandırır.

# LICENSE
[MIT](LICENSE)