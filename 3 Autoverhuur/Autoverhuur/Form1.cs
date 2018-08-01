using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoverhuur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variabelen
        DateTime dteStartDatum, dteEindDatum;
        int intAantalKm, intAantalDagen;
        const double cdbKmPrijsPersonenAuto = 0.20, cdbKmPrijsPersonenBusje = 0.30,
                     cdbPrijsPerDagPersonenAuto = 50, cdbPrijsPerDagPersonenBusje = 95,
                     cdbBenzinePrijs = 1.754, cdbDieselPrijs = 1.439, cdbVerbruikPersonenAuto = 16,
                     cdbVerbruikPersonenBusje = 11;
        bool booPersonenBusje;
        double dblTotaalPrijs, dblSubTotaalBrandstofPrijs, dblSubtotaalKmPrijs,
               dblSubTotaalDagPrijs;

        private void btnBerekenPrijs_Click(object sender, EventArgs e)
        {
            dteStartDatum = Convert.ToDateTime(tbStartDatum.Text);
            dteEindDatum = Convert.ToDateTime(tbEindDatum.Text);
            intAantalKm = Convert.ToInt16(tbAantalKm.Text);
            booPersonenBusje = cbPersonenBusje.Checked;
            intAantalDagen = dteEindDatum.DayOfYear - dteStartDatum.DayOfYear + 1;
            

            if(booPersonenBusje == false)
            {
                if (intAantalKm <= 100)
                {
                    dblSubTotaalBrandstofPrijs = intAantalKm / cdbVerbruikPersonenAuto * cdbBenzinePrijs;
                    dblSubTotaalDagPrijs = intAantalDagen * cdbPrijsPerDagPersonenAuto;
                    dblTotaalPrijs = dblSubTotaalBrandstofPrijs + dblSubTotaalDagPrijs;
                                 
                    tbPrijs.Text = Convert.ToString(Math.Round(dblTotaalPrijs, 2));
                }

                else
                {
                    dblSubTotaalBrandstofPrijs = intAantalKm / cdbVerbruikPersonenAuto * cdbBenzinePrijs;
                    dblSubtotaalKmPrijs = intAantalKm * cdbKmPrijsPersonenAuto;
                    dblSubTotaalDagPrijs = intAantalDagen * cdbPrijsPerDagPersonenAuto;
                    dblTotaalPrijs = dblSubTotaalBrandstofPrijs + dblSubtotaalKmPrijs + dblSubTotaalDagPrijs
                                     - intAantalDagen * cdbKmPrijsPersonenAuto * 100;
                    tbPrijs.Text = Convert.ToString(Math.Round(dblTotaalPrijs, 2));

                }
            }

            else if(booPersonenBusje == true)
            {
                if (intAantalKm <= 100)
                {
                    dblSubTotaalBrandstofPrijs = intAantalKm / cdbVerbruikPersonenBusje * cdbDieselPrijs;
                    dblSubTotaalDagPrijs = intAantalDagen * cdbPrijsPerDagPersonenBusje;
                    dblTotaalPrijs = dblSubTotaalBrandstofPrijs + dblSubTotaalDagPrijs;
                                  
                    tbPrijs.Text = Convert.ToString(Math.Round(dblTotaalPrijs, 2));
                }

                else
                {
                    dblSubTotaalBrandstofPrijs = intAantalKm / cdbVerbruikPersonenBusje * cdbDieselPrijs;
                    dblSubtotaalKmPrijs = intAantalKm * cdbKmPrijsPersonenBusje;
                    dblSubTotaalDagPrijs = intAantalDagen * cdbPrijsPerDagPersonenBusje;
                    dblTotaalPrijs = dblSubTotaalBrandstofPrijs + dblSubtotaalKmPrijs + dblSubTotaalDagPrijs
                                     - intAantalDagen * cdbPrijsPerDagPersonenBusje * 100;
                    tbPrijs.Text = Convert.ToString(Math.Round(dblTotaalPrijs, 2));

                }
            }
        }
    }
}
