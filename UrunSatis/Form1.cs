using System.Drawing.Text;

namespace UrunSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string kullanici = "";

        //FÝYATLAR//
        private double pizzaf = 150;
        private double hamburgerf = 150;
        private double donerf = 120;
        private double pidef = 110;
        private double lahmacunf = 120;
        private double lattef = 40;
        private double espressof = 40;
        private double cayf = 20;
        private double sutlacf = 60;
        private double tulumbaf = 50;


        public double toplamfiyat = 0;
        public double indirimlitoplamfiyat = 0;

        private string nakitkartkontrol = "";

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = kullanici;
        }

        private void ýconButton1_Click(object sender, EventArgs e)
        {
            label1.Text = kullanici;

            if (kullanici == "240011001")
            {
                label4.Text = "Erdem Karataþ";

            }
            else if (kullanici == "240011002")
            {
                label4.Text = "Songül Karataþ";

            }
            else if (kullanici == "240011003")
            {
                label4.Text = "Kenan Karataþ";

            }
            else
            {
                label4.Text = "Bilinmeyen Personel";
            }
        }

        private void pizza_CheckedChanged(object sender, EventArgs e)
        {
            if (pizza.Checked == true)
            {
                toplamfiyat += pizzaf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }

            if (pizza.Checked == false)
            {
                toplamfiyat -= pizzaf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (hamburger.Checked == true)
            {
                toplamfiyat += hamburgerf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }

            if (hamburger.Checked == false)
            {
                toplamfiyat -= hamburgerf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void doner_CheckedChanged(object sender, EventArgs e)
        {
            if (doner.Checked == true)
            {
                toplamfiyat += donerf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }

            if (doner.Checked == false)
            {
                toplamfiyat -= donerf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void pide_CheckedChanged(object sender, EventArgs e)
        {
            if (pide.Checked == true)
            {
                toplamfiyat += pidef;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }

            if (pide.Checked == false)
            {
                toplamfiyat -= pidef;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void lahmacun_CheckedChanged(object sender, EventArgs e)
        {
            if (lahmacun.Checked == true)
            {
                toplamfiyat += lahmacunf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }

            if (lahmacun.Checked == false)
            {
                toplamfiyat -= lahmacunf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void latte_CheckedChanged(object sender, EventArgs e)
        {
            if (latte.Checked == true)
            {
                toplamfiyat += lattef;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }

            if (latte.Checked == false)
            {
                toplamfiyat -= lattef;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void espresso_CheckedChanged(object sender, EventArgs e)
        {
            if (espresso.Checked == true)
            {
                toplamfiyat += espressof;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }

            if (espresso.Checked == false)
            {
                toplamfiyat -= espressof;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cay.Checked == true)
            {
                toplamfiyat += cayf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }

            if (cay.Checked == false)
            {
                toplamfiyat -= cayf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void sutlac_CheckedChanged(object sender, EventArgs e)
        {
            if (sutlac.Checked == true)
            {
                toplamfiyat += sutlacf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }

            if (sutlac.Checked == false)
            {
                toplamfiyat -= sutlacf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void tulumba_CheckedChanged(object sender, EventArgs e)
        {
            if (tulumba.Checked == true)
            {
                toplamfiyat += tulumbaf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }

            if (tulumba.Checked == false)
            {
                toplamfiyat -= tulumbaf;
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                indirimlitoplamfiyat = toplamfiyat;
                indirimlitoplamfiyat -= toplamfiyat / 10;
                fiyattoplam.Text = (indirimlitoplamfiyat.ToString() + " TL");
            }

            if (radioButton1.Checked == false)
            {
                fiyattoplam.Text = (toplamfiyat.ToString() + " TL");
            }
        }

        private void ýconButton3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            pizza.Checked = false;
            hamburger.Checked = false;
            doner.Checked = false;
            pide.Checked = false;
            lahmacun.Checked = false;
            latte.Checked = false;
            espresso.Checked = false;
            cay.Checked = false;
            sutlac.Checked = false;
            tulumba.Checked = false;

            nakitkartkontrol = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                nakitkartkontrol = "nakit";
            } 
        }

        private void ýconButton2_Click(object sender, EventArgs e)
        {
            if (nakitkartkontrol == "nakit")
            {
                if (radioButton1.Checked == true)
                {
                    Form2 form2sec = new Form2();
                    form2sec.Show();
                    form2sec.toplamfiyat = indirimlitoplamfiyat;
                }
                else if (radioButton2.Checked == true)
                {
                    Form2 form2sec = new Form2();
                    form2sec.Show();
                    form2sec.toplamfiyat = toplamfiyat;
                }
                else
                {
                    MessageBox.Show("Lütfen Personel veya Müþteri bilgisini seçiniz.", "Uyarý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (nakitkartkontrol == "kart")
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Kart ile ödeme seçildi, ödeme iþlemini Pos Cihazý üzerinden yapabilirsiniz.", "Kart Ýle Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Kart ile ödeme seçildi, ödeme iþlemini Pos Cihazý üzerinden yapabilirsiniz.", "Kart Ýle Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Personel veya Müþteri bilgisini seçiniz.", "Uyarý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödeme yöntemini seçiniz.", "Uyarý!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = kullanici;

            if (kullanici == "240011001")
            {
                label4.Text = "Erdem Karataþ";

            }
            else if (kullanici == "240011002")
            {
                label4.Text = "2. Personel";

            }
            else if (kullanici == "240011003")
            {
                label4.Text = "3. Personel";

            }
            else
            {
                label4.Text = "Bilinmeyen Personel";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                nakitkartkontrol = "kart";
            }
        }
    }
}
