using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romeinse_rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dblTotaal1, dblTotaal2, dblAntwoord, dblReken;
        bool booVlag;
        string strType, strRomeinsGetal, strRomeinseLetter;
        int intStringLengte, intTeller = 0, intDecimaalGetal, intReken, intRest;
        int[] arrayWaarde = new int[20];


        private void btnI_Click(object sender, EventArgs e)
        {
            if (rtbDisplay.Text != "Te groot")
            {
                rtbDisplay.Text += "I";
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            if (rtbDisplay.Text != "Te groot")
            {
                rtbDisplay.Text += "V";
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (rtbDisplay.Text != "Te groot")
            {
                rtbDisplay.Text += "X";
            }
        }


        private void btnL_Click(object sender, EventArgs e)
        {
            if (rtbDisplay.Text != "Te groot")
            {
                rtbDisplay.Text += "L";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (rtbDisplay.Text != "Te groot")
            {
                rtbDisplay.Text += "C";
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (rtbDisplay.Text != "Te groot")
            {
                rtbDisplay.Text += "D";
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (rtbDisplay.Text != "Te groot")
            {
                rtbDisplay.Text += "M";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (rtbDisplay.Text != "Te groot")
            {
                strRomeinsGetal = rtbDisplay.Text;
                intStringLengte = strRomeinsGetal.Length;

                for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                {
                    strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                    switch (strRomeinseLetter)
                    {
                        case "I":
                            arrayWaarde[intTeller] = 1;
                            break;

                        case "V":
                            arrayWaarde[intTeller] = 5;
                            break;

                        case "X":
                            arrayWaarde[intTeller] = 10;
                            break;

                        case "L":
                            arrayWaarde[intTeller] = 50;
                            break;

                        case "C":
                            arrayWaarde[intTeller] = 100;
                            break;

                        case "D":
                            arrayWaarde[intTeller] = 500;
                            break;

                        case "M":
                            arrayWaarde[intTeller] = 1000;
                            break;
                    }
                }

                for (intTeller = 0; intTeller <= 18; intTeller++)
                {
                    if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                    {
                        arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                    }
                }

                for (intTeller = 0; intTeller <= 18; intTeller++)
                {
                    intDecimaalGetal += arrayWaarde[intTeller];
                    arrayWaarde[intTeller] = 0;
                }

                dblTotaal1 = intDecimaalGetal;

                if (dblTotaal1 >= 3000)
                {
                    rtbDisplay.Text = "Te groot";
                }

                else

                {
                    rtbDisplay.Clear();
                    strType = "+";
                }

                intDecimaalGetal = 0;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if(rtbDisplay.Text != "Te groot")
            {
                if (booVlag == false)
                {
                    strRomeinsGetal = rtbDisplay.Text;
                    intStringLengte = strRomeinsGetal.Length;

                    for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                    {
                        strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                        switch (strRomeinseLetter)
                        {
                            case "I":
                                arrayWaarde[intTeller] = 1;
                                break;

                            case "V":
                                arrayWaarde[intTeller] = 5;
                                break;

                            case "X":
                                arrayWaarde[intTeller] = 10;
                                break;

                            case "L":
                                arrayWaarde[intTeller] = 50;
                                break;

                            case "C":
                                arrayWaarde[intTeller] = 100;
                                break;

                            case "D":
                                arrayWaarde[intTeller] = 500;
                                break;

                            case "M":
                                arrayWaarde[intTeller] = 1000;
                                break;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                        {
                            arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        intDecimaalGetal += arrayWaarde[intTeller];
                        arrayWaarde[intTeller] = 0;
                    }

                    dblTotaal1 = intDecimaalGetal;

                    if (dblTotaal1 >= 3000)
                    {
                        rtbDisplay.Text = "Te groot";
                    }

                    else

                    {
                        rtbDisplay.Clear();
                        strType = "-";
                        booVlag = true;

                    }

                    intDecimaalGetal = 0;

                }
                else if (booVlag == true)
                {
                    strRomeinsGetal = rtbDisplay.Text;
                    intStringLengte = strRomeinsGetal.Length;

                    for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                    {
                        strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                        switch (strRomeinseLetter)
                        {
                            case "I":
                                arrayWaarde[intTeller] = 1;
                                break;

                            case "V":
                                arrayWaarde[intTeller] = 5;
                                break;

                            case "X":
                                arrayWaarde[intTeller] = 10;
                                break;

                            case "L":
                                arrayWaarde[intTeller] = 50;
                                break;

                            case "C":
                                arrayWaarde[intTeller] = 100;
                                break;

                            case "D":
                                arrayWaarde[intTeller] = 500;
                                break;

                            case "M":
                                arrayWaarde[intTeller] = 1000;
                                break;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                        {
                            arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        intDecimaalGetal += arrayWaarde[intTeller];
                        arrayWaarde[intTeller] = 0;
                    }

                    dblTotaal1 = intDecimaalGetal;

                    if (dblTotaal1 >= 3000)
                    {
                        rtbDisplay.Text = "Te groot";
                    }

                    else

                    {
                        rtbDisplay.Clear();
                        strType = "-";

                    }


                    intDecimaalGetal = 0;
                }
            }
        }

        private void btnMaal_Click(object sender, EventArgs e)
        {
            if (rtbDisplay.Text != "Te groot")
            {
                if (booVlag == false)
                {
                    strRomeinsGetal = rtbDisplay.Text;
                    intStringLengte = strRomeinsGetal.Length;

                    for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                    {
                        strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                        switch (strRomeinseLetter)
                        {
                            case "I":
                                arrayWaarde[intTeller] = 1;
                                break;

                            case "V":
                                arrayWaarde[intTeller] = 5;
                                break;

                            case "X":
                                arrayWaarde[intTeller] = 10;
                                break;

                            case "L":
                                arrayWaarde[intTeller] = 50;
                                break;

                            case "C":
                                arrayWaarde[intTeller] = 100;
                                break;

                            case "D":
                                arrayWaarde[intTeller] = 500;
                                break;

                            case "M":
                                arrayWaarde[intTeller] = 1000;
                                break;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                        {
                            arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        intDecimaalGetal += arrayWaarde[intTeller];
                        arrayWaarde[intTeller] = 0;
                    }

                    dblTotaal1 = intDecimaalGetal;

                    if (dblTotaal1 >= 3000)
                    {
                        rtbDisplay.Text = "Te groot";
                    }

                    else

                    {
                        rtbDisplay.Clear();
                        strType = "*";
                        booVlag = true;

                    }


                    intDecimaalGetal = 0;
                }
                else if (booVlag == true)
                {
                    strRomeinsGetal = rtbDisplay.Text;
                    intStringLengte = strRomeinsGetal.Length;

                    for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                    {
                        strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                        switch (strRomeinseLetter)
                        {
                            case "I":
                                arrayWaarde[intTeller] = 1;
                                break;

                            case "V":
                                arrayWaarde[intTeller] = 5;
                                break;

                            case "X":
                                arrayWaarde[intTeller] = 10;
                                break;

                            case "L":
                                arrayWaarde[intTeller] = 50;
                                break;

                            case "C":
                                arrayWaarde[intTeller] = 100;
                                break;

                            case "D":
                                arrayWaarde[intTeller] = 500;
                                break;

                            case "M":
                                arrayWaarde[intTeller] = 1000;
                                break;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                        {
                            arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        intDecimaalGetal += arrayWaarde[intTeller];
                        arrayWaarde[intTeller] = 0;
                    }

                    dblTotaal1 = intDecimaalGetal;

                    if (dblTotaal1 >= 3000)
                    {
                        rtbDisplay.Text = "Te groot";
                    }

                    else

                    {
                        rtbDisplay.Clear();
                        strType = "*";
                    }


                    intDecimaalGetal = 0;
                }
            }
        }

        private void btnDeel_Click(object sender, EventArgs e)
        {
            if (rtbDisplay.Text != "Te groot")
            {
                if (booVlag == false)
                {
                    strRomeinsGetal = rtbDisplay.Text;
                    intStringLengte = strRomeinsGetal.Length;

                    for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                    {
                        strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                        switch (strRomeinseLetter)
                        {
                            case "I":
                                arrayWaarde[intTeller] = 1;
                                break;

                            case "V":
                                arrayWaarde[intTeller] = 5;
                                break;

                            case "X":
                                arrayWaarde[intTeller] = 10;
                                break;

                            case "L":
                                arrayWaarde[intTeller] = 50;
                                break;

                            case "C":
                                arrayWaarde[intTeller] = 100;
                                break;

                            case "D":
                                arrayWaarde[intTeller] = 500;
                                break;

                            case "M":
                                arrayWaarde[intTeller] = 1000;
                                break;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                        {
                            arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        intDecimaalGetal += arrayWaarde[intTeller];
                        arrayWaarde[intTeller] = 0;
                    }

                    dblTotaal1 = intDecimaalGetal;

                    if (dblTotaal1 >= 3000)
                    {
                        rtbDisplay.Text = "Te groot";
                    }

                    else

                    {
                        rtbDisplay.Clear();
                        strType = "/";
                        booVlag = true;
                    }

                    intDecimaalGetal = 0;
                }
                else if (booVlag == true)
                {
                    strRomeinsGetal = rtbDisplay.Text;
                    intStringLengte = strRomeinsGetal.Length;

                    for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                    {
                        strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                        switch (strRomeinseLetter)
                        {
                            case "I":
                                arrayWaarde[intTeller] = 1;
                                break;

                            case "V":
                                arrayWaarde[intTeller] = 5;
                                break;

                            case "X":
                                arrayWaarde[intTeller] = 10;
                                break;

                            case "L":
                                arrayWaarde[intTeller] = 50;
                                break;

                            case "C":
                                arrayWaarde[intTeller] = 100;
                                break;

                            case "D":
                                arrayWaarde[intTeller] = 500;
                                break;

                            case "M":
                                arrayWaarde[intTeller] = 1000;
                                break;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                        {
                            arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                        }
                    }

                    for (intTeller = 0; intTeller <= 18; intTeller++)
                    {
                        intDecimaalGetal += arrayWaarde[intTeller];
                        arrayWaarde[intTeller] = 0;
                    }

                    dblTotaal1 = intDecimaalGetal;

                    if (dblTotaal1 >= 3000)
                    {
                        rtbDisplay.Text = "Te groot";
                    }

                    else

                    {
                        rtbDisplay.Clear();
                        strType = "/";
                        booVlag = true;

                    }


                    intDecimaalGetal = 0;
                }
            }
        }

        private void btnIs_Click(object sender, EventArgs e)
        {
           if(rtbDisplay.Text != "Te groot")
            {

                switch (strType)
                {
                    case "+":
                        strRomeinsGetal = rtbDisplay.Text;
                        intStringLengte = strRomeinsGetal.Length;

                        for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                        {
                            strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                            switch (strRomeinseLetter)
                            {
                                case "I":
                                    arrayWaarde[intTeller] = 1;
                                    break;

                                case "V":
                                    arrayWaarde[intTeller] = 5;
                                    break;

                                case "X":
                                    arrayWaarde[intTeller] = 10;
                                    break;

                                case "L":
                                    arrayWaarde[intTeller] = 50;
                                    break;

                                case "C":
                                    arrayWaarde[intTeller] = 100;
                                    break;

                                case "D":
                                    arrayWaarde[intTeller] = 500;
                                    break;

                                case "M":
                                    arrayWaarde[intTeller] = 1000;
                                    break;
                            }
                        }

                        for (intTeller = 0; intTeller <= 18; intTeller++)
                        {
                            if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                            {
                                arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                            }
                        }

                        for (intTeller = 0; intTeller <= 18; intTeller++)
                        {
                            intDecimaalGetal += arrayWaarde[intTeller];
                            arrayWaarde[intTeller] = 0;
                        }

                        dblTotaal2 = intDecimaalGetal;

                        if (dblTotaal2 >= 3000)
                        {
                            rtbDisplay.Text = "Te groot";
                        }

                        else
                        {
                            dblAntwoord = dblTotaal1 + dblTotaal2;

                            intDecimaalGetal = 0;

                            if (dblAntwoord >= 3000)
                            {
                                rtbDisplay.Text = "Te groot";
                            }

                            else
                            {
                                rtbDisplay.Clear();

                                intReken = Convert.ToInt16(Math.Floor(dblAntwoord / 1000));
                                intRest = Convert.ToInt16(dblAntwoord % 1000);

                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "M";
                                    intTeller++;
                                }



                                if (intRest >= 900)
                                {
                                    rtbDisplay.Text += "CM";
                                    intRest -= 900;
                                }

                                else if (400 <= intRest && intRest < 500)
                                {
                                    rtbDisplay.Text += "CD";
                                    intRest -= 400;
                                }

                                else if (500 <= intRest && intRest < 900)
                                {
                                    rtbDisplay.Text += "D";
                                    intRest -= 500;
                                }

                                intReken = Convert.ToInt16(intRest / 100);
                                intRest = intRest % 100;

                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "C";
                                    intTeller++;
                                }

                                if (intRest >= 90)
                                {
                                    rtbDisplay.Text += "XC";
                                    intRest -= 90;
                                }

                                else if (40 <= intRest && intRest < 50)
                                {
                                    rtbDisplay.Text += "XL";
                                    intRest -= 40;
                                }

                                else if (50 <= intRest && intRest < 90)
                                {
                                    rtbDisplay.Text += "L";
                                    intRest -= 50;
                                }

                                intReken = Convert.ToInt16(intRest / 10);
                                intRest = intRest % 10;

                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "X";
                                    intTeller++;
                                }

                                if (intRest == 9)
                                {
                                    rtbDisplay.Text += "IX";
                                    intRest -= 9;
                                }

                                else if (intRest == 4)
                                {
                                    rtbDisplay.Text += "IV";
                                    intRest -= 4;
                                }

                                else if (5 <= intRest && intRest < 9)
                                {
                                    rtbDisplay.Text += "V";
                                    intRest -= 5;
                                }

                                intReken = Convert.ToInt16(intRest / 1);


                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "I";
                                    intTeller++;
                                }

                                booVlag = false;
                                dblTotaal1 = 0;
                            }
                        }
                        break;


                    case "-":
                        strRomeinsGetal = rtbDisplay.Text;
                        intStringLengte = strRomeinsGetal.Length;

                        for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                        {
                            strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                            switch (strRomeinseLetter)
                            {
                                case "I":
                                    arrayWaarde[intTeller] = 1;
                                    break;

                                case "V":
                                    arrayWaarde[intTeller] = 5;
                                    break;

                                case "X":
                                    arrayWaarde[intTeller] = 10;
                                    break;

                                case "L":
                                    arrayWaarde[intTeller] = 50;
                                    break;

                                case "C":
                                    arrayWaarde[intTeller] = 100;
                                    break;

                                case "D":
                                    arrayWaarde[intTeller] = 500;
                                    break;

                                case "M":
                                    arrayWaarde[intTeller] = 1000;
                                    break;
                            }
                        }

                        for (intTeller = 0; intTeller <= 18; intTeller++)
                        {
                            if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                            {
                                arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                            }
                        }

                        for (intTeller = 0; intTeller <= 18; intTeller++)
                        {
                            intDecimaalGetal += arrayWaarde[intTeller];
                            arrayWaarde[intTeller] = 0;
                        }

                        dblTotaal2 = intDecimaalGetal;
                        intDecimaalGetal = 0;
                        dblAntwoord = dblTotaal1 - dblTotaal2;

                        if (dblTotaal2 >= 3000)
                        {
                            rtbDisplay.Text = "Te groot";
                        }

                        else
                        {
                            if (dblAntwoord >= 3000)
                            {
                                rtbDisplay.Text = "Te groot";
                            }

                            else
                            {
                                rtbDisplay.Clear();


                                intReken = Convert.ToInt16(Math.Floor(dblAntwoord / 1000));
                                intRest = Convert.ToInt16(dblAntwoord % 1000);

                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "M";
                                    intTeller++;
                                }



                                if (intRest >= 900)
                                {
                                    rtbDisplay.Text += "CM";
                                    intRest -= 900;
                                }

                                else if (400 <= intRest && intRest < 500)
                                {
                                    rtbDisplay.Text += "CD";
                                    intRest -= 400;
                                }

                                else if (500 <= intRest && intRest < 900)
                                {
                                    rtbDisplay.Text += "D";
                                    intRest -= 500;
                                }

                                intReken = Convert.ToInt16(intRest / 100);
                                intRest = intRest % 100;

                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "C";
                                    intTeller++;
                                }

                                if (intRest >= 90)
                                {
                                    rtbDisplay.Text += "XC";
                                    intRest -= 90;
                                }

                                else if (40 <= intRest && intRest < 50)
                                {
                                    rtbDisplay.Text += "XL";
                                    intRest -= 40;
                                }

                                else if (50 <= intRest && intRest < 90)
                                {
                                    rtbDisplay.Text += "L";
                                    intRest -= 50;
                                }

                                intReken = Convert.ToInt16(intRest / 10);
                                intRest = intRest % 10;

                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "X";
                                    intTeller++;
                                }

                                if (intRest == 9)
                                {
                                    rtbDisplay.Text += "IX";
                                    intRest -= 9;
                                }

                                else if (intRest == 4)
                                {
                                    rtbDisplay.Text += "IV";
                                    intRest -= 4;
                                }

                                else if (5 <= intRest && intRest < 9)
                                {
                                    rtbDisplay.Text += "V";
                                    intRest -= 5;
                                }

                                intReken = Convert.ToInt16(intRest / 1);


                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "I";
                                    intTeller++;
                                }
                                booVlag = false;
                                dblTotaal1 = 0;
                            }

                        }
                        break;

                    case "/":
                        strRomeinsGetal = rtbDisplay.Text;
                        intStringLengte = strRomeinsGetal.Length;

                        for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                        {
                            strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                            switch (strRomeinseLetter)
                            {
                                case "I":
                                    arrayWaarde[intTeller] = 1;
                                    break;

                                case "V":
                                    arrayWaarde[intTeller] = 5;
                                    break;

                                case "X":
                                    arrayWaarde[intTeller] = 10;
                                    break;

                                case "L":
                                    arrayWaarde[intTeller] = 50;
                                    break;

                                case "C":
                                    arrayWaarde[intTeller] = 100;
                                    break;

                                case "D":
                                    arrayWaarde[intTeller] = 500;
                                    break;

                                case "M":
                                    arrayWaarde[intTeller] = 1000;
                                    break;
                            }
                        }

                        for (intTeller = 0; intTeller <= 18; intTeller++)
                        {
                            if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                            {
                                arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                            }
                        }

                        for (intTeller = 0; intTeller <= 18; intTeller++)
                        {
                            intDecimaalGetal += arrayWaarde[intTeller];
                            arrayWaarde[intTeller] = 0;
                        }

                        dblTotaal2 = intDecimaalGetal;

                        if (dblTotaal2 >= 3000)
                        {
                            rtbDisplay.Text = "Te groot";
                        }

                        else
                        {

                            intDecimaalGetal = 0;
                            dblAntwoord = dblTotaal1 / dblTotaal2;

                            rtbDisplay.Clear();


                            intReken = Convert.ToInt16(Math.Floor(dblAntwoord / 1000));

                            intRest = Convert.ToInt16(dblAntwoord % 1000);

                            intTeller = 0;

                            while (intTeller < intReken)
                            {
                                rtbDisplay.Text += "M";
                                intTeller++;
                            }



                            if (intRest >= 900)
                            {
                                rtbDisplay.Text += "CM";
                                intRest -= 900;
                            }

                            else if (400 <= intRest && intRest < 500)
                            {
                                rtbDisplay.Text += "CD";
                                intRest -= 400;
                            }

                            else if (500 <= intRest && intRest < 900)
                            {
                                rtbDisplay.Text += "D";
                                intRest -= 500;
                            }

                            intReken = Convert.ToInt16(intRest / 100);
                            intRest = intRest % 100;

                            intTeller = 0;

                            while (intTeller < intReken)
                            {
                                rtbDisplay.Text += "C";
                                intTeller++;
                            }

                            if (intRest >= 90)
                            {
                                rtbDisplay.Text += "XC";
                                intRest -= 90;
                            }

                            else if (40 <= intRest && intRest < 50)
                            {
                                rtbDisplay.Text += "XL";
                                intRest -= 40;
                            }

                            else if (50 <= intRest && intRest < 90)
                            {
                                rtbDisplay.Text += "L";
                                intRest -= 50;
                            }

                            intReken = Convert.ToInt16(intRest / 10);
                            intRest = intRest % 10;

                            intTeller = 0;

                            while (intTeller < intReken)
                            {
                                rtbDisplay.Text += "X";
                                intTeller++;
                            }

                            if (intRest == 9)
                            {
                                rtbDisplay.Text += "IX";
                                intRest -= 9;
                            }

                            else if (intRest == 4)
                            {
                                rtbDisplay.Text += "IV";
                                intRest -= 4;
                            }

                            else if (5 <= intRest && intRest < 9)
                            {
                                rtbDisplay.Text += "V";
                                intRest -= 5;
                            }

                            intReken = Convert.ToInt16(intRest / 1);


                            intTeller = 0;

                            while (intTeller < intReken)
                            {
                                rtbDisplay.Text += "I";
                                intTeller++;
                            }
                            booVlag = false;
                            dblTotaal1 = 0;
                        }
                        break;

                    case "*":
                        strRomeinsGetal = rtbDisplay.Text;
                        intStringLengte = strRomeinsGetal.Length;

                        for (intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
                        {
                            strRomeinseLetter = strRomeinsGetal.Substring(intTeller, 1);

                            switch (strRomeinseLetter)
                            {
                                case "I":
                                    arrayWaarde[intTeller] = 1;
                                    break;

                                case "V":
                                    arrayWaarde[intTeller] = 5;
                                    break;

                                case "X":
                                    arrayWaarde[intTeller] = 10;
                                    break;

                                case "L":
                                    arrayWaarde[intTeller] = 50;
                                    break;

                                case "C":
                                    arrayWaarde[intTeller] = 100;
                                    break;

                                case "D":
                                    arrayWaarde[intTeller] = 500;
                                    break;

                                case "M":
                                    arrayWaarde[intTeller] = 1000;
                                    break;
                            }
                        }

                        for (intTeller = 0; intTeller <= 18; intTeller++)
                        {
                            if (arrayWaarde[intTeller] < arrayWaarde[intTeller + 1])
                            {
                                arrayWaarde[intTeller] = arrayWaarde[intTeller] * -1;
                            }
                        }

                        for (intTeller = 0; intTeller <= 18; intTeller++)
                        {
                            intDecimaalGetal += arrayWaarde[intTeller];
                            arrayWaarde[intTeller] = 0;
                        }

                        dblTotaal2 = intDecimaalGetal;
                        intDecimaalGetal = 0;

                        if (dblTotaal2 >= 3000)
                        {
                            rtbDisplay.Text = "Te groot";
                        }

                        else
                        {

                            dblAntwoord = dblTotaal1 * dblTotaal2;

                            if (dblAntwoord >= 3000)
                            {
                                rtbDisplay.Text = "Te groot";
                            }

                            else
                            {

                                rtbDisplay.Clear();


                                intReken = Convert.ToInt16(Math.Floor(dblAntwoord / 1000));
                                intRest = Convert.ToInt16(dblAntwoord % 1000);

                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "M";
                                    intTeller++;
                                }



                                if (intRest >= 900)
                                {
                                    rtbDisplay.Text += "CM";
                                    intRest -= 900;
                                }

                                else if (400 <= intRest && intRest < 500)
                                {
                                    rtbDisplay.Text += "CD";
                                    intRest -= 400;
                                }

                                else if (500 <= intRest && intRest < 900)
                                {
                                    rtbDisplay.Text += "D";
                                    intRest -= 500;
                                }

                                intReken = Convert.ToInt16(intRest / 100);
                                intRest = intRest % 100;

                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "C";
                                    intTeller++;
                                }

                                if (intRest >= 90)
                                {
                                    rtbDisplay.Text += "XC";
                                    intRest -= 90;
                                }

                                else if (40 <= intRest && intRest < 50)
                                {
                                    rtbDisplay.Text += "XL";
                                    intRest -= 40;
                                }

                                else if (50 <= intRest && intRest < 90)
                                {
                                    rtbDisplay.Text += "L";
                                    intRest -= 50;
                                }

                                intReken = Convert.ToInt16(intRest / 10);
                                intRest = intRest % 10;

                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "X";
                                    intTeller++;
                                }

                                if (intRest == 9)
                                {
                                    rtbDisplay.Text += "IX";
                                    intRest -= 9;
                                }

                                else if (intRest == 4)
                                {
                                    rtbDisplay.Text += "IV";
                                    intRest -= 4;
                                }

                                else if (5 <= intRest && intRest < 9)
                                {
                                    rtbDisplay.Text += "V";
                                    intRest -= 5;
                                }

                                intReken = Convert.ToInt16(intRest / 1);


                                intTeller = 0;

                                while (intTeller < intReken)
                                {
                                    rtbDisplay.Text += "I";
                                    intTeller++;
                                }
                                booVlag = false;
                                dblTotaal1 = 0;
                            }
                        }
                        break;
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            dblTotaal1 = 0;
            dblTotaal2 = 0;
            booVlag = false;
        }



    }
}
