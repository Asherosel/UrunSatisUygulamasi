using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace UrunSatis
{
    public partial class Form2 : Form
    {

        public double toplamfiyat = 0;
        public Form2()
        {
            InitializeComponent();
            label2.Text = toplamfiyat.ToString();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = toplamfiyat.ToString();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                label2.Text = toplamfiyat.ToString();
                double paraustu = Double.Parse(textBox1.Text) - toplamfiyat;
                label5.Text = paraustu.ToString();
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            label2.Text = toplamfiyat.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form2_Enter(object sender, EventArgs e)
        {
            label2.Text = toplamfiyat.ToString();
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            label2.Text = toplamfiyat.ToString();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
