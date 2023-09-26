using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdörtgen_alan_çevre_hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float kisakenar, Uzunkenar, alan, cevre;
            kisakenar=Convert.ToSingle(txtKısa.Text);
            Uzunkenar=Convert.ToSingle(txtUzun.Text);
            alan = kisakenar * Uzunkenar;
            cevre = (kisakenar + Uzunkenar) * 2;

            lblAlan.Text= "Alan: "+alan.ToString();
            lblÇevre.Text = "Çevre: "+cevre.ToString();

        }
    }
}
