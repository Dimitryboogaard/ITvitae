using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinderbijslag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variabelen
        DateTime[] arrayGeboorteDatum = new DateTime[20];
        int intAantal = 0, intTeller, intLeefTijd;
        double dblKinderBijslag;

        private void btnKinderBijslag_Click(object sender, EventArgs e)
        {
            for (intTeller = 1; intTeller <= intAantal; intTeller++)
            {
                //Leeftijd bepalen
                intLeefTijd = Convert.ToInt16(DateTime.Now.Year - arrayGeboorteDatum[intTeller - 1].Year);

                if (DateTime.Now.Month == arrayGeboorteDatum[intTeller - 1].Month
                 && DateTime.Now.Day < arrayGeboorteDatum[intTeller - 1].Day
                 || DateTime.Now.Month < arrayGeboorteDatum[intTeller - 1].Month)
                {
                    intLeefTijd--;
                }

                if (intLeefTijd < 12)
                {
                    dblKinderBijslag += 150;
                    
                }

                else if (12 <= intLeefTijd && intLeefTijd < 18)
                {
                    dblKinderBijslag += 235;
                   
                }
            }

            if (intAantal == 3 || intAantal == 4)
            {
                dblKinderBijslag += dblKinderBijslag * 2 / 100;
            }

            else if (intAantal == 5)
            {
                dblKinderBijslag += dblKinderBijslag * 3 / 100;

            }

            else if (intAantal > 5)
            {
                dblKinderBijslag += dblKinderBijslag * 3.5 / 100;

            }

            tbKinderBijslag.Text = Convert.ToString(dblKinderBijslag);
        }
    



        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            arrayGeboorteDatum[intAantal] = Convert.ToDateTime(tbGeboorteDatum.Text);
            tbGeboorteDatum.Clear();
            intAantal++;
            lblAantal.Text = intAantal.ToString();
        }
    }
}
