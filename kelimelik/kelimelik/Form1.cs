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

        private void Btn_YeniOyun_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Oyuncu o = new Oyuncu(textBox1.Text, f2);
            f2.Show();
            
        }
    }
}
