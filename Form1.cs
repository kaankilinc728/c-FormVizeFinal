using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float vize;
        float final;
        float ortalama;



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            vize = float.Parse(txtvize.Text);
            final= float.Parse(txtfinal.Text);
            float vizeyuzdekirk = (vize * 40) / 100;
            float finalyuzdealtmis = (final * 60) / 100;
            ortalama = vizeyuzdekirk + finalyuzdealtmis;
            lblort.Text = ortalama.ToString();

            if (ortalama < 30) ;

            lblharf.Text = "FF";

            if (ortalama >= 30 && ortalama < 40)

                lblharf.Text = "FD";

            if (ortalama >= 40 && ortalama < 50)

                lblharf.Text = "DD";

            if (ortalama >= 50 && ortalama < 60)

                lblharf.Text = "DC";

            if (ortalama >= 60 && ortalama < 70)

                lblharf.Text = "CC";

            if (ortalama >= 70 && ortalama < 75)

                lblharf.Text = "CB";

            if (ortalama >= 75 && ortalama < 80)

                lblharf.Text = "BB";

            if (ortalama >= 80 && ortalama < 90)

                lblharf.Text = "BA";

            if (ortalama >= 90 && ortalama < 100)

                lblharf.Text = "AA";





        }
    }
}
