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
    public partial class Form2 : Form
    {
           
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int sure_dakika = Convert.ToInt16(label4.Text);
            int sure_saniye = Convert.ToInt16(label2.Text);
            Oyun.OyunKontrol(sure_dakika,sure_saniye);
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void a_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += a.Text;
        }
        private void b_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += b.Text;
        }
        private void c_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += c.Text;
        }
        private void c1_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += c1.Text;
        }
        private void d_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += d.Text;
        }
        private void e_Click(object sender, EventArgs s)
        {
            Txt_Tahmin.Text += e.Text;
        }
        private void f_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += f.Text;
        }
        private void g_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += g.Text;
        }
        private void g1_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += g1.Text;
        }
        private void h_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += h.Text;
        }
        private void i1_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += i1.Text;
        }
        private void i_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += i.Text;
        }
        private void j_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += j.Text;
        }
        private void k_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += k.Text;
        }
        private void l_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += l.Text;
        }
        private void m_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += m.Text;
        }
        private void n_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += n.Text;
        }
        private void o_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += o.Text;
        }
        private void o1_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += o1.Text;
        }
        private void p_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += p.Text;
        }
        private void r_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += r.Text;
        }
        private void s_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += s.Text;
        }
        private void s1_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text +=s1.Text;
        }
        private void t_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += t.Text;
        }
        private void u_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += u.Text;
        }
        private void u1_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += u1.Text;
        }
        private void v_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += v.Text;
        }
        private void y_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text += y.Text;
        }
        private void z_Click(object sender, EventArgs e)
        {
            Txt_Tahmin.Text +=z.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.oyuncu.PasGec();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if(Txt_Tahmin.Text!="")
            Form1.oyuncu.KelimeUygunluk(Txt_Tahmin.Text);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
