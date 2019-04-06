using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelimelik
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public static int hangi_buton=1;
        internal static Oyuncu oyuncu;
        private void Btn_YeniOyun_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            oyuncu = new Oyuncu(textBox1.Text, f2);
            Oyun o2 = new Oyun(f2);
            o2.OyunBaslat();
            
            this.Hide();   
        }

        private void Btn_Kolay_Click(object sender, EventArgs e)
        {
            hangi_buton = 1;
            Btn_Kolay.BackColor = Color.LightGreen;
            Btn_Orta.BackColor = Color.LightGray;
            Btn_Zor.BackColor = Color.LightGray;
        }

        private void Btn_Orta_Click(object sender, EventArgs e)
        {
            hangi_buton = 2;
            Btn_Kolay.BackColor = Color.LightGray;
            Btn_Orta.BackColor = Color.LightGreen;
            Btn_Zor.BackColor = Color.LightGray;
        }

        private void Btn_Zor_Click(object sender, EventArgs e)
        {
            hangi_buton = 3;
            Btn_Kolay.BackColor = Color.LightGray;
            Btn_Orta.BackColor = Color.LightGray;
            Btn_Zor.BackColor = Color.LightGreen;
        }
    }
}
