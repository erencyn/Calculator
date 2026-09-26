using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        int sayi1;
        int sayi2;
        char islem;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text+ "1";    
        }

        private void iki_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text + "2";
        }

        private void uc_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text + "3";
        }

        private void dort_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text + "4";
        }

        private void bes_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text + "5";
        }

        private void alti_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text + "6";
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text + "7";
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text + "8";
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text + "9";
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text + "0";
        }

        private void Topla_Click(object sender, EventArgs e)
        {
            sayi1= Convert.ToInt32(comboBox1.Text);
            comboBox1.Text = "";
            islem = '+'; 
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(comboBox1.Text);
            comboBox1.Text = "";
            islem = '-';
        }

        private void bol_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(comboBox1.Text); ;
            comboBox1.Text = "";
            islem = '/';
        }

        private void carp_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(comboBox1.Text); ;
            comboBox1.Text = "";
            islem = '*';
        }

        private void sonuc_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToInt32(comboBox1.Text);
            if (islem == '+')
            {
                int sonuc= sayi1 + sayi2;
                comboBox1.Text = sonuc.ToString();
            }
            if (islem == '-')
            {
                int sonuc = sayi1 - sayi2;
                comboBox1.Text = sonuc.ToString();
            }
            if (islem == '/')
            {
                int sonuc = sayi1 / sayi2;
                comboBox1.Text = sonuc.ToString();
            }
            if (islem == '*')
            {
                int sonuc = sayi1 * sayi2;
                comboBox1.Text = sonuc.ToString();
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            sayi1 = 0;
            sayi2 = 0;
            comboBox1.Text = "";
        }
    }
}
