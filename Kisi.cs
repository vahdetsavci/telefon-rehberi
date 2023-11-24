namespace telefon_rehberi;

struct Kisi
{
    private string isim;
    private string soyisim;
    private string telefonNo;

    internal string Isim { get => isim; set => isim = value; }
    internal string Soyisim { get => soyisim; set => soyisim = value; }
    internal string TelefonNo { get => telefonNo; set => telefonNo = value; }

    internal Kisi(string isim, string soyisim, string telefonNo) : this()
    {
        Isim = isim;
        Soyisim = soyisim;
        TelefonNo = telefonNo;
    }

    public override string ToString()
    {
        return $"| {Isim} | {Soyisim} | {TelefonNo} |";
    }
}