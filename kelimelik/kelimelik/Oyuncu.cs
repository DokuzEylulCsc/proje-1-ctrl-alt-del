using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelimelik
{
    class Oyuncu
    {
        private String isim;
        private String girilen;
        private String zorluk;
        private Form2 f2;
        private int KacinciKelime=-1;
        private string mevcutKelime;
        public string Isim { get => isim; set => isim = value; }
        public string Girilen { get => girilen; set => girilen = value; }
        public string Zorluk { get => zorluk; set => zorluk = value; }
        public string MevcutKelime { get => mevcutKelime; set => mevcutKelime = value; }

        private  int ToplamTahminSayisi = 0;
        private  int KelimelikTahminSayisi = 0;
        public Oyuncu(string Isim,Form2 f2)
        {
            this.isim = Isim;
            this.f2 = f2;
            Kaydedici.N = Isim;
            Kaydedici.LogYaz();

        }
        public void KelimeUygunluk(string GirilenKelime )
        {
            mevcutKelime = AI.Kelimeler[KacinciKelime].Kelime;
            try
            {
                if(GirilenKelime.Length != mevcutKelime.Length)
                {
                    throw new Exception("Kelime sayisi az");
                }
                else
                {
                    GirilenKelime=GirilenKelime.ToLower();
                    for(int i = 0; i < GirilenKelime.Length; i++)
                    {
                        if(!((GirilenKelime[i]<=122 && GirilenKelime[i]>=97 && GirilenKelime[i] != 'q' && GirilenKelime[i] != 'w' && GirilenKelime[i] != 'x')||GirilenKelime[i]== 'ğ'||GirilenKelime[i]== 'ı'||GirilenKelime[i]== 'ş'||GirilenKelime[i]== 'ü'||GirilenKelime[i]== 'ç'||GirilenKelime[i]== 'ö'))
                        {
                            throw new Exception("Hatali Karakter Girildi");
                        }
                    }
                }
                if (AI.DogruKelimeKarsilastir(GirilenKelime,KacinciKelime))// AI ya gonderilen kelime Mevcut kelime ile uyusuyorsa
                {
                    KelimelikTahminSayisi++;
                    ToplamTahminSayisi++;
                    Kaydedici.LogYaz(KacinciKelime, KelimelikTahminSayisi, mevcutKelime.Length, zorluk);
                    KelimelikTahminSayisi = 0;
                    MessageBox.Show("Harika , Dogru Bildin !");
                    f2.Controls["Txt_Tahmin"].Text = "";
                    ((ListBox)f2.Controls["listBox12"]).Items.Clear();
                    YeniKelimeGetir();

                }
                else// uyusmuyorsa
                {
                    int can = Convert.ToInt32(f2.Controls["can"].Text);
                    can--;
                    f2.Controls["can"].Text = can.ToString();
                    List<List<string>> harfler = AI.HarfKarsilastir(GirilenKelime, KacinciKelime); // AI yanlis dogru ve dopdogru olanlari sirasi ile dondurucek methoda sahip olucak
                                                                                                   // 0. indis yanlislar 1.indis dogrular 2.indis dopdogrular
                    ToplamTahminSayisi++;
                    KelimelikTahminSayisi++;
                    for (int i = 0; i < harfler[0].Count; i++)
                    {
                        if (harfler[0][i] == "ç")
                        {
                            harfler[0][i] = "c1";
                        }
                        else if (harfler[0][i] == "ğ")
                        {
                            harfler[0][i] = "g1";
                        }
                        else if (harfler[0][i] == "ı")
                        {
                            harfler[0][i] = "i1";
                        }
                        else if (harfler[0][i] == "ö")
                        {
                            harfler[0][i] = "o1";
                        }
                        else if (harfler[0][i] == "ş")
                        {
                            harfler[0][i] = "s1";
                        }
                        else if (harfler[0][i] == "ü")
                        {
                            harfler[0][i] = "u1";
                        }
                        ((Button)(f2.Controls[harfler[0][i]])).BackColor = Color.Red;
                    }       // Yanlis kelimeler kontrolu
                    for (int i = 0; i < harfler[1].Count; i++)
                    {
                        if (harfler[1][i] == "ç")
                        {
                            harfler[1][i] = "c1";
                        }
                        else if (harfler[1][i] == "ğ")
                        {
                            harfler[1][i] = "g1";
                        }
                        else if (harfler[1][i] == "ı")
                        {
                            harfler[1][i] = "i1";
                        }
                        else if (harfler[1][i] == "ö")
                        {
                            harfler[1][i] = "o1";
                        }
                        else if (harfler[1][i] == "ş")
                        {
                            harfler[1][i] = "s1";
                        }
                        else if (harfler[1][i] == "ü")
                        {
                            harfler[1][i] = "u1";
                        }
                        ((Button)(f2.Controls[harfler[1][i]])).BackColor = Color.Yellow;
                    }   // Dogru kelimeler kontrolu
                    for (int i = 0; i < harfler[2].Count; i++)
                    {
                        if (harfler[2][i] == "ç")
                        {
                            harfler[2][i] = "c1";
                        }
                        else if (harfler[2][i] == "ğ")
                        {
                            harfler[2][i] = "g1";
                        }
                        else if (harfler[2][i] == "ı")
                        {
                            harfler[2][i] = "i1";
                        }
                        else if (harfler[2][i] == "ö")
                        {
                            harfler[2][i] = "o1";
                        }
                        else if (harfler[2][i] == "ş")
                        {
                            harfler[2][i] = "s1";
                        }
                        else if (harfler[2][i] == "ü")
                        {
                            harfler[2][i] = "u1";
                        }
                        ((Button)(f2.Controls[harfler[2][i]])).BackColor = Color.Green;
                    }   // Dogru yer dogru kelimeler kontrolu
                    ((ListBox)f2.Controls["listBox12"]).Items.Add(GirilenKelime);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            finally
            {
                f2.Controls["Txt_Tahmin"].Text = "";
                f2.Controls["Txt_Tahmin"].Focus();
            }
        }
        public void PasGec()
        {
            int a = Convert.ToInt32(f2.Controls["pas"].Text);
            if ( a > 0)
            {
                f2.Controls["Txt_Tahmin"].Text = "";
                a--;
                f2.Controls["pas"].Text = a.ToString();
                YeniKelimeGetir();
                Kaydedici.LogYaz("Pas Gecildi");
            }
            else
            {
                MessageBox.Show("Pas Hakkin Yok");
            }
            
        }
        public void YeniKelimeGetir()
        {

            KacinciKelime++;
            mevcutKelime = AI.Kelimeler[KacinciKelime].Kelime;
            f2.Controls["Txt_Kelime"].Text = "";
            f2.Controls["Txt_Kelime"].Text = mevcutKelime;
            foreach(Control c in (f2.Controls).OfType<Button>())
            {
                c.BackColor = Color.LightGray;
            }
        }

    }
}
