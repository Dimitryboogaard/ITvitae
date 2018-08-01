using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containerverhuur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variabelen
        DateTime dteStartDatum, dteEindDatum;
        int intTeller, intAantalDagen;
        double dblAantalM3, dblTotaalPrijs;
        const double cdblVasteKlantenKorting = 15;

        private void btnPrijs_Click(object sender, EventArgs e)
        {
            intAantalDagen = dteEindDatum.DayOfYear - dteStartDatum.DayOfYear;

            dblAantalM3 = Convert.ToDouble(tbAantalM3.Text);

            if(dblAantalM3 <= 2)
            {
                dblTotaalPrijs = intAantalDagen * 40 + 60;
            }

            else
            {
                dblTotaalPrijs = intAantalDagen * 40 + 125;
            }

            if(cbVasteKlant.Checked)
            {
                dblTotaalPrijs -= dblTotaalPrijs * cdblVasteKlantenKorting / 100;
            }

            tbPrijs.Text = Convert.ToString(dblTotaalPrijs);
        }
    }
}
