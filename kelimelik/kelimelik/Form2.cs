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
        private void button9_Click(object sender, EventArgs e)
        {

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
    }
}
