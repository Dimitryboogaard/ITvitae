using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Letterfrequenties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayLetterFrequenties = new int[256];
        int intASCII, intTeller;
        string strTekst = "", strGekozenFile = "";

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openFD.Title = "Open tekstfile";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.FileName = "";
            openFD.Filter = "Tekst (*.txt)|*.txt";
            openFD.ShowDialog();

            strGekozenFile = openFD.FileName;
            rtbTekst.LoadFile(strGekozenFile, RichTextBoxStreamType.PlainText);
            strTekst = rtbTekst.Text;
        }

        private void btnLetterFrequenties_Click(object sender, EventArgs e)
        {

            //Array op 0 zetten

            for (intTeller = 0; intTeller <= 255; intTeller++)
            {
                arrayLetterFrequenties[intTeller] = 0;
            }

            //Letters tellen
            strTekst = rtbTekst.Text;

            foreach(char Karakter in strTekst)
            {
                intASCII = Convert.ToInt16(Karakter);
                arrayLetterFrequenties[intASCII]++;
            }

            for(intTeller = 32; intTeller <= 255; intTeller++)
            {
                char Karakter = Convert.ToChar(intTeller);

                rtbLetterFrequenties.Text += Karakter + "     " + 
                Convert.ToString(arrayLetterFrequenties[intTeller]) + Environment.NewLine;

            }

        }
    }
}
