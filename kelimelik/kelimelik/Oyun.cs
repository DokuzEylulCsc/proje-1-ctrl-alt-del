using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelimelik
{
    class Oyun
    {
        int i;
        static Form2 f2 = new Form2();
        public Oyun(Form2 fo2)
        {
            f2 = fo2;
        }
        private Sozcuk[] secilen_seviye = new Sozcuk[50];
        public Sozcuk[] Secilen_seviye { get => secilen_seviye; set => secilen_seviye= value; }
        private Sozcuk[] secilen_kelimeler = new Sozcuk[10];
        public Sozcuk[] Secilen_kelimeler { get => secilen_kelimeler; set => secilen_kelimeler = value; }

        Tur t = new Tur();
        public void OyunBaslat() // Hangi seviye secilirse o diziden eleman turetebılir hale getiren ve oyunu baslatan metot.
        {
            f2.Show();
            f2.timer1.Start();
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
            sayi= rastgele.Next(0, 6);
            for (int i = 0; i < 10; i++)
            {
                secilen_kelimeler[i] = secilen_seviye[sayi];
                sayi = rastgele.Next(0, 5) + sayi;
            }
        }
        public static void OyunKontrol(int sure_dakika,int sure_saniye)
        {
            int can_kontrol = Convert.ToInt16(f2.Controls["can"].Text);

            if (can_kontrol == 0)
            {
                f2.timer1.Stop();
                OyunBitir();
                MessageBox.Show("Canınız Kalmadı");   
            }
            if (sure_dakika + sure_saniye == 1)
            {
                f2.timer1.Stop();
                OyunBitir();
                MessageBox.Show("Sureniz Bitti");
            }
            else
            {
                sure_saniye--;
                f2.Controls["label2"].Text = sure_saniye.ToString();
                if (sure_saniye == 0)
                {
                    sure_dakika--;
                    f2.Controls["label4"].Text = sure_dakika.ToString();
                    sure_saniye = 59;
                    f2.Controls["label2"].Text = sure_saniye.ToString();
                }
            }
        }
        public static void OyunBitir()
        {
            Form3 f3 = new Form3();
            f3.Show();
            f2.Close();
        }
        // AI da ki metodu burada cagırıp f2 gonderıcez metoda.

    }
}
