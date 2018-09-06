using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torens_van_Hanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arraySpel[1, 1] = 1;
            arraySpel[1, 2] = 2;
            arraySpel[1, 3] = 3;
            arraySpel[1, 4] = 4;
            arraySpel[1, 5] = 5;
            arraySpel[1, 6] = 6;
            arraySpel[1, 7] = 7;
            arraySpel[1, 8] = 8;
            arraySpel[1, 9] = 9;
            arraySpel[2, 9] = 9;
            arraySpel[3, 9] = 9;

            for (intTeller = 1; intTeller <= 8; intTeller++)
            {

                rtLinks.Text += Convert.ToString(arraySpel[1, intTeller]) + Environment.NewLine;
            }
        }

        int[,] arraySpel = new int[4, 10];
        int intTeller, intVanRij, intNaarRij;
        bool booGewonnen;

        private void btnLinks_Click(object sender, EventArgs e)
        {
            if (btnMidden.Text == "" && btnRechts.Text == "" && btnLinks.Text == "")
            {
                btnLinks.Text = "x";
            }

            else if(btnLinks.Text == "x")
            {
                btnLinks.Text = "";
            }

            if (btnMidden.Text == "x")
            {
                VanRij2();
                NaarRij1();

                if (arraySpel[2, intVanRij] < arraySpel[1, intNaarRij])
                {
                    arraySpel[1, intNaarRij - 1] = arraySpel[2, intVanRij];
                    arraySpel[2, intVanRij] = 0;

                    lblCommentaar.Text = "";

                    TekenTorens();
                }

                else
                {
                    lblCommentaar.Text = "Kan niet.";
                    btnMidden.Text = "";
                }

            }

            if (btnRechts.Text == "x")
            {
                VanRij3();
                NaarRij1();

                if (arraySpel[3, intVanRij] < arraySpel[1, intNaarRij])
                {
                    arraySpel[1, intNaarRij - 1] = arraySpel[3, intVanRij];
                    arraySpel[3, intVanRij] = 0;

                    lblCommentaar.Text = "";

                    TekenTorens();
                }

                else
                {
                    lblCommentaar.Text = "Kan niet.";
                    btnRechts.Text = "";
                }

            }


        }

        private void btnMidden_Click(object sender, EventArgs e)
        {
            if (btnLinks.Text == "" && btnRechts.Text == "" && btnMidden.Text == "")
            {
                btnMidden.Text = "x";
            }

            else if (btnMidden.Text == "x")
            {
                btnMidden.Text = "";
            }

            if (btnLinks.Text == "x")
            {
                VanRij1();
                NaarRij2();

                if (arraySpel[1, intVanRij] < arraySpel[2, intNaarRij])
                {
                    arraySpel[2, intNaarRij - 1] = arraySpel[1, intVanRij];
                    arraySpel[1, intVanRij] = 0;

                    lblCommentaar.Text = "";

                    TekenTorens();
                }

                else
                {
                    lblCommentaar.Text = "Kan niet.";
                    btnLinks.Text = "";
                }
            }

            if (btnRechts.Text == "x")
            {
                VanRij3();
                NaarRij2();

                if (arraySpel[3, intVanRij] < arraySpel[2, intNaarRij])
                {
                    arraySpel[2, intNaarRij - 1] = arraySpel[3, intVanRij];
                    arraySpel[3, intVanRij] = 0;

                    lblCommentaar.Text = "";

                    TekenTorens();

                }

                else
                {
                    lblCommentaar.Text = "Kan niet.";
                    btnRechts.Text = "";
                }


            }
        }

        private void btnRechts_Click_1(object sender, EventArgs e)
        {
            if (btnLinks.Text == "" && btnMidden.Text == "" && btnRechts.Text == "")
            {
                btnRechts.Text = "x";
            }

            else if (btnRechts.Text == "x")
            {
                btnRechts.Text = "";
            }


            if (btnLinks.Text == "x")
            {
                VanRij1();
                NaarRij3();

                if (arraySpel[1, intVanRij] < arraySpel[3, intNaarRij])
                {
                    arraySpel[3, intNaarRij - 1] = arraySpel[1, intVanRij];
                    arraySpel[1, intVanRij] = 0;

                    lblCommentaar.Text = "";

                    TekenTorens();
                }

                else
                {
                    lblCommentaar.Text = "Kan niet.";
                    btnLinks.Text = "";
                }
            }

            if (btnMidden.Text == "x")
            {
                VanRij2();
                NaarRij3();

                if (arraySpel[2, intVanRij] < arraySpel[3, intNaarRij])
                {
                    arraySpel[3, intNaarRij - 1] = arraySpel[2, intVanRij];
                    arraySpel[2, intVanRij] = 0;

                    lblCommentaar.Text = "";

                    TekenTorens();
                }

                else
                {
                    lblCommentaar.Text = "Kan niet.";
                    btnMidden.Text = "";
                }
            }



        }

        void VanRij1()
        {
            intVanRij = 1;
            while (arraySpel[1, intVanRij] == 0 && intVanRij < 8)
            {
                intVanRij++;
            } 


            return;
        }

        void VanRij2()
        {
            intVanRij = 1;
            while (arraySpel[2, intVanRij] == 0 && intVanRij < 8) 
            {
                intVanRij++;
            } 

            return;
        }

        void VanRij3()
        {
            intVanRij = 1;
            while(arraySpel[3, intVanRij] == 0 && intVanRij < 8)
            {
                intVanRij++;
            } 

            return;
        }

        void NaarRij1()
        {
            intNaarRij = 1;
            while (arraySpel[1, intNaarRij] == 0 && intNaarRij < 9) 
            {
                intNaarRij++;
            } 

            return;
        }

        

        void NaarRij2()
        {
            intNaarRij = 1;
            while (arraySpel[2, intNaarRij] == 0 && intNaarRij < 9)
            {
                intNaarRij++;
            } 

            return;
        }


        void NaarRij3()
        {
            intNaarRij = 1;
            while (arraySpel[3, intNaarRij] == 0 && intNaarRij < 9)
            {
                intNaarRij++;
            } 

            return;
        }


        void TekenTorens()
        {
            btnLinks.Text = "";
            btnMidden.Text = "";
            btnRechts.Text = "";

            rtLinks.Clear();
            rtMidden.Clear();
            rtRechts.Clear();

            for(intTeller = 1; intTeller <= 8; intTeller++)
            {
                if(arraySpel[1, intTeller] == 0)
                {
                    rtLinks.Text += " " + Environment.NewLine;
                }

                else
                {
                    rtLinks.Text += Convert.ToString(arraySpel[1, intTeller]) + Environment.NewLine;
                }

                if (arraySpel[2, intTeller] == 0)
                {
                    rtMidden.Text += " " + Environment.NewLine;
                }

                else
                {
                    rtMidden.Text += Convert.ToString(arraySpel[2, intTeller]) + Environment.NewLine; ;
                }

                if (arraySpel[3, intTeller] == 0)
                {
                    rtRechts.Text += " " + Environment.NewLine;
                }

                else
                {
                    rtRechts.Text += Convert.ToString(arraySpel[3, intTeller]) + Environment.NewLine;
                }


            }

            booGewonnen = true;

            for(intTeller = 1; intTeller <= 8; intTeller++)
            {
                if(arraySpel[2, intTeller] == 0)
                {
                    booGewonnen = false;
                }
            }

            if (!booGewonnen)
            {
                booGewonnen = true;

                for (intTeller = 1; intTeller <= 8; intTeller++)
                {
                    if (arraySpel[3, intTeller] == 0)
                    {
                        booGewonnen = false;
                    }
                }
            }

            if(booGewonnen)
            {
                lblCommentaar.Text = "Gefeliciteerd!";

                btnLinks.Enabled = false;
                btnMidden.Enabled = false;
                btnRechts.Enabled = false;

                btnOpnieuw.Visible = true;
            }

            return;
        }

        private void btnOpnieuw_Click(object sender, EventArgs e)
        {
            arraySpel[1, 1] = 1;
            arraySpel[1, 2] = 2;
            arraySpel[1, 3] = 3;
            arraySpel[1, 4] = 4;
            arraySpel[1, 5] = 5;
            arraySpel[1, 6] = 6;
            arraySpel[1, 7] = 7;
            arraySpel[1, 8] = 8;

            for (intTeller = 1; intTeller <= 8; intTeller++)
            {
                arraySpel[2, intTeller] = 0;
                arraySpel[3, intTeller] = 0;
            }

            TekenTorens();

            btnLinks.Enabled = true;
            btnMidden.Enabled = true;
            btnRechts.Enabled = true;

            btnOpnieuw.Visible = false;

            lblCommentaar.Text = "";

        }

    }
}
