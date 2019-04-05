using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kelimelik
{
    class Oyun
    {
        int i;
        Form2 f2 = new Form2();
        public Oyun(Form2 f2)
        {
            this.f2 = f2;
        }
        private Sozcuk[] secilen_seviye;
        public Sozcuk[] Secilen_seviye { get => secilen_seviye; set => secilen_seviye= value; }
        private Sozcuk[] secilen_kelimeler;
        public Sozcuk[] Secilen_kelimeler1 { get => secilen_kelimeler; set => secilen_kelimeler = value; }

        Tur t = new Tur();
        public void OyunBaslat() // Hangi seviye secilirse o diziden eleman turetebılir hale getiren ve oyunu baslatan metot.
        {
            if (Form1.hangi_buton == 1)
            {
                for (int i = 0; i < 50; i++)
                {
                    secilen_seviye[i] = t.Kolay[i];
                }
            }
            else if (Form1.hangi_buton == 2)
            {
                for (int i = 0; i < 50; i++)
                {
                    secilen_seviye[i] = t.Orta[i];
                }
            }
            else if (Form1.hangi_buton == 3)
            {
                for (int i = 0; i < 50; i++)
                {
                    secilen_seviye[i] = t.Zor[i];
                }
            }
            Random rastgele = new Random();
            int sayi = 0; 
            sayi= rastgele.Next(0, 5) + sayi;
            for (int i = 0; i < 10; i++)
            {
                secilen_kelimeler[i] = secilen_seviye[sayi];
            }
        }
        public void OyunKontrol()
        {

        }

        public void OyunBitir()
        {
            Form3 f3 = new Form3();
            f3.Show();
            f2.Close();
        }





        // AI da ki metodu burada cagırıp f2 gonderıcez metoda.

    }
}
