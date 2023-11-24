using System.Collections.Generic;

namespace telefon_rehberi;

static class ExtensionClass
{
    internal static string[] DiziYap(this string param)
    {
        return param.Split(' ');
    }

    internal static bool BosMu(this List<Kisi> param)
    {
        if (param == null || param.Count == 0)
            return true;
        else
            return false;
    }
} 