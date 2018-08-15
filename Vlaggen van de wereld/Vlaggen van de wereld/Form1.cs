using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vlaggen_van_de_wereld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayLanden[0] = "Afghanistan";
            arrayLanden[1] = "Albanië";
            arrayLanden[2] = "Algerije";
            arrayLanden[3] = "Andorra";
            arrayLanden[4] = "Angola";
            arrayLanden[5] = "Antigua en Barbuda";
            arrayLanden[6] = "Argentinië";
            arrayLanden[7] = "Armenië";
            arrayLanden[8] = "Australië";
            arrayLanden[9] = "Azerbeidzjan";
            arrayLanden[10] = "Bahama's";
            arrayLanden[11] = "Bahrein";
            arrayLanden[12] = "Bangladesh";
            arrayLanden[13] = "Barbados";
            arrayLanden[14] = "België";
            arrayLanden[15] = "Belize";
            arrayLanden[16] = "Benin";
            arrayLanden[17] = "Bhutan";
            arrayLanden[18] = "Bolivia";
            arrayLanden[19] = "Bosnië en Herzegovina";
            arrayLanden[20] = "Botswana";
            arrayLanden[21] = "Brazilië";
            arrayLanden[22] = "Brunei";
            arrayLanden[23] = "Bulgarije";
            arrayLanden[24] = "Burkina Faso";
            arrayLanden[25] = "Burundi";
            arrayLanden[26] = "Cambodja";
            arrayLanden[27] = "Canada";
            arrayLanden[28] = "Centraal-Afrikaanse Republiek";
            arrayLanden[29] = "Chili";
            arrayLanden[30] = "China";
            arrayLanden[31] = "Colombia";
            arrayLanden[32] = "Comoren";
            arrayLanden[33] = "Congo-Brazzaville";
            arrayLanden[34] = "Congo-Kinshasa";
            arrayLanden[35] = "Costa Rica";
            arrayLanden[36] = "Cuba";
            arrayLanden[37] = "Cyprus";
            arrayLanden[38] = "Denemarken";
            arrayLanden[39] = "Djibouti";
            arrayLanden[40] = "Dominica";
            arrayLanden[41] = "Dominicaanse Republiek";
            arrayLanden[42] = "Duitsland";
            arrayLanden[43] = "Ecuador";
            arrayLanden[44] = "Egypte";
            arrayLanden[45] = "El Salvador";
            arrayLanden[46] = "Equatoriaal-Guinea";
            arrayLanden[47] = "Eritrea";
            arrayLanden[48] = "Estland";
            arrayLanden[49] = "Ethiopië";
            arrayLanden[50] = "Fiji";
            arrayLanden[51] = "Filipijnen";
            arrayLanden[52] = "Finland";
            arrayLanden[53] = "Frankrijk";
            arrayLanden[54] = "Gabon";
            arrayLanden[55] = "Gambia";
            arrayLanden[56] = "Georgië";
            arrayLanden[57] = "Ghana";
            arrayLanden[58] = "Grenada";
            arrayLanden[59] = "Griekenland";
            arrayLanden[60] = "Guatemala";
            arrayLanden[61] = "Guinee";
            arrayLanden[62] = "Guinee-Bissau";
            arrayLanden[63] = "Guyana";
            arrayLanden[64] = "Haïti";
            arrayLanden[65] = "Honduras";
            arrayLanden[66] = "Hongarije";
            arrayLanden[67] = "Ierland";
            arrayLanden[68] = "IJsland";
            arrayLanden[69] = "India";
            arrayLanden[70] = "Indonesië";
            arrayLanden[71] = "Irak";
            arrayLanden[72] = "Iran";
            arrayLanden[73] = "Israël";
            arrayLanden[74] = "Italië";
            arrayLanden[75] = "Ivoorkust";
            arrayLanden[76] = "Jamaica";
            arrayLanden[77] = "Japan";
            arrayLanden[78] = "Jemen";
            arrayLanden[79] = "Jordanië";
            arrayLanden[80] = "Kaapverdië";
            arrayLanden[81] = "Kameroen";
            arrayLanden[82] = "Kazachstan";
            arrayLanden[83] = "Kenia";
            arrayLanden[84] = "Kirgizië";
            arrayLanden[85] = "Kiribati";
            arrayLanden[86] = "Koeweit";
            arrayLanden[87] = "Kosovo";
            arrayLanden[88] = "Kroatië";
            arrayLanden[89] = "Laos";
            arrayLanden[90] = "Lesotho";
            arrayLanden[91] = "Letland";
            arrayLanden[92] = "Libanon";
            arrayLanden[93] = "Liberia";
            arrayLanden[94] = "Libië";
            arrayLanden[95] = "Liechtenstein";
            arrayLanden[96] = "Litouwen";
            arrayLanden[97] = "Luxemburg";
            arrayLanden[98] = "Macedonië";
            arrayLanden[99] = "Madagaskar";
            arrayLanden[100] = "Malawi";
            arrayLanden[101] = "Maldiven";
            arrayLanden[102] = "Maleisië";
            arrayLanden[103] = "Mali";
            arrayLanden[104] = "Malta";
            arrayLanden[105] = "Marokko";
            arrayLanden[106] = "Marshalleilanden";
            arrayLanden[107] = "Mauritanië";
            arrayLanden[108] = "Mauritius";
            arrayLanden[109] = "Mexico";
            arrayLanden[110] = "Micronesia";
            arrayLanden[111] = "Moldavië";
            arrayLanden[112] = "Monaco";
            arrayLanden[113] = "Mongolië";
            arrayLanden[114] = "Montenegro";
            arrayLanden[115] = "Mozambique";
            arrayLanden[116] = "Myanmar";
            arrayLanden[117] = "Namibië";
            arrayLanden[118] = "Nauru";
            arrayLanden[119] = "Nederland";
            arrayLanden[120] = "Nepal";
            arrayLanden[121] = "Nicaragua";
            arrayLanden[122] = "Nieuw-Zeeland";
            arrayLanden[123] = "Niger";
            arrayLanden[124] = "Nigeria";
            arrayLanden[125] = "Noord-Korea";
            arrayLanden[126] = "Noorwegen";
            arrayLanden[127] = "Oeganda";
            arrayLanden[128] = "Oekraïne";
            arrayLanden[129] = "Oezbekistan";
            arrayLanden[130] = "Oman";
            arrayLanden[131] = "Oostenrijk";
            arrayLanden[132] = "Oost-Timor";
            arrayLanden[133] = "Pakistan";
            arrayLanden[134] = "Palau";
            arrayLanden[135] = "Palestina";
            arrayLanden[136] = "Panama";
            arrayLanden[137] = "Papoea-Nieuw-Guinea";
            arrayLanden[138] = "Paraguay";
            arrayLanden[139] = "Peru";
            arrayLanden[140] = "Polen";
            arrayLanden[141] = "Portugal";
            arrayLanden[142] = "Qatar";
            arrayLanden[143] = "Roemenië";
            arrayLanden[144] = "Rusland";
            arrayLanden[145] = "Rwanda";
            arrayLanden[146] = "Saint Kitts en Nevis";
            arrayLanden[147] = "Saint Lucia";
            arrayLanden[148] = "Saint Vincent en de Grenadines";
            arrayLanden[149] = "Salomonseilanden";
            arrayLanden[150] = "Samoa";
            arrayLanden[151] = "San Marino";
            arrayLanden[152] = "Sao Tomé en Principe";
            arrayLanden[153] = "Saoedi-Arabië";
            arrayLanden[154] = "Senegal";
            arrayLanden[155] = "Servië";
            arrayLanden[156] = "Seychellen";
            arrayLanden[157] = "Sierra Leone";
            arrayLanden[158] = "Singapore";
            arrayLanden[159] = "Slovenië";
            arrayLanden[160] = "Soedan";
            arrayLanden[161] = "Somalië";
            arrayLanden[162] = "Spanje";
            arrayLanden[163] = "Sri Lanka";
            arrayLanden[164] = "Suriname";
            arrayLanden[165] = "Swaziland";
            arrayLanden[166] = "Syrië";
            arrayLanden[167] = "Tadzjikistan";
            arrayLanden[168] = "Tanzania";
            arrayLanden[169] = "Thailand";
            arrayLanden[170] = "Togo";
            arrayLanden[171] = "Tonga";
            arrayLanden[172] = "Trinidad en Tobago";
            arrayLanden[173] = "Tsjaad";
            arrayLanden[174] = "Tsjechië";
            arrayLanden[175] = "Tunesië";
            arrayLanden[176] = "Turkije";
            arrayLanden[177] = "Turkmenistan";
            arrayLanden[178] = "Tuvalu";
            arrayLanden[179] = "Uruguay";
            arrayLanden[180] = "Vanuatu";
            arrayLanden[181] = "Vaticaanstad";
            arrayLanden[182] = "Venezuela";
            arrayLanden[183] = "Verenigd Koninkrijk";
            arrayLanden[184] = "Verenigde Arabische Emiraten";
            arrayLanden[185] = "Verenigde Staten";
            arrayLanden[186] = "Vietnam";
            arrayLanden[187] = "Wit-Rusland";
            arrayLanden[188] = "Zambia";
            arrayLanden[189] = "Zimbabwe";
            arrayLanden[190] = "Zuid-Afrika";
            arrayLanden[191] = "Zuid-Korea";
            arrayLanden[192] = "Zuid-Soedan";
            arrayLanden[193] = "Zweden";
            arrayLanden[194] = "Zwitserland";

            PictureBox pb = Controls["pb" + intVlaggenTeller.ToString()] as PictureBox;
            pbVlag.Image = pb.Image;
            lblLandNaam.Text = arrayLanden[intVlaggenTeller];
        }

        string[] arrayLanden = new string[195];
        int[] arrayFouten = new int[195];
        int intVlaggenTeller = 0;
        Random rndWillekeurigGetal = new Random();
        int intWillekeurigGetal, intTeller, intJuisteAntwoord;
        int[] arrayAntwoorden = new int[4];
        const int cintAantalLanden = 195;


        private void button1_Click(object sender, EventArgs e)
        {
            intVlaggenTeller--;
            if (intVlaggenTeller < 1)
            {
                intVlaggenTeller = 0;
            }
            PictureBox pb = Controls["pb" + intVlaggenTeller.ToString()] as PictureBox;

            pbVlag.Image = pb.Image;
            lblLandNaam.Text = arrayLanden[intVlaggenTeller];
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            intVlaggenTeller++;
            if (intVlaggenTeller > 193)
            {
                intVlaggenTeller = 194;
            }
            PictureBox pb = Controls["pb" + intVlaggenTeller.ToString()] as PictureBox;

            pbVlag.Image = pb.Image;
            lblLandNaam.Text = arrayLanden[intVlaggenTeller];

        }

        private void mnuBekijken_Click(object sender, EventArgs e)
        {
            intVlaggenTeller = intJuisteAntwoord;
            lblLandNaam.Text = arrayLanden[intVlaggenTeller];
            pbVlag.Visible = true;
            btnVolgende.Visible = true;
            btnVorige.Visible = true;
            btnVolgendeVraag.Visible = false;
            rtbFouten.Visible = false;
            btnStoppen.Visible = false;
            rbAntwoord1.Visible = false;
            rbAntwoord2.Visible = false;
            rbAntwoord3.Visible = false;
            rbAntwoord4.Visible = false;
        }

        private void btnStoppen_Click(object sender, EventArgs e)
        {
            pbVlag.Visible = false;
            rbAntwoord1.Visible = false;
            rbAntwoord2.Visible = false;
            rbAntwoord3.Visible = false;
            rbAntwoord4.Visible = false;
            btnVolgendeVraag.Visible = false;
            btnStoppen.Visible = false;
            rtbFouten.Visible = true;

            lblLandNaam.Text = "Deze landen had u fout.";

            for(intTeller = 0; intTeller <= 194; intTeller++)
            {
                if(arrayFouten[intTeller] > 0)
                {
                    rtbFouten.Text += arrayLanden[intTeller] + Environment.NewLine;
                }
            }

        }

        private void mnuOefenen_Click(object sender, EventArgs e)
        {
            lblLandNaam.Text = "";
            pbVlag.Visible = true;
            btnVolgende.Visible = false;
            btnVorige.Visible = false;
            btnVolgendeVraag.Visible = true;
            btnStoppen.Visible = true;
            rtbFouten.Visible = false;
            rbAntwoord1.Visible = true;
            rbAntwoord2.Visible = true;
            rbAntwoord3.Visible = true;
            rbAntwoord4.Visible = true;

            for(intTeller = 0; intTeller <= 194; intTeller++)
            {
                arrayFouten[intTeller] = 0;
            }

            rtbFouten.Clear();

            intWillekeurigGetal = rndWillekeurigGetal.Next(0, cintAantalLanden);
            arrayAntwoorden[0] = intWillekeurigGetal;
            do
            {
                intWillekeurigGetal = rndWillekeurigGetal.Next(0, cintAantalLanden);
                arrayAntwoorden[1] = intWillekeurigGetal;

            } while (intWillekeurigGetal == arrayAntwoorden[0]);

            do
            {
                intWillekeurigGetal = rndWillekeurigGetal.Next(0, cintAantalLanden);
                arrayAntwoorden[2] = intWillekeurigGetal;


            } while (intWillekeurigGetal == arrayAntwoorden[0] || intWillekeurigGetal == arrayAntwoorden[1]);

            do
            {
                intWillekeurigGetal = rndWillekeurigGetal.Next(0, cintAantalLanden);
                arrayAntwoorden[3] = intWillekeurigGetal;


            } while (intWillekeurigGetal == arrayAntwoorden[0] || intWillekeurigGetal == arrayAntwoorden[1]
                     || intWillekeurigGetal == arrayAntwoorden[2]);

            intJuisteAntwoord = arrayAntwoorden[rndWillekeurigGetal.Next(0, 4)];
            PictureBox pi = Controls["pb" + intJuisteAntwoord.ToString()] as PictureBox;
            pbVlag.Image = pi.Image;
            btnVolgendeVraag.Text = "Antwoord";


            rbAntwoord1.Text = arrayLanden[arrayAntwoorden[0]];
            rbAntwoord2.Text = arrayLanden[arrayAntwoorden[1]];
            rbAntwoord3.Text = arrayLanden[arrayAntwoorden[2]];
            rbAntwoord4.Text = arrayLanden[arrayAntwoorden[3]];

            rbAntwoord1.Checked = false;
            rbAntwoord2.Checked = false;
            rbAntwoord3.Checked = false;
            rbAntwoord4.Checked = false;


        }

        private void btnVolgendeVraag_Click(object sender, EventArgs e)
        {
            if (btnVolgendeVraag.Text == "Volgende")

            {
                lblLandNaam.Text = "";
                intWillekeurigGetal = rndWillekeurigGetal.Next(0, cintAantalLanden);
                arrayAntwoorden[0] = intWillekeurigGetal;
                do
                {
                    intWillekeurigGetal = rndWillekeurigGetal.Next(0, cintAantalLanden);
                    arrayAntwoorden[1] = intWillekeurigGetal;

                } while (intWillekeurigGetal == arrayAntwoorden[0]);

                do
                {
                    intWillekeurigGetal = rndWillekeurigGetal.Next(0, cintAantalLanden);
                    arrayAntwoorden[2] = intWillekeurigGetal;


                } while (intWillekeurigGetal == arrayAntwoorden[0] || intWillekeurigGetal == arrayAntwoorden[1]);

                do
                {
                    intWillekeurigGetal = rndWillekeurigGetal.Next(0, cintAantalLanden);
                    arrayAntwoorden[3] = intWillekeurigGetal;


                } while (intWillekeurigGetal == arrayAntwoorden[0] || intWillekeurigGetal == arrayAntwoorden[1]
                         || intWillekeurigGetal == arrayAntwoorden[2]);

                intJuisteAntwoord = arrayAntwoorden[rndWillekeurigGetal.Next(0, 4)];
                PictureBox pi = Controls["pb" + intJuisteAntwoord.ToString()] as PictureBox;
                pbVlag.Image = pi.Image;
                btnVolgendeVraag.Text = "Antwoord";


                rbAntwoord1.Text = arrayLanden[arrayAntwoorden[0]];
                rbAntwoord2.Text = arrayLanden[arrayAntwoorden[1]];
                rbAntwoord3.Text = arrayLanden[arrayAntwoorden[2]];
                rbAntwoord4.Text = arrayLanden[arrayAntwoorden[3]];

                rbAntwoord1.Checked = false;
                rbAntwoord2.Checked = false;
                rbAntwoord3.Checked = false;
                rbAntwoord4.Checked = false;


            }

            else if (btnVolgendeVraag.Text == "Antwoord")
            {
                
                if (rbAntwoord1.Checked && rbAntwoord1.Text == arrayLanden[intJuisteAntwoord])
                {
                    {
                        lblLandNaam.Text = "Goed.";
                        arrayFouten[intJuisteAntwoord] = 0;
                    }
                }

                else if (rbAntwoord2.Checked && rbAntwoord2.Text == arrayLanden[intJuisteAntwoord])
                {

                    {
                        lblLandNaam.Text = "Goed.";
                        arrayFouten[intJuisteAntwoord] = 0;

                    }

                }

                else if (rbAntwoord3.Checked && rbAntwoord3.Text == arrayLanden[intJuisteAntwoord])
                {

                    {
                        lblLandNaam.Text = "Goed.";
                        arrayFouten[intJuisteAntwoord] = 0;

                    }

                }

                else if (rbAntwoord4.Checked && rbAntwoord4.Text == arrayLanden[intJuisteAntwoord])
                {

                    {
                        lblLandNaam.Text = "Goed.";
                        arrayFouten[intJuisteAntwoord] = 0;

                    }

                }

                else
                {
                    lblLandNaam.Text = "Fout. ";
                    lblLandNaam.Text += " " + arrayLanden[intJuisteAntwoord];
                    arrayFouten[intJuisteAntwoord]++;
                }

                btnVolgendeVraag.Text = "Volgende";
                
            }
        }
    }
}