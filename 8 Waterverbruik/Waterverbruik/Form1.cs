using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterverbruik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variablen
        const double cdblVastrechtTarief1 = 100, cdblVastrechtTarief2 = 75,
                     cdblVerbruiksKostenTarief1 = 0.25, cdblVerbruiksKostenTarief2 = 0.38;
        double dblVerbruik, dblPrijs;

        private void btnPrijs_Click(object sender, EventArgs e)
        {
            dblVerbruik = Convert.ToDouble(tbVerbruik.Text);

            if(rbTarief1.Checked)
            {
                dblPrijs = cdblVastrechtTarief1 + dblVerbruik * cdblVerbruiksKostenTarief1;
                tbPrijs.Text = Convert.ToString(dblPrijs);
            }

            if(rbTarief2.Checked)
            {
                dblPrijs = cdblVastrechtTarief2 + dblVerbruik * cdblVerbruiksKostenTarief2;
                tbPrijs.Text = Convert.ToString(dblPrijs);

            }

            if(rbTarief0.Checked)
            {
                if((cdblVerbruiksKostenTarief2 - cdblVerbruiksKostenTarief1) * dblVerbruik >
                    cdblVastrechtTarief1 - cdblVastrechtTarief2)
                {
                    dblPrijs = cdblVastrechtTarief1 + dblVerbruik * cdblVerbruiksKostenTarief1;
                    tbPrijs.Text = Convert.ToString(dblPrijs);

                }

                else
                {
                    dblPrijs = cdblVastrechtTarief2 + dblVerbruik * cdblVerbruiksKostenTarief2;
                    tbPrijs.Text = Convert.ToString(dblPrijs);

                }

            }
        }
    }
}
