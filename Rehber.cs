using System.Collections.Generic;

namespace telefon_rehberi;

class Rehber
{
    protected static List<Kisi> kisiler;

    static Rehber()
    {
        kisiler = new List<Kisi>()
        {
            new Kisi("Türkan", "Şoray", "5123456789"),
            new Kisi("Tarık", "Akan", "5213456789"),
            new Kisi("Yaşar", "Kemal", "5321456789"),
            new Kisi("Kazım", "Koyuncu", "542156789"),
            new Kisi("Nazım", "Hikmet", "552146789"),
        };
    }
}