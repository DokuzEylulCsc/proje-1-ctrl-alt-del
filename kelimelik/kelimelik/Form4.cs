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
            label12.Text = Kaydedici.ToplamOyunSayisi().ToString();
            label13.Text =
            label14.Text = Kaydedici.ToplamBilinenKelime().ToString();
        }
    }
}
