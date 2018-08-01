using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Houthandel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variabelen
        DateTime dteLeverDatum;
        const double cdblSchaafLoon = 0.6, cdblKlasse1Prijs = 300, cdblKlasse2Prijs = 500,
                     cdblKlasse3Prijs = 450, cdbl14Tot21Korting = 1, cdbl21tot28Korting = 2,
                     cdbl28Korting = 2.5, cdblTotaleHoutkostenKorting = 200;
        double dblAantalM3Klasse1, dblAantalM3Klasse2, dblAantalM3Klasse3, dblPrijs,
               dblLeverTijdKorting, dblAantalM2Schaven;
        int intAantalDagen;

        private void btnPrijs_Click(object sender, EventArgs e)
        {
            dteLeverDatum = Convert.ToDateTime(tbLeverDatum.Text);
            intAantalDagen = dteLeverDatum.DayOfYear - DateTime.Now.DayOfYear;

            dblAantalM3Klasse1 = Convert.ToDouble(tbAantalM3Klasse1.Text);
            dblAantalM3Klasse2 = Convert.ToDouble(tbAantalM3Klasse2.Text);
            dblAantalM3Klasse3 = Convert.ToDouble(tbAantalM3Klasse3.Text);

            dblAantalM2Schaven = Convert.ToDouble(tbAantalM2Schaven.Text);

            //Levertijd korting bepalen

            if(14 <= intAantalDagen && intAantalDagen < 21)
            {
                dblLeverTijdKorting = cdbl14Tot21Korting;
            }

            else if(21 <= intAantalDagen && intAantalDagen < 28)
            {
                dblLeverTijdKorting = cdbl21tot28Korting;
            }

            else if(28 <= intAantalDagen)
            {
                dblLeverTijdKorting = cdbl28Korting;
            }

            //Bepalen of er schaafkosten betaald moeten worden

            if(dblAantalM3Klasse1 * cdblKlasse1Prijs +
               dblAantalM3Klasse2 * cdblKlasse2Prijs +
               dblAantalM3Klasse3 * cdblKlasse3Prijs < 200)
            {
                dblPrijs = dblAantalM3Klasse1 * cdblKlasse1Prijs +
                           dblAantalM3Klasse2 * cdblKlasse2Prijs +
                           dblAantalM3Klasse3 * cdblKlasse3Prijs +
                           dblAantalM2Schaven * cdblSchaafLoon -
                           (dblAantalM3Klasse1 * cdblKlasse1Prijs +
                           dblAantalM3Klasse2 * cdblKlasse2Prijs +
                           dblAantalM3Klasse3 * cdblKlasse3Prijs +
                           dblAantalM2Schaven * cdblSchaafLoon) * dblLeverTijdKorting / 100;


            }

            else
            {
                dblPrijs = dblAantalM3Klasse1 * cdblKlasse1Prijs +
                           dblAantalM3Klasse2 * cdblKlasse2Prijs +
                           dblAantalM3Klasse3 * cdblKlasse3Prijs -
                           (dblAantalM3Klasse1 * cdblKlasse1Prijs +
                            dblAantalM3Klasse2 * cdblKlasse2Prijs +
                            dblAantalM3Klasse3 * cdblKlasse3Prijs) * dblLeverTijdKorting / 100;

            }

            tbPrijs.Text = Convert.ToString(dblPrijs);
        }
    }
}
