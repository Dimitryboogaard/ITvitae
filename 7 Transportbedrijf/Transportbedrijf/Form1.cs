using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportbedrijf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variabelen
        double dblAantalKmInBinnenland, dblAantalKmInBuitenland, dblVolume, dblGewicht,
               dblVolumeVloeistof, dblGewichtVloeistof, dblWaardeLading, dblPrijs;
        const double cdblVolume = 0.8, cdblGewicht = 0.55, cdblVolumeVloeistof = 1.25,
                     cdblGewichtVloeistof = 0.45, cdblToeslag = 45, cdblDouane = 3.5,
                     cdblDouaneMinimum = 45;
            
        private void btnPrijs_Click(object sender, EventArgs e)
        {
            dblAantalKmInBinnenland = Convert.ToDouble(tbAantalKmInBinneland.Text);
            dblAantalKmInBuitenland = Convert.ToDouble(tbAantalKmInBuitenland.Text);
            dblVolume = Convert.ToDouble(tbVolume.Text);
            dblGewicht = Convert.ToDouble(tbGewicht.Text);
            dblVolumeVloeistof = Convert.ToDouble(tbVolumeVloeibaar.Text);
            dblGewichtVloeistof = Convert.ToDouble(tbGewichtVloeibaar.Text);
            dblWaardeLading = Convert.ToDouble(tbWaardeLading.Text);

            dblPrijs = dblAantalKmInBinnenland * (cdblVolume * dblVolume + cdblGewicht * dblGewicht) +
                       dblAantalKmInBinnenland * (cdblVolumeVloeistof * dblVolumeVloeistof + cdblGewichtVloeistof * dblGewichtVloeistof) +
                       (1 + cdblToeslag / 100) *
                       (dblAantalKmInBuitenland * (cdblVolume * dblVolume + cdblGewicht * dblGewicht) +
                       dblAantalKmInBuitenland * (cdblVolumeVloeistof * dblVolumeVloeistof + cdblGewichtVloeistof * dblGewichtVloeistof));

            if(Convert.ToDouble(tbAantalKmInBuitenland.Text) > 0)
            {
                if(cdblDouane / 100 * Convert.ToDouble(tbWaardeLading.Text) < 45)
                {
                    dblPrijs += 45;
                }

                else
                {
                    dblPrijs += cdblDouane / 100 * Convert.ToDouble(tbWaardeLading.Text);
                }

            
            }

            tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
         

        }
    }
}
