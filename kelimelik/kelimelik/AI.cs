using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelimelik
{
    static class AI
    {
        static Sozcuk[] kelimeler=new Sozcuk[10];

        internal static Sozcuk[] Kelimeler { get => kelimeler; set => kelimeler = value; }

        public static bool DogruKelimeKarsilastir(string girilenKelime, int kacinciKelime)
        {
            string mevcutKelime = Kelimeler[kacinciKelime].Kelime;
            for (int i = 0; i < girilenKelime.Length; i++)
            {
                if (girilenKelime[i] != mevcutKelime[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static List<List<string>> HarfKarsilastir(string girilenKelime,int kacinciKelime)
        {
            List<List<string>> harfler = new List<List<string>>();
            List<string> dd = new List<string>();
            List<string> d = new List<string>();
            List<string> y = new List<string>();
            string mevcutKelime = kelimeler[kacinciKelime].Kelime;
            for (int j = 0; j < girilenKelime.Length; j++)
            {
                for (int i = 0; i < girilenKelime.Length; i++)
                {
                    if (girilenKelime[i] == mevcutKelime[j])
                    {
                        if (i==j)
                        {
                            dd.Add(girilenKelime[i].ToString());
                        }
                        else
                        {
                            d.Add(girilenKelime[i].ToString());
                        }
                       
                    }
                    else
                    {
                        y.Add(girilenKelime[i].ToString());
                    }
                }
            }
            harfler.Add(y);
            harfler.Add(d);
            harfler.Add(dd);
            return harfler;

        }
    }
}
