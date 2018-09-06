using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayMorseCode[33] = "-·-·--";
            arrayMorseCode[38] = "·-···";
            arrayMorseCode[39] = "·----·";
            arrayMorseCode[40] = "-·--·";
            arrayMorseCode[41] = "-·--·-";
            arrayMorseCode[44] = "--··--";
            arrayMorseCode[46] = "·-·-·-";
            arrayMorseCode[47] = "-··-·";
            arrayMorseCode[48] = "-----";
            arrayMorseCode[49] = "·----";
            arrayMorseCode[50] = "··---";
            arrayMorseCode[51] = "···--";
            arrayMorseCode[52] = "····-";
            arrayMorseCode[53] = "·····";
            arrayMorseCode[54] = "-····";
            arrayMorseCode[55] = "--···";
            arrayMorseCode[56] = "---··";
            arrayMorseCode[57] = "----·";
            arrayMorseCode[58] = "---···";
            arrayMorseCode[59] = "-·-·-";
            arrayMorseCode[61] = "-···-";
            arrayMorseCode[63] = "··--··";
            arrayMorseCode[64] = "·--·-·";
            arrayMorseCode[65] = "·-";
            arrayMorseCode[66] = "-···";
            arrayMorseCode[67] = "-·-·";
            arrayMorseCode[68] = "-··";
            arrayMorseCode[69] = "·";
            arrayMorseCode[70] = "··-·";
            arrayMorseCode[71] = "--·";
            arrayMorseCode[72] = "····";
            arrayMorseCode[73] = "··";
            arrayMorseCode[74] = "·---";
            arrayMorseCode[75] = "-·-";
            arrayMorseCode[76] = "·-··";
            arrayMorseCode[77] = "--";
            arrayMorseCode[78] = "-·";
            arrayMorseCode[79] = "---";
            arrayMorseCode[80] = "·--·";
            arrayMorseCode[81] = "--·-";
            arrayMorseCode[82] = "·-·";
            arrayMorseCode[83] = "···";
            arrayMorseCode[84] = "-";
            arrayMorseCode[85] = "··-";
            arrayMorseCode[86] = "·--";
            arrayMorseCode[87] = "···-";
            arrayMorseCode[88] = "-··-";
            arrayMorseCode[89] = "-·--";
            arrayMorseCode[90] = "--··";

        }

        string[] arrayMorseCode = new string[256];
        string strTekst, strMorseCode, strSpatie;
        int intASCII, intTeller, intTeller2, intStringLengte;


        private void button1_Click(object sender, EventArgs e)
        {
            strTekst = rtTekst.Text;

            rtTekst.Clear();

            foreach(char Karakter in strTekst)
            {
                intASCII = Convert.ToInt32(Karakter);
                rtTekst.Text += arrayMorseCode[intASCII] + " ";
                if(intASCII == 32)
                {
                    rtTekst.Text += "   ";
                }

            }
        }

        private void btnMaakGewoneTekst_Click(object sender, EventArgs e)
        {
            strTekst = rtTekst.Text;

            rtTekst.Clear();

            intStringLengte = strTekst.Length;

            strMorseCode = "";

            for(intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
            {
                if (strTekst.Substring(intTeller, 1) != " ")
                {
                    strMorseCode += strTekst.Substring(intTeller, 1);
                }


                if (strTekst.Substring(intTeller, 1) == " " || intTeller == intStringLengte - 1)
                {
                    strSpatie += " ";

                    if(strSpatie == "   ")
                    {
                        rtTekst.Text += " ";
                        strSpatie = ""; 
                    }


                        for (intTeller2 = 33; intTeller2 <= 90; intTeller2++)
                        {
                            if (strMorseCode == arrayMorseCode[intTeller2])
                            {
                                char Karakter = Convert.ToChar(intTeller2);
                                rtTekst.Text += Karakter;
                                strMorseCode = "";
                            }

                        }
                    

                }

                if(strTekst.Substring(intTeller, 1) != " ")
                {
                    strSpatie = "";
                }

            }
        }
    }
}

