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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Btn_TekrarOyna_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Oyun o = new Oyun(f2,Kaydedici.N);
            o.OyunBaslat();
            this.Close();
        }

        private void Btn_Bitir_Click(object sender, EventArgs e)
        {
            
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
