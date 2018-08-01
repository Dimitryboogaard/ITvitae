using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAuto_Click(object sender, EventArgs e)
        {

        }

        DateTime dteStartDatum, dteEindDatum, dteReisInDagen,
                 dteHoogSeizoenStart, dteHoogSeizoenEind;
        int intTeller = 0, intAantalDagen;
        double dblTotaalPrijs = 0, dblMeerOfMinder, dblHond = 0, dblAuto=0;

        private void btnPrijs_Click(object sender, EventArgs e)
        {
            dteStartDatum = Convert.ToDateTime(tbStartDatum.Text);
            dteEindDatum = Convert.ToDateTime(tbEindDatum.Text);

            if(rbMeterMeer.Checked)
            {
                dblMeerOfMinder = 3;
            }

            else if(rbMeterMinder.Checked)
            {
                dblMeerOfMinder = -2;
            }

            if(cbHond.Checked)
            {
                dblHond = 4;
            }

            if(cbAuto.Checked)
            {
                dblAuto = 6;
            }
            
            dteHoogSeizoenStart = new DateTime(dteStartDatum.Year, 06, 11, 12, 00 , 00);
            dteHoogSeizoenEind = new DateTime(dteEindDatum.Year, 08, 15, 12, 00, 00);

            dteReisInDagen = new DateTime(dteStartDatum.Year, dteStartDatum.Month, dteStartDatum.Day);

            intAantalDagen = dteEindDatum.DayOfYear - dteStartDatum.DayOfYear;

            while(intTeller < intAantalDagen)
            {
                //Buiten het hoogseizoen
                if (dteReisInDagen.Month < dteHoogSeizoenStart.Month ||
                   dteReisInDagen.Month == dteHoogSeizoenStart.Month &&
                   dteReisInDagen.Day < dteHoogSeizoenStart.Day ||
                   dteReisInDagen.Month > dteHoogSeizoenEind.Month ||
                   dteReisInDagen.Month == dteHoogSeizoenEind.Month &&
                   dteReisInDagen.Day > dteHoogSeizoenEind.Day)
                {
                    dblTotaalPrijs += 25 + Convert.ToDouble(tbAantalPersonen.Text) * 5 + dblHond +
                                      Convert.ToDouble(tbAantalMeter.Text) * dblMeerOfMinder +
                                      dblAuto;
                }

                else
                {
                    dblTotaalPrijs += 30 + Convert.ToDouble(tbAantalPersonen.Text) * 5 + dblHond +
                  Convert.ToDouble(tbAantalMeter.Text) * dblMeerOfMinder +
                  dblAuto;

                }

                dteReisInDagen = dteReisInDagen.AddDays(1);
                intTeller++;
            }

            tbPrijs.Text = Convert.ToString(dblTotaalPrijs);
        }
    }
}
