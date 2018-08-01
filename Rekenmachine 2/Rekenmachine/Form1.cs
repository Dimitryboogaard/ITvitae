using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Decalareren van de variabelen
        double dblTotaal1 = 0, dblTotaal2 = 0, dblGeheugen = 0;
        int intStringLengte = 0, intTeller;
        string strType;
        bool booVlag, booKomma = false;

        //Invoer van de getallen en de komma
        private void btn1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btn0.Text;
        }

        private void btnKomma_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "")
            {
                tbDisplay.Text = "0,";
            }

            intStringLengte = tbDisplay.Text.Length;

            booKomma = false; 

            for (intTeller = 1; intTeller <= intStringLengte; intTeller++)
            {
                if (tbDisplay.Text.Substring((intTeller - 1), 1) == ",")
                {
                    booKomma = true;
                }
            }

            if(booKomma == false)
            {
                tbDisplay.Text = tbDisplay.Text + btnKomma.Text;
            }
        }
        
        //Operatoren
        private void btnPlus_Click(object sender, EventArgs e)
        {
            dblTotaal1 += Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Clear();
            strType = "+";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if(booVlag == false)
            {
                dblTotaal1 += Convert.ToDouble(tbDisplay.Text);
                tbDisplay.Clear();
                strType = "-";
                booVlag = true;
            }
            else if(booVlag == true)
            {
                dblTotaal1 -= Convert.ToDouble(tbDisplay.Text);
                tbDisplay.Clear();
                strType = "-";
            }
        }

        private void btnDeel_Click(object sender, EventArgs e)
        {
            if (booVlag == false)
            {
                dblTotaal1 += Convert.ToDouble(tbDisplay.Text);
                tbDisplay.Clear();
                strType = "/";
                booVlag = true;
            }
            else if (booVlag == true)
            {
                dblTotaal1 = dblTotaal1 / Convert.ToDouble(tbDisplay.Text);
                tbDisplay.Clear();
                strType = "/";
            }
        }

        private void btnMaal_Click(object sender, EventArgs e)
        {
            if (booVlag == false)
            {
                dblTotaal1 += Convert.ToDouble(tbDisplay.Text);
                tbDisplay.Clear();
                strType = "*";
                booVlag = true;
            }
            else if (booVlag == true)
            {
                dblTotaal1 = dblTotaal1 * Convert.ToDouble(tbDisplay.Text);
                tbDisplay.Clear();
                strType = "*";
            }
        }
        
        //Antwoord
        private void btnIs_Click(object sender, EventArgs e)
        {
            switch(strType)
            {
                case "+":
                    dblTotaal2 = dblTotaal1 + Convert.ToDouble(tbDisplay.Text);
                    tbDisplay.Text = dblTotaal2.ToString();
                    booVlag = false;
                    dblTotaal1 = 0;
                    break;

                case "-":
                    dblTotaal2 = dblTotaal1 - Convert.ToDouble(tbDisplay.Text);
                    tbDisplay.Text = dblTotaal2.ToString();
                    booVlag = false;
                    dblTotaal1 = 0;
                    break;

                case "/":
                    dblTotaal2 = dblTotaal1 / Convert.ToDouble(tbDisplay.Text);
                    tbDisplay.Text = dblTotaal2.ToString();
                    booVlag = false;
                    dblTotaal1 = 0;
                    break;

                case "*":
                    dblTotaal2 = dblTotaal1 * Convert.ToDouble(tbDisplay.Text);
                    tbDisplay.Text = dblTotaal2.ToString();
                    booVlag = false;
                    dblTotaal1 = 0;
                    break;
            }
        }

        //Geheugen lezen
        private void btnReadMemory_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = Convert.ToString(dblGeheugen);
        }

        //Geheugen schrijven
        private void btnWriteMemory_Click(object sender, EventArgs e)
        {
            dblGeheugen = Convert.ToDouble(tbDisplay.Text);
        }

        //Leegmaken scherm en variabelen maar niet het geheugen
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
            dblTotaal1 = 0;
            dblTotaal2 = 0;
            booVlag = false;
        }
    }
}
