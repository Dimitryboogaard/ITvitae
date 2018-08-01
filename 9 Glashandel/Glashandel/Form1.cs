using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glashandel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variabelen
        const double cdblGewoonGlasKosten = 30, cdblGewoonGlasSnijKosten = 10,
                     cdblSpeciaalGlasKosten = 55, cdblSpeciaalGlasSnijKosten = 25,
                     cdblMinimumZonderSnijKosten = 145, cdblMinimumKorting = 250,
                     cdblKortingsPercentage = 5;
        double dblPrijs, dblAantalM2;

        private void btnPrijs_Click(object sender, EventArgs e)
        {
            dblAantalM2 = Convert.ToDouble(tbAantalM2.Text);

            if(!cbSpeciaalGlas.Checked)
            {
                if(!cbRestant.Checked)
                {
                    if(Math.Round(dblAantalM2, 0) * cdblGewoonGlasKosten < 145)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 0) * cdblGewoonGlasKosten + 
                                   cdblGewoonGlasSnijKosten;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }

                    if(Math.Round(dblAantalM2, 0) * cdblGewoonGlasKosten >= 145 &&
                       Math.Round(dblAantalM2, 0) * cdblGewoonGlasKosten <= 250)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 0) * cdblGewoonGlasKosten;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }

                    if(Math.Round(dblAantalM2, 0) * cdblGewoonGlasKosten > 250)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 0) * cdblGewoonGlasKosten -
                                   Math.Round(dblAantalM2, 0) * cdblGewoonGlasKosten *
                                   cdblKortingsPercentage / 100;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }
                }

                if (cbRestant.Checked)
                {
                    if (dblAantalM2 * cdblGewoonGlasKosten < 145)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 2) * cdblGewoonGlasKosten +
                                   cdblGewoonGlasSnijKosten;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }

                    if (dblAantalM2 * cdblGewoonGlasKosten >= 145 &&
                        dblAantalM2 * cdblGewoonGlasKosten <= 250)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 2) * cdblGewoonGlasKosten;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }

                    if (dblAantalM2 * cdblGewoonGlasKosten > 250)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 2) * cdblGewoonGlasKosten -
                                   Math.Round(dblAantalM2, 2) * cdblGewoonGlasKosten *
                                   cdblKortingsPercentage / 100;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }
                }

            }

            if (cbSpeciaalGlas.Checked)
            {
                if (!cbRestant.Checked)
                {
                    if (Math.Round(dblAantalM2, 0) * cdblSpeciaalGlasKosten < 145)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 0) * cdblSpeciaalGlasKosten +
                                   cdblSpeciaalGlasSnijKosten;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }

                    if (Math.Round(dblAantalM2, 0) * cdblSpeciaalGlasKosten >= 145 &&
                        Math.Round(dblAantalM2, 0) * cdblSpeciaalGlasKosten <= 250)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 0) * cdblSpeciaalGlasKosten;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }

                    if (Math.Round(dblAantalM2, 0) * cdblSpeciaalGlasKosten > 250)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 0) * cdblSpeciaalGlasKosten -
                                   Math.Round(dblAantalM2, 0) * cdblSpeciaalGlasKosten *
                                   cdblKortingsPercentage / 100;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }
                }

                if (cbRestant.Checked)
                {
                    if (dblAantalM2 * cdblSpeciaalGlasKosten < 145)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 2) * cdblSpeciaalGlasKosten +
                                   cdblSpeciaalGlasSnijKosten;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }

                    if (dblAantalM2 * cdblSpeciaalGlasKosten >= 145 &&
                        dblAantalM2 * cdblSpeciaalGlasKosten <= 250)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 2) * cdblSpeciaalGlasKosten;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }

                    if (dblAantalM2 * cdblSpeciaalGlasKosten > 250)
                    {
                        dblPrijs = Math.Round(dblAantalM2, 2) * cdblSpeciaalGlasKosten -
                                   Math.Round(dblAantalM2, 2) * cdblSpeciaalGlasKosten *
                                   cdblKortingsPercentage / 100;
                        tbPrijs.Text = Convert.ToString(Math.Round(dblPrijs, 2));
                    }
                }

            }
        }
    }
}
