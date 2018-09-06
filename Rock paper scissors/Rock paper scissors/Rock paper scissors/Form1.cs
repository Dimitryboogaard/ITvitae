using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_paper_scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayWaarden[1] = "Rock";
            arrayWaarden[2] = "Paper";
            arrayWaarden[3] = "Scissors";
        }

        string[] arrayWaarden = new string[4];
        Random rndWillekeurigGetal = new Random();
        int intWaardeGebruiker, intWillekeurigGetal;


        private void btnRock_Click(object sender, EventArgs e)
        {
            intWillekeurigGetal = rndWillekeurigGetal.Next(1, 4);
            lblWaardeComputer.Text = arrayWaarden[intWillekeurigGetal];

            if (intWillekeurigGetal == 1)
            {
                lblWinnaar.Text = "Gelijk";
            }

            else if (intWillekeurigGetal == 2)
            {
                lblWinnaar.Text = "Ik win";
            }

            else if (intWillekeurigGetal == 3)
            {
                lblWinnaar.Text = "U wint";
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            intWillekeurigGetal = rndWillekeurigGetal.Next(1, 4);
            lblWaardeComputer.Text = arrayWaarden[intWillekeurigGetal];

            if (intWillekeurigGetal == 1)
            {
                lblWinnaar.Text = "U wint";
            }

            else if (intWillekeurigGetal == 2)
            {
                lblWinnaar.Text = "Gelijk";
            }

            else if (intWillekeurigGetal == 3)
            {
                lblWinnaar.Text = "Ik win";
            }

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            intWillekeurigGetal = rndWillekeurigGetal.Next(1, 4);
            lblWaardeComputer.Text = arrayWaarden[intWillekeurigGetal];

            if (intWillekeurigGetal == 1)
            {
                lblWinnaar.Text = "Ik win";
            }

            else if (intWillekeurigGetal == 2)
            {
                lblWinnaar.Text = "U wint";
            }

            else if (intWillekeurigGetal == 3)
            {
                lblWinnaar.Text = "Gelijk";
            }

        }

    }
}
