using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiyatorn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKarHesaplama_Click(object sender, EventArgs e)
        {
            double satisfiyati, alisfiyati, toplamkar;
            alisfiyati=Convert.ToDouble(txtAlişFiyati.Text);
            satisfiyati = Convert.ToDouble(txtSatişFiyati.Text);

            toplamkar = satisfiyati-alisfiyati;

            lblToplamKar.Text ="TOPLAM KAR: "+toplamkar.ToString();
        }
    }
}
