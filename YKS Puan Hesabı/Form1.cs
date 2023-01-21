using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YKS_Puan_Hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int matd, maty;
            int türky, türkd;
            int sosd, sosy;
            int fend, feny;
            double matinet, türknet, sosnet, fennet;
            double net;
            double puan, obp;

            obp = Convert.ToDouble(textBox11.Text);
            türkd = Convert.ToInt32(textBox3.Text);
            türky = Convert.ToInt32(textBox4.Text);
            türknet = türkd - türky / 4;
            label14.Text = türknet.ToString();
            matd = Convert.ToInt32(textBox7.Text);
            maty = Convert.ToInt32(textBox10.Text);
            matinet = matd - maty / 4;
            label13.Text = matinet.ToString();
            sosd = Convert.ToInt32(textBox6.Text);
            sosy = Convert.ToInt32(textBox9.Text);
            sosnet = sosd - sosy / 4;
            label7.Text = sosnet.ToString();
            fend = Convert.ToInt32(textBox5.Text);
            feny = Convert.ToInt32(textBox8.Text);
            fennet = fend - feny / 4;
            label15.Text = fennet.ToString();




            net = fennet + matinet + türknet + sosnet;
            label17.Text = net.ToString();
            puan = ((türkd - (türky / 4)) * 3.2) + ((sosd - (sosy / 4)) * 3) + ((matd - (maty / 4)) * 3.72) + ((fend - (feny / 4)) * 3.5) + (obp * 0.12);
            label16.Text = puan.ToString(); 
        }
    }
}
