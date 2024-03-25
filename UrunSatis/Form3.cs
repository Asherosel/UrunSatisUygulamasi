using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunSatis
{
    public partial class Form3 : Form
    {

        public string kullanici1 = "240011001";
        public string kullanici2 = "240011002";
        public string kullanici3 = "240011003";
        public string kullanici1parola = "Şifre1";
        public string kullanici2parola = "Şifre2";
        public string kullanici3parola = "Şifre3";



        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == (kullanici1).ToString())
            {
                if (textBox2.Text == (kullanici1parola))
                {
                    Form1 form1sec = new Form1();
                    form1sec.Show();
                    this.Hide();
                    form1sec.kullanici = kullanici1;
                }
                else
                {
                    textLabel.Text = "Parolanız Yanlış!";
                }
            }
            else if (textBox1.Text == (kullanici2).ToString())
            {
                if (textBox2.Text == (kullanici2parola))
                {
                    Form1 form1sec = new Form1();
                    form1sec.Show();
                    this.Hide();
                    form1sec.kullanici = kullanici2;
                }
                else
                {
                    textLabel.Text = "Parolanız Yanlış!";
                }
            }
            else if (textBox1.Text == (kullanici3).ToString())
            {
                if (textBox2.Text == (kullanici3parola))
                {
                    Form1 form1sec = new Form1();
                    form1sec.Show();
                    this.Hide();
                    form1sec.kullanici = kullanici3;
                }
                else
                {
                    textLabel.Text = "Parolanız Yanlış!";
                }
            }
            else
            {
                textLabel.Text = "Kullanıcı Bulunamadı!";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
