using System;
using System.Collections.Generic;
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
        private int KacinciKelime=0;
        public string Isim { get => isim; set => isim = value; }
        public string Girilen { get => girilen; set => girilen = value; }
        public string Zorluk { get => zorluk; set => zorluk = value; }

        private  int ToplamTahminSayisi = 0;
        private  int KelimelikTahminSayisi = 0;
        public Oyuncu(string Isim,Form2 f2)
        {
            this.isim = Isim;
            this.f2 = f2;
            Kaydedici.N = Isim;
            Kaydedici.LogYaz();

        }
        public void KelimeUygunluk(string GirilenKelime , string MevcutKelime)
        {
            try
            {
                if(GirilenKelime.Length != MevcutKelime.Length)
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
            }
            catch (Exception)
            {
                MessageBox.Show("Hatali Giris Yapildi");
            }
            KelimelikTahminSayisi++;
            ToplamTahminSayisi++;
            if(true)// AI ya gonderilen kelime Mevcut kelime ile uyusuyorsa
            {
                Kaydedici.LogYaz(KacinciKelime, KelimelikTahminSayisi, MevcutKelime.Length, zorluk);
                KelimelikTahminSayisi = 0;
                MessageBox.Show("Dogru");
                f2.Controls["Txt_Tahmin"].Text = "";
                
            }
            else
            {

            }
        }
       

    }
}
