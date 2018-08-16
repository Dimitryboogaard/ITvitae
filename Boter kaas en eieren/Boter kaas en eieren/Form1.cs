using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boter_kaas_en_eieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] arrayWaarden = new int[3, 3];
        int intTeller, intTeller2, intWillekeurigGetal, intWillekeurigGetal2;
        string strWinnaar = "";
        Random rndWillekeurigGetal = new Random();
        bool booGewonnen = false;

        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn11.Text == "")
            {
                btn11.Text = "x";
                arrayWaarden[0, 0] = 10;

                if (!booGewonnen)
                {
                    xGewonnen();

                    oGewonnen();
                }
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn12.Text == "")
            {
                btn12.Text = "x";
                arrayWaarden[0, 1] = 10;

                if (!booGewonnen)
                {
                    xGewonnen();

                    oGewonnen();
                }
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (btn13.Text == "")
            {
                btn13.Text = "x";
                arrayWaarden[0, 2] = 10;

                if (!booGewonnen)
                {
                    xGewonnen();

                    oGewonnen();
                }


            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (btn21.Text == "")
            {
                btn21.Text = "x";
                arrayWaarden[1, 0] = 10;

                if (!booGewonnen)
                {
                    xGewonnen();

                    oGewonnen();
                }


            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (btn22.Text == "")
            {
                btn22.Text = "x";
                arrayWaarden[1, 1] = 10;

                if (!booGewonnen)
                {
                    xGewonnen();

                    oGewonnen();
                }

            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (btn23.Text == "")
            {
                btn23.Text = "x";
                arrayWaarden[1, 2] = 10;

                if (!booGewonnen)
                {
                    xGewonnen();

                    oGewonnen();
                }


            }
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (btn31.Text == "")
            {
                btn31.Text = "x";
                arrayWaarden[2, 0] = 10;

                if (!booGewonnen)
                {
                    xGewonnen();

                    oGewonnen();
                }


            }
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (btn32.Text == "")
            {
                btn32.Text = "x";
                arrayWaarden[2, 1] = 10;

                if (!booGewonnen)
                {
                    xGewonnen();

                    oGewonnen();
                }


            }
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (btn33.Text == "")
            {
                btn33.Text = "x";
                arrayWaarden[2, 2] = 10;

                if (!booGewonnen)
                {
                    xGewonnen();

                    oGewonnen();
                }

            }
        }

        //Kijken of X gewonnen heeft
        void xGewonnen()
        {
            //Horizontaal
            if (arrayWaarden[0, 0] + arrayWaarden[0, 1] + arrayWaarden[0, 2] == 30)
            {
                strWinnaar = "U bent de winnaar";
                booGewonnen = true;
            }

            if (arrayWaarden[1, 0] + arrayWaarden[1, 1] + arrayWaarden[1, 2] == 30)
            {
                strWinnaar = "U bent de winnaar";
                booGewonnen = true;
            }

            if (arrayWaarden[2, 0] + arrayWaarden[2, 1] + arrayWaarden[2, 2] == 30)
            {
                strWinnaar = "U bent de winnaar";
                booGewonnen = true;
            }

            //Verticaal
            if (arrayWaarden[0, 0] + arrayWaarden[1, 0] + arrayWaarden[2, 0] == 30)
            {
                strWinnaar = "U bent de winnaar";
                booGewonnen = true;
            }

            if (arrayWaarden[0, 1] + arrayWaarden[1, 1] + arrayWaarden[2, 1] == 30)
            {
                strWinnaar = "U bent de winnaar";
                booGewonnen = true;
            }

            if (arrayWaarden[0, 2] + arrayWaarden[1, 2] + arrayWaarden[2, 2] == 30)
            {
                strWinnaar = "U bent de winnaar";
                booGewonnen = true;
            }

            //Diagonaal
            if (arrayWaarden[0, 0] + arrayWaarden[1, 1] + arrayWaarden[2, 2] == 30)
            {
                strWinnaar = "U bent de winnaar";
                booGewonnen = true;

            }

            if (arrayWaarden[0, 2] + arrayWaarden[1, 1] + arrayWaarden[2, 0] == 30)
            {
                strWinnaar = "U bent de winnaar";
                booGewonnen = true;

            }

            lblWinnaar.Text = strWinnaar;

            if (booGewonnen)
            {
                EindeSpel();
            }

            return;
        }

        //Kijken of o kan winnen. Zoniet, x tegenhouden, anders vakje kiezen.
        void oGewonnen()
        {
            if (!booGewonnen)
            {
                //Horizontaal
                if (arrayWaarden[0, 0] + arrayWaarden[0, 1] + arrayWaarden[0, 2] == 2)
                {
                    arrayWaarden[0, 0] = 1;
                    arrayWaarden[0, 1] = 1;
                    arrayWaarden[0, 2] = 1;

                    oInvullen();

                    strWinnaar = "Ik ben de winnaar";
                    booGewonnen = true;

                }



                else if (arrayWaarden[1, 0] + arrayWaarden[1, 1] + arrayWaarden[1, 2] == 2)
                {
                    arrayWaarden[1, 0] = 1;
                    arrayWaarden[1, 1] = 1;
                    arrayWaarden[1, 2] = 1;

                    oInvullen();

                    strWinnaar = "Ik ben de winnaar";
                    booGewonnen = true;

                }

                else if (arrayWaarden[2, 0] + arrayWaarden[2, 1] + arrayWaarden[2, 2] == 2)
                {
                    arrayWaarden[2, 0] = 1;
                    arrayWaarden[2, 1] = 1;
                    arrayWaarden[2, 2] = 1;

                    oInvullen();

                    strWinnaar = "Ik ben de winnaar";
                    booGewonnen = true;

                }

                //Verticaal
                else if (arrayWaarden[0, 0] + arrayWaarden[1, 0] + arrayWaarden[2, 0] == 2)
                {
                    arrayWaarden[0, 0] = 1;
                    arrayWaarden[1, 0] = 1;
                    arrayWaarden[2, 0] = 1;

                    oInvullen();

                    strWinnaar = "Ik ben de winnaar";
                    booGewonnen = true;

                }

                else if (arrayWaarden[0, 1] + arrayWaarden[1, 1] + arrayWaarden[2, 1] == 2)
                {
                    arrayWaarden[0, 1] = 1;
                    arrayWaarden[1, 1] = 1;
                    arrayWaarden[2, 1] = 1;

                    oInvullen();

                    strWinnaar = "Ik ben de winnaar";
                    booGewonnen = true;

                }

                else if (arrayWaarden[0, 2] + arrayWaarden[1, 2] + arrayWaarden[2, 2] == 2)
                {
                    arrayWaarden[0, 2] = 1;
                    arrayWaarden[1, 2] = 1;
                    arrayWaarden[2, 2] = 1;

                    oInvullen();

                    strWinnaar = "Ik ben de winnaar";
                    booGewonnen = true;

                }

                //Diagonaal
                else if (arrayWaarden[0, 0] + arrayWaarden[1, 1] + arrayWaarden[2, 2] == 2)
                {
                    arrayWaarden[0, 0] = 1;
                    arrayWaarden[1, 1] = 1;
                    arrayWaarden[2, 2] = 1;

                    oInvullen();

                    strWinnaar = "Ik ben de winnaar";
                    booGewonnen = true;

                }

                else if (arrayWaarden[2, 0] + arrayWaarden[1, 1] + arrayWaarden[0, 2] == 2)
                {
                    arrayWaarden[0, 2] = 1;
                    arrayWaarden[1, 1] = 1;
                    arrayWaarden[2, 0] = 1;

                    oInvullen();

                    strWinnaar = "Ik ben de winnaar";
                    booGewonnen = true;
                }


                //Derde x voorkomen
                //Horizontaal
                else if (arrayWaarden[0, 0] + arrayWaarden[0, 1] + arrayWaarden[0, 2] == 20)
                {
                    for (intTeller = 0; intTeller <= 2; intTeller++)
                    {
                        if (arrayWaarden[0, intTeller] == 0)
                        {
                            arrayWaarden[0, intTeller] = 1;
                        }
                    }

                    oInvullen();

                }

                else if (arrayWaarden[1, 0] + arrayWaarden[1, 1] + arrayWaarden[1, 2] == 20)
                {
                    for (intTeller = 0; intTeller <= 2; intTeller++)
                    {
                        if (arrayWaarden[1, intTeller] == 0)
                        {
                            arrayWaarden[1, intTeller] = 1;
                        }
                    }

                    oInvullen();

                }

                else if (arrayWaarden[2, 0] + arrayWaarden[2, 1] + arrayWaarden[2, 2] == 20)
                {
                    for (intTeller = 0; intTeller <= 2; intTeller++)
                    {
                        if (arrayWaarden[2, intTeller] == 0)
                        {
                            arrayWaarden[2, intTeller] = 1;
                        }
                    }

                    oInvullen();

                }

                //Verticaal
                else if (arrayWaarden[0, 0] + arrayWaarden[1, 0] + arrayWaarden[2, 0] == 20)
                {
                    for (intTeller = 0; intTeller <= 2; intTeller++)
                    {
                        if (arrayWaarden[intTeller, 0] == 0)
                        {
                            arrayWaarden[intTeller, 0] = 1;
                        }
                    }

                    oInvullen();

                }

                else if (arrayWaarden[0, 1] + arrayWaarden[1, 1] + arrayWaarden[2, 1] == 20)
                {
                    for (intTeller = 0; intTeller <= 2; intTeller++)
                    {
                        if (arrayWaarden[intTeller, 1] == 0)
                        {
                            arrayWaarden[intTeller, 1] = 1;
                        }
                    }

                    oInvullen();

                }

                else if (arrayWaarden[0, 2] + arrayWaarden[1, 2] + arrayWaarden[2, 2] == 20)
                {
                    for (intTeller = 0; intTeller <= 2; intTeller++)
                    {
                        if (arrayWaarden[intTeller, 2] == 0)
                        {
                            arrayWaarden[intTeller, 2] = 1;
                        }
                    }

                    oInvullen();

                }

                //Diagonaal
                else if (arrayWaarden[0, 0] + arrayWaarden[1, 1] + arrayWaarden[2, 2] == 20)
                {
                    for (intTeller = 0; intTeller <= 2; intTeller++)
                    {
                        if (arrayWaarden[intTeller, intTeller] == 0)
                        {
                            arrayWaarden[intTeller, intTeller] = 1;
                        }
                    }

                    oInvullen();

                }

                else if (arrayWaarden[2, 0] + arrayWaarden[1, 1] + arrayWaarden[0, 2] == 20)
                {
                    if (arrayWaarden[2, 0] == 0)
                    {
                        arrayWaarden[2, 0] = 1;
                    }

                    else if (arrayWaarden[1, 1] == 0)
                    {
                        arrayWaarden[1, 1] = 1;
                    }



                    else if (arrayWaarden[0, 2] == 0)
                    {
                        arrayWaarden[0, 2] = 1;
                    }

                    oInvullen();
                }

                //Tweede op een lijn krijgen
                //Horizontaal
                else if (arrayWaarden[0, 0] + arrayWaarden[0, 1] + arrayWaarden[0, 2] == 1)
                {
                    do
                    {
                        intWillekeurigGetal = rndWillekeurigGetal.Next(0, 3);
                    } while (arrayWaarden[0, intWillekeurigGetal] == 1);

                    arrayWaarden[0, intWillekeurigGetal] = 1;

                    oInvullen();

                }

                else if (arrayWaarden[1, 0] + arrayWaarden[1, 1] + arrayWaarden[1, 2] == 1)
                {
                    do
                    {
                        intWillekeurigGetal = rndWillekeurigGetal.Next(0, 3);
                    } while (arrayWaarden[1, intWillekeurigGetal] == 1);

                    arrayWaarden[1, intWillekeurigGetal] = 1;

                    oInvullen();

                }

                else if (arrayWaarden[2, 0] + arrayWaarden[2, 1] + arrayWaarden[2, 2] == 1)
                {
                    do
                    {
                        intWillekeurigGetal = rndWillekeurigGetal.Next(0, 3);
                    } while (arrayWaarden[2, intWillekeurigGetal] == 1);

                    arrayWaarden[2, intWillekeurigGetal] = 1;

                    oInvullen();

                }

                //Verticaal
                else if (arrayWaarden[0, 0] + arrayWaarden[1, 0] + arrayWaarden[2, 0] == 1)
                {
                    do
                    {
                        intWillekeurigGetal = rndWillekeurigGetal.Next(0, 3);
                    } while (arrayWaarden[intWillekeurigGetal, 0] == 1);

                    arrayWaarden[intWillekeurigGetal, 0] = 1;

                    oInvullen();

                }

                else if (arrayWaarden[0, 1] + arrayWaarden[1, 1] + arrayWaarden[2, 1] == 1)
                {
                    do
                    {
                        intWillekeurigGetal = rndWillekeurigGetal.Next(0, 3);
                    } while (arrayWaarden[intWillekeurigGetal, 1] == 1);

                    arrayWaarden[intWillekeurigGetal, 1] = 1;

                    oInvullen();

                }

                else if (arrayWaarden[0, 2] + arrayWaarden[1, 2] + arrayWaarden[2, 2] == 1)
                {
                    do
                    {
                        intWillekeurigGetal = rndWillekeurigGetal.Next(0, 3);
                    } while (arrayWaarden[intWillekeurigGetal, 2] == 1);

                    arrayWaarden[intWillekeurigGetal, 2] = 1;

                    oInvullen();

                }

                //Diagonaal
                else if (arrayWaarden[0, 0] + arrayWaarden[1, 1] + arrayWaarden[2, 2] == 1)
                {
                    do
                    {
                        intWillekeurigGetal = rndWillekeurigGetal.Next(0, 3);
                    } while (arrayWaarden[intWillekeurigGetal, intWillekeurigGetal] == 1);

                    arrayWaarden[intWillekeurigGetal, intWillekeurigGetal] = 1;

                    oInvullen();

                }

                else if (arrayWaarden[2, 0] + arrayWaarden[1, 1] + arrayWaarden[0, 2] == 1)
                {
                    do
                    {
                        intWillekeurigGetal = rndWillekeurigGetal.Next(0, 3);
                    } while (arrayWaarden[intWillekeurigGetal, intWillekeurigGetal] == 1);

                    arrayWaarden[2 - intWillekeurigGetal, intWillekeurigGetal] = 1;

                    oInvullen();

                }

                //Als alle vakjes vol zijn eindigen
                else if (arrayWaarden[0, 0] > 0 && arrayWaarden[0, 1] > 0 && arrayWaarden[0, 2] > 0 &&
                        arrayWaarden[1, 0] > 0 && arrayWaarden[1, 1] > 0 && arrayWaarden[1, 2] > 0 &&
                        arrayWaarden[2, 0] > 0 && arrayWaarden[2, 1] > 0 && arrayWaarden[2, 2] > 0)
                {
                    EindeSpel();
                }

                else
                {
                    do
                    {
                        intWillekeurigGetal = rndWillekeurigGetal.Next(0, 3);
                        intWillekeurigGetal2 = rndWillekeurigGetal.Next(0, 3);

                    } while (arrayWaarden[intWillekeurigGetal, intWillekeurigGetal2] != 0);

                    arrayWaarden[intWillekeurigGetal, intWillekeurigGetal2] = 1;

                    oInvullen();
                }

                lblWinnaar.Text = strWinnaar;

                if (booGewonnen)
                {
                    EindeSpel();
                }

                return;
            }
        }

        private void btnOpnieuw_Click_1(object sender, EventArgs e)
        {
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;

            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";

            strWinnaar = "";

            lblWinnaar.Text = "";
    
            for (intTeller = 0; intTeller <= 2; intTeller++)
            {
                for (intTeller2 = 0; intTeller2 <= 2; intTeller2++)
                {
                    arrayWaarden[intTeller, intTeller2] = 0;
                }
            }

            booGewonnen = false;

            btnOpnieuw.Enabled = false;


        }

        //o invullen
        void oInvullen()
        {
            if (arrayWaarden[0, 0] == 1)
            {
                btn11.Text = "o";
            }

            if (arrayWaarden[0, 1] == 1)
            {
                btn12.Text = "o";
            }

            if (arrayWaarden[0, 2] == 1)
            {
                btn13.Text = "o";
            }

            if (arrayWaarden[1, 0] == 1)
            {
                btn21.Text = "o";
            }

            if (arrayWaarden[1, 1] == 1)
            {
                btn22.Text = "o";
            }

            if (arrayWaarden[1, 2] == 1)
            {
                btn23.Text = "o";
            }

            if (arrayWaarden[2, 0] == 1)
            {
                btn31.Text = "o";
            }

            if (arrayWaarden[2, 1] == 1)
            {
                btn32.Text = "o";
            }

            if (arrayWaarden[2, 2] == 1)
            {
                btn33.Text = "o";
            }

            return;
        }


        void EindeSpel()
        {
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
            btn23.Enabled = false;
            btn31.Enabled = false;
            btn32.Enabled = false;
            btn33.Enabled = false;
            btnOpnieuw.Enabled = true;

            return;
        }

    }
}