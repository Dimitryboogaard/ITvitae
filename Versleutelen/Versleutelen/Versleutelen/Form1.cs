using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Versleutelen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variabelen
        string strGekozenFile = "", strTekstString = "", strVersleuteld = "", strTijdelijk,
               strVersleuteldASCII, strVersleuteldKarakter, strSavedFile = "";

        private void mnuSave_Click(object sender, EventArgs e)
        {
            saveFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFD.Title = "Save een versleuteld bestand";
            saveFD.FileName = "";
            saveFD.Filter = "Versleutelde bestanden (*.vst)|*.vst";
            if(saveFD.ShowDialog() != DialogResult.Cancel)
            {
                strSavedFile = saveFD.FileName;
                rtbTekst.SaveFile(strSavedFile, RichTextBoxStreamType.PlainText);
            }
        }

        int intStringLengte, intVersleuteld, intTeller, intASCII;

        private void btnVersleutel_Click(object sender, EventArgs e)
        {
            //Versleutelen
            foreach (char Karakter in strTekstString)
            {
                
                intVersleuteld = Convert.ToInt16(Karakter) + 1;
                strVersleuteld += intVersleuteld.ToString() + ",";
            }

            btnVersleutel.Visible = false;

            //Versleutelde tekst weergeven
            intStringLengte = strVersleuteld.Length;

            for (intTeller = 1; intTeller <= intStringLengte; intTeller++)
            {

                strTijdelijk = strVersleuteld.Substring(intTeller - 1, 1);


                if (strTijdelijk != ",")
                {
                    strVersleuteldASCII += strTijdelijk;


                }

                else if (strTijdelijk == ",")
                {
                    intASCII = Convert.ToInt32(strVersleuteldASCII);
                    char Karakter = Convert.ToChar(intASCII);
                    strVersleuteldKarakter += Karakter.ToString();
                    strVersleuteldASCII = "";

                }

                rtbTekst.Text = strVersleuteldKarakter;

            }

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openFD.Title = "Open tekstfile";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.FileName = "";
            openFD.Filter = "Tekst (*.txt)|*.txt";
            openFD.ShowDialog();

            strGekozenFile = openFD.FileName;
            rtbTekst.LoadFile(strGekozenFile, RichTextBoxStreamType.PlainText);
            strTekstString = rtbTekst.Text;
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
