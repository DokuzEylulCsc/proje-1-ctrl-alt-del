using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kelimelik
{
    class Tur
    {
        Sozcuk[] kolay =
        {
            new Sozcuk("at"),new Sozcuk("in"),new Sozcuk("yol"),new Sozcuk("pul"),new Sozcuk("bul"),new Sozcuk("dik"),new Sozcuk("yan"),new Sozcuk("dar"),new Sozcuk("düz"),new Sozcuk("git"),new Sozcuk("gel"),
            new Sozcuk("yat"),new Sozcuk("düş"),new Sozcuk("bas"),new Sozcuk("bam"),new Sozcuk("gül"),new Sozcuk("yas"),new Sozcuk("yaş"),new Sozcuk("kalk"),new Sozcuk("kasa"),new Sozcuk("masa"),new Sozcuk("tork"),
            new Sozcuk("dost"),new Sozcuk("eşya"),new Sozcuk("saat"),new Sozcuk("inek"),new Sozcuk("baca"),new Sozcuk("koca"),new Sozcuk("bina"),new Sozcuk("kedi"),new Sozcuk("ağaç"),new Sozcuk("priz"),new Sozcuk("ayak"),
            new Sozcuk("soru"),new Sozcuk("çiçek"),new Sozcuk("araba"),new Sozcuk("kağıt"),new Sozcuk("katar"),new Sozcuk("safir"),new Sozcuk("düğme"),new Sozcuk("mesaj"),new Sozcuk("masaj"),new Sozcuk("sabit"),new Sozcuk("radyo"),
            new Sozcuk("resim"),new Sozcuk("sıcak"),new Sozcuk("soğuk"),new Sozcuk("sakız"),new Sozcuk("pazar"),new Sozcuk("sinek")
        };
        Sozcuk[] orta =
        {
            new Sozcuk("bölge"),new Sozcuk("saygı"),new Sozcuk("çaycı"),new Sozcuk("soluk"),new Sozcuk("tuzlu"),new Sozcuk("çöküş"),new Sozcuk("görüş"),new Sozcuk("gözcü"),new Sozcuk("satış"),new Sozcuk("bilgi"),new Sozcuk("doyum"),
            new Sozcuk("bilgi"),new Sozcuk("sayaç"),new Sozcuk("bencil"),new Sozcuk("gündüz"),new Sozcuk("tutsak"),new Sozcuk("tuzsuz"),new Sozcuk("içecek"),new Sozcuk("gözlük"),new Sozcuk("yangın"),new Sozcuk("göçmen"),new Sozcuk("silik"),
            new Sozcuk("çarpık"),new Sozcuk("küllük"),new Sozcuk("sözcük"),new Sozcuk("baskın"),new Sozcuk("tavukçu"),new Sozcuk("kanamak"),new Sozcuk("çizelge"),new Sozcuk("bulaşık"),new Sozcuk("bilmece"),new Sozcuk("boğulma"),new Sozcuk("simitçi"),
            new Sozcuk("görüntü"),new Sozcuk("gelenek"),new Sozcuk("gülücük"),new Sozcuk("basamak"),new Sozcuk("iyimser"),new Sozcuk("çocuksu"),new Sozcuk("kulaklık"),new Sozcuk("kitaplık"),new Sozcuk("taşlamak"),new Sozcuk("boğulmak"),new Sozcuk("bulaşıcı"),
            new Sozcuk("doyurmak"),new Sozcuk("bildirge"),new Sozcuk("çarpışma"),new Sozcuk("iyileşme"),new Sozcuk("gözlükçü"),new Sozcuk("güneşlik")
        };
        Sozcuk[] zor =
        {
            new Sozcuk("başrol"),new Sozcuk("sütlaç"),new Sozcuk("çekyat"),new Sozcuk("kapkaç"),new Sozcuk("rumeli"),new Sozcuk("kaynana"),new Sozcuk("gözaltı"),new Sozcuk("suçüstü"),new Sozcuk("ateşkes"),new Sozcuk("akciğer"),new Sozcuk("hastane"),new Sozcuk("akdeniz"),new Sozcuk("anadolu"),
            new Sozcuk("kaskatı"),new Sozcuk("kartopu"),new Sozcuk("kaynata"),new Sozcuk("ATATÜRK"),new Sozcuk("canciğer"),new Sozcuk("emretmek"),new Sozcuk("affetmek"),new Sozcuk("demirbaş"),new Sozcuk("boşboğaz"),new Sozcuk("kuşburnu"),new Sozcuk("başbakan"),new Sozcuk("dershane"),
            new Sozcuk("külbastı"),new Sozcuk("taşköprü"),new Sozcuk("masaüstü"),new Sozcuk("köşebaşı"),new Sozcuk("aslanağzı"),new Sozcuk("hasıraltı"),new Sozcuk("köprüaltı"),new Sozcuk("koçbaşı"),new Sozcuk("uyurgezer"),new Sozcuk("hissetmek"),new Sozcuk("yurtsever"),new Sozcuk("beyanname"),
            new Sozcuk("hapsetmek"),new Sozcuk("gecekondu"),new Sozcuk("sivrisinek"),new Sozcuk("yapıvermek"),new Sozcuk("gidedurmak"),new Sozcuk("düşeyazmak"),new Sozcuk("bilgisayar"),new Sozcuk("hacıyatmaz"),new Sozcuk("biçerdöver"),new Sozcuk("sivrisinek"),new Sozcuk("kültablası"),new Sozcuk("yastıkaltı"),
            new Sozcuk("çakmaktaşı")
        };


    }
}
