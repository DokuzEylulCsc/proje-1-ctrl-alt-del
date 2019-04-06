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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Kaydedici.LogYaz();
             label12.Text = Kaydedici.ToplamOyunSayisi().ToString();
             label13.Text = Kaydedici.ToplamTahminSayisi().ToString();
             label14.Text = Kaydedici.ToplamBilinenKelime().ToString();
             label15.Text = Kaydedici.ToplamPasSayisi().ToString();
             label17.Text = Kaydedici.PasSayisi.ToString();
             label18.Text = Kaydedici.TahminSayisi.ToString();
             label19.Text = Kaydedici.BilinenKelimeSayisi.ToString();
            
        }
    }
}
