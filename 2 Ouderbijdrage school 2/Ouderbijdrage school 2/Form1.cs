using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouderbijdrage_school_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variabelen
        DateTime[] arrayGeboorteDatum = new DateTime[10];
        bool booEenOuderGezin;
        int intAantal = 0, intTeller, intKindOnder10 = 0, intKindBoven10 = 0,
        intLeefTijd;
        double dblOuderBijdrage;

        private void btnOuderBijdrage_Click(object sender, EventArgs e)
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

                if (intLeefTijd < 10 && intKindOnder10 <= 2)
                {
                    dblOuderBijdrage += 25;
                    intKindOnder10++;
                }

                else if (10 <= intLeefTijd && intKindBoven10 <= 1)
                {
                    dblOuderBijdrage += 37;
                }
            }

            dblOuderBijdrage += 50;

            if (dblOuderBijdrage > 150)
            {
                dblOuderBijdrage = 150;
            }

            if (cbEenOuderGezin.Checked == true)
            {
                dblOuderBijdrage = dblOuderBijdrage - 0.25 * dblOuderBijdrage;
            }
          tbOuderBijdrage.Text = dblOuderBijdrage.ToString();
        }

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            arrayGeboorteDatum[intAantal] = Convert.ToDateTime(tbGeboorteDatum.Text);
            tbGeboorteDatum.Clear();
            booEenOuderGezin = cbEenOuderGezin.Checked;
            intAantal++;
            lblAantal.Text = intAantal.ToString();
        }

    }
}
