using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declareren van de variabelen
        Random randomGetal = new Random();
        int[] arrayWorpen = new int[5], arrayUitslag = new int[7], arrayScore = new int[15];
        
        int intTeller, intTellerWaarde, intWaarde, intWillekeurigGetal, intTellerAantalWorpen = 0,
            intStraatTeller = 0, intRondeTeller,
            intScoreBovensteHelft, intScoreOnderteHelft, intTotaalGeneraal, intYahtzeeBonus;
        string strScore;
        bool boo3OfAKind, boo2OfAKind, booKleineStraat, booYahtzee = false, booYahtzee0 = false;

        private void btnWerpen_Click(object sender, EventArgs e)
        {
            
            intTellerAantalWorpen++;

            lblAantalWorpen.Text = Convert.ToString(3 - intTellerAantalWorpen);

            if (btnHold1.Text != "Roll")
            {
                arrayWorpen[0] = randomGetal.Next(1, 7);
            }

            if (btnHold2.Text != "Roll")
            {
                arrayWorpen[1] = randomGetal.Next(1, 7);
            }

            if (btnHold3.Text != "Roll")
            {
                arrayWorpen[2] = randomGetal.Next(1, 7);
            }

            if (btnHold4.Text != "Roll")
            {
                arrayWorpen[3] = randomGetal.Next(1, 7);
            }

            if (btnHold5.Text != "Roll")
            {
                arrayWorpen[4] = randomGetal.Next(1, 7);
            }

            
            rtbWorp1.Text = arrayWorpen[0].ToString();
            rtbWorp2.Text = arrayWorpen[1].ToString();
            rtbWorp3.Text = arrayWorpen[2].ToString();
            rtbWorp4.Text = arrayWorpen[3].ToString();
            rtbWorp5.Text = arrayWorpen[4].ToString();
            
            //Dit is voor zelf invullen
            /*
            arrayWorpen[0] = Convert.ToInt16(rtbWorp1.Text);
            arrayWorpen[1] = Convert.ToInt16(rtbWorp2.Text);
            arrayWorpen[2] = Convert.ToInt16(rtbWorp3.Text);
            arrayWorpen[3] = Convert.ToInt16(rtbWorp4.Text);
            arrayWorpen[4] = Convert.ToInt16(rtbWorp5.Text);
            */

            if (intTellerAantalWorpen == 1)
            {
                btnStop.Enabled = true;

                btnHold1.Enabled = true;
                btnHold2.Enabled = true;
                btnHold3.Enabled = true;
                btnHold4.Enabled = true;
                btnHold5.Enabled = true;
            }



            if (intTellerAantalWorpen == 2)
            {
                if (btnHold1.Text == "Roll")
                {
                    btnHold1.Enabled = false;
                }

                if (btnHold2.Text == "Roll")
                {
                    btnHold2.Enabled = false;
                }

                if (btnHold3.Text == "Roll")
                {
                    btnHold3.Enabled = false;
                }

                if (btnHold4.Text == "Roll")
                {
                    btnHold4.Enabled = false;
                }

                if (btnHold5.Text == "Roll")
                {
                    btnHold5.Enabled = false;
                }

            }

            if (intTellerAantalWorpen == 3)
            {
                Na3Worpen();

            }


        }


        private void btnHold1_Click(object sender, EventArgs e)
        {
            if (btnHold1.Text == "Roll")
            {
                btnHold1.Text = "Hold";
            }

            else if(btnHold2.Text == "Roll" && btnHold3.Text == "Roll" &&
                    btnHold4.Text == "Roll" && btnHold5.Text == "Roll")
            {
                btnHold1.Text = "Hold";
            }

            else
            {
                btnHold1.Text = "Roll";
            }
        }


        private void btnHold2_Click(object sender, EventArgs e)
        {
            if (btnHold2.Text == "Roll")
            {
                btnHold2.Text = "Hold";
            }

            else if (btnHold1.Text == "Roll" && btnHold3.Text == "Roll" &&
                    btnHold4.Text == "Roll" && btnHold5.Text == "Roll")
            {
                btnHold2.Text = "Hold";
            }

            else
            {
                btnHold2.Text = "Roll";
            }

        }


        private void btnHold3_Click(object sender, EventArgs e)
        {
            if (btnHold3.Text == "Roll")
            {
                btnHold3.Text = "Hold";
            }

            else if (btnHold1.Text == "Roll" && btnHold2.Text == "Roll" &&
                    btnHold4.Text == "Roll" && btnHold5.Text == "Roll")
            {
                btnHold3.Text = "Hold";
            }

            else
            {
                btnHold3.Text = "Roll";
            }

        }


        private void btnHold4_Click(object sender, EventArgs e)
        {
            if (btnHold4.Text == "Roll")
            {
                btnHold4.Text = "Hold";
            }

            else if (btnHold1.Text == "Roll" && btnHold2.Text == "Roll" &&
                    btnHold3.Text == "Roll" && btnHold5.Text == "Roll")
            {
                btnHold4.Text = "Hold";
            }

            else
            {
                btnHold4.Text = "Roll";
            }

        }

        private void btnHold5_Click(object sender, EventArgs e)
        {
            if (btnHold5.Text == "Roll")
            {
                btnHold5.Text = "Hold";
            }

            else if (btnHold1.Text == "Roll" && btnHold2.Text == "Roll" &&
                    btnHold3.Text == "Roll" && btnHold4.Text == "Roll")
            {
                btnHold5.Text = "Hold";
            }

            else
            {
                btnHold5.Text = "Roll";
            }

        }

        //0 buttons
        private void btn01_Click(object sender, EventArgs e)
        {
            tbEnen.Text = 0.ToString();
            Volgende();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            tbTweeën.Text = 0.ToString();
            Volgende();
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            tbDrieën.Text = 0.ToString();
            Volgende();
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            tbVieren.Text = 0.ToString();
            Volgende();
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            tbVijven.Text = 0.ToString();
            Volgende();
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            tbZessen.Text = 0.ToString();
            Volgende();
        }

        private void btn0ThreeOfAKind_Click(object sender, EventArgs e)
        {
            tbThreeOfAKind.Text = 0.ToString();
            Volgende();
        }

        private void btn0Carré_Click(object sender, EventArgs e)
        {
            tbCarré.Text = 0.ToString();
            Volgende();
        }

        private void btn0FullHouse_Click(object sender, EventArgs e)
        {
            tbFullHouse.Text = 0.ToString();
            Volgende();
        }

        private void btn0KleineStraat_Click(object sender, EventArgs e)
        {
            tbKleineStraat.Text = 0.ToString();
            Volgende();
        }

        private void btn0GroteStraat_Click(object sender, EventArgs e)
        {
            tbGroteStraat.Text = 0.ToString();
            Volgende();
        }

        private void btn0Yahtzee_Click(object sender, EventArgs e)
        {
            booYahtzee0 = true;
            tbYahtzee.Text = 0.ToString();
            Volgende();
        }

        //Score buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            tbEnen.Text = arrayUitslag[1].ToString();
            Volgende();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbTweeën.Text = (arrayUitslag[2] * 2).ToString();
            Volgende();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbDrieën.Text = (arrayUitslag[3] * 3).ToString();
            Volgende();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbVieren.Text = (arrayUitslag[4] * 4).ToString();
            Volgende();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbVijven.Text = (arrayUitslag[5] * 5).ToString();
            Volgende();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbZessen.Text = (arrayUitslag[6] * 6).ToString();
            Volgende();
        }

        private void btnThreeOfAKind_Click(object sender, EventArgs e)
        {
            tbThreeOfAKind.Text = (arrayUitslag[1] +
                                   arrayUitslag[2] * 2 +
                                   arrayUitslag[3] * 3 +
                                   arrayUitslag[4] * 4 +
                                   arrayUitslag[5] * 5 +
                                   arrayUitslag[6] * 6).ToString();
            Volgende();
        }

        private void btnCarré_Click(object sender, EventArgs e)
        {
            tbCarré.Text = (arrayUitslag[1] +
                            arrayUitslag[2] * 2 +
                            arrayUitslag[3] * 3 +
                            arrayUitslag[4] * 4 +
                            arrayUitslag[5] * 5 +
                            arrayUitslag[6] * 6).ToString();
            Volgende();
        }

        private void btnFullHouse_Click(object sender, EventArgs e)
        {
            tbFullHouse.Text = 25.ToString();
            Volgende();
        }

        private void btnKleineStraat_Click(object sender, EventArgs e)
        {
            tbKleineStraat.Text = 30.ToString();
            Volgende();
        }

        private void btnGroteStraat_Click(object sender, EventArgs e)
        {
            tbGroteStraat.Text = 40.ToString();
            Volgende();
        }

        private void btnYahtzee_Click(object sender, EventArgs e)
        {
            tbYahtzee.Text = 50.ToString();
            booYahtzee = true;
            Volgende();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            tbChance.Text = (arrayUitslag[1] +
                             arrayUitslag[2] * 2 +
                             arrayUitslag[3] * 3 +
                             arrayUitslag[4] * 4 +
                             arrayUitslag[5] * 5 +
                             arrayUitslag[6] * 6).ToString();
            Volgende();
        }

        private void btnYahtzeeBonus_Click(object sender, EventArgs e)
        {
            if(tbYahtzeeBonus.Text == "")
            {
                tbYahtzeeBonus.Text = "0";
            }
            intYahtzeeBonus = Convert.ToInt16(tbYahtzeeBonus.Text);
            intYahtzeeBonus += 100;
            tbYahtzeeBonus.Text = intYahtzeeBonus.ToString();
            btnYahtzeeBonus.Visible = false;
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            Na3Worpen();
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            Volgende();

            lblAantalWorpen.Text = Convert.ToString(3 - intTellerAantalWorpen);

            intRondeTeller = 0;

            booYahtzee = false;
            booYahtzee0 = false;

            btnWerpen.Enabled = true;
            btnVolgende.Visible = false;

            tbBonus.Text = "";
            tbEindScore.Text = "";

            tbEnen.Text = "";
            tbTweeën.Text = "";
            tbDrieën.Text = "";
            tbVieren.Text = "";
            tbVijven.Text = "";
            tbZessen.Text = "";
            tbThreeOfAKind.Text = "";
            tbCarré.Text = "";
            tbFullHouse.Text = "";
            tbKleineStraat.Text = "";
            tbGroteStraat.Text = "";
            tbYahtzee.Text = "";
            tbChance.Text = "";
            tbYahtzeeBonus.Text = "";

            intScoreBovensteHelft = 0;
            intScoreOnderteHelft = 0;
            intTotaalGeneraal = 0;

            for (intTeller = 1; intTeller <= 14; intTeller++)
            {
                arrayScore[intTeller] = 0;
            }
        }



        void Na3Worpen()
        {
            btnHold1.Enabled = false;
            btnHold2.Enabled = false;
            btnHold3.Enabled = false;
            btnHold4.Enabled = false;
            btnHold5.Enabled = false;

            btnWerpen.Enabled = false;
            btnStop.Enabled = false;

            rtbWorp1.Text = arrayWorpen[0].ToString();
            rtbWorp2.Text = arrayWorpen[1].ToString();
            rtbWorp3.Text = arrayWorpen[2].ToString();
            rtbWorp4.Text = arrayWorpen[3].ToString();
            rtbWorp5.Text = arrayWorpen[4].ToString();


            for (intTeller = 1; intTeller <= 5; intTeller++)
            {
                intWaarde = arrayWorpen[intTeller - 1];
                arrayUitslag[intWaarde]++;
            }

            //Bepalen van de score

            for (intTeller = 1; intTeller <= 6; intTeller++)
            {
                //Bepalen van een straat
                if (arrayUitslag[intTeller] >= 1)
                {
                    intStraatTeller++;
                }

                else if (arrayUitslag[intTeller] == 0 && intStraatTeller < 4)
                {
                    intStraatTeller = 0;
                }

                else if (arrayUitslag[intTeller] == 0 && intStraatTeller == 4)
                {
                    booKleineStraat = true;
                }

                //Bepalen van Yahtzee
                if (arrayUitslag[intTeller] == 5)
                {
                    strScore = "Yahtzee";
                }

                //Bepalen van Carré
                if (arrayUitslag[intTeller] == 4)
                {
                    strScore = "Carré";
                }

                //Bepalen 3 of a Kind
                if (arrayUitslag[intTeller] == 3)
                {
                    boo3OfAKind = true;
                }

                //Bepalen 2 of a Kind
                if (arrayUitslag[intTeller] == 2)
                {
                    boo2OfAKind = true;
                }
            }

            if (boo3OfAKind && boo2OfAKind)
            {
                strScore = "Full House";
            }

            else if (intStraatTeller == 5 && booKleineStraat)
            {
                strScore = "Kleine Straat";
            }

            else if (intStraatTeller == 5)
            {
                strScore = "Grote Straat";
            }

            else if (intStraatTeller == 4)
            {
                strScore = "Kleine Straat";
            }

            else if (boo3OfAKind)
            {
                strScore = "Three of a Kind";
            }

            ButtonsTonen();

            return;
        }

        void ButtonsTonen()
        {

            //De score buttons
            if(arrayUitslag[1] > 0 && tbEnen.Text == "")
            {
                btn1.Visible = true;
            }

            if (arrayUitslag[2] > 0 && tbTweeën.Text == "")
            {
                btn2.Visible = true;
            }

            if (arrayUitslag[3] > 0 && tbDrieën.Text == "")
            {
                btn3.Visible = true;
            }

            if (arrayUitslag[4] > 0 && tbVieren.Text == "")
            {
                btn4.Visible = true;
            }

            if (arrayUitslag[5] > 0 && tbVijven.Text == "")
            {
                btn5.Visible = true;
            }

            if (arrayUitslag[6] > 0 && tbZessen.Text == "")
            {
                btn6.Visible = true;
            }

            if (strScore == "Three of a Kind" && tbThreeOfAKind.Text == "")
            {
                btnThreeOfAKind.Visible = true;
            }

            if (strScore == "Carré" && tbCarré.Text == "" && tbThreeOfAKind.Text == "")
            {
                btnCarré.Visible = true;
                btnThreeOfAKind.Visible = true;
            }

            else if(strScore == "Carré" && tbCarré.Text == "" && tbThreeOfAKind.Text != "")
            {
                btnCarré.Visible = true;
            }

            else if(strScore == "Carré" && tbCarré.Text != "" && tbThreeOfAKind.Text == "")
            {
                btnThreeOfAKind.Visible = true;
            }

            if (strScore == "Full House" && tbFullHouse.Text == "" && tbThreeOfAKind.Text == "")
               
            {
                btnFullHouse.Visible = true;
                btnThreeOfAKind.Visible = true;
            }

            else if(strScore == "Full House" && tbFullHouse.Text == "" && tbThreeOfAKind.Text != "")
            {
                btnFullHouse.Visible = true;
            }

            else if(strScore == "Full House" && tbFullHouse.Text != "" && tbThreeOfAKind.Text == "")
            {
                btnThreeOfAKind.Visible = true;
            }
            

            if (strScore == "Kleine Straat" && tbKleineStraat.Text == "" ||
                strScore == "Grote Straat" && tbKleineStraat.Text == "")
            {
                btnKleineStraat.Visible = true;
            }

            if(strScore == "Grote Straat" && tbGroteStraat.Text == "")
            {
                btnGroteStraat.Visible = true;
            }

            if (strScore == "Yahtzee" && tbYahtzee.Text == "")
            {
                btnYahtzee.Visible = true;
            }

            if(tbChance.Text == "")
            {
                btnChange.Visible = true;
            }

            if (strScore == "Yahtzee" && booYahtzee && tbCarré.Text == "" &&
                tbThreeOfAKind.Text == "")
            {
                btnYahtzeeBonus.Visible = true;
                btnCarré.Visible = true;
                btnThreeOfAKind.Visible = true;
            }

            else if(strScore == "Yahtzee" && booYahtzee && tbCarré.Text == "" &&
                    tbThreeOfAKind.Text != "")
            {
                btnYahtzeeBonus.Visible = true;
                btnCarré.Visible = true;
            }

            else if (strScore == "Yahtzee" && booYahtzee && tbCarré.Text != "" &&
                     tbThreeOfAKind.Text == "")
            {
                btnYahtzeeBonus.Visible = true;
                btnThreeOfAKind.Visible = true;
            }

            else if (strScore == "Yahtzee" && booYahtzee && tbCarré.Text == "" &&
                     tbThreeOfAKind.Text != "")
            {
                btnYahtzeeBonus.Visible = true;
            }

            if(strScore == "Yahtzee" && booYahtzee0 && tbCarré.Text == "" && tbThreeOfAKind.Text == "")
            {
                btnThreeOfAKind.Visible = true;
                btnCarré.Visible = true;
            }

            else if(strScore == "Yahtzee" && booYahtzee0 && tbCarré.Text == "" &&
                    tbThreeOfAKind.Text != "")
            {
                btnCarré.Visible = true;
            }

            else if(strScore == "Yahtzee" && booYahtzee0 && tbCarré.Text != "" &&
                    tbThreeOfAKind.Text == "")
            {
                btnThreeOfAKind.Visible = true;
            }
            //De 0 buttons
            if (tbEnen.Text == "" && !btn1.Visible)
            {
                btn01.Visible = true;
            }

            if (tbTweeën.Text == "" && !btn2.Visible)
            {
                btn02.Visible = true;
            }

            if (tbDrieën.Text == "" && !btn3.Visible)
            {
                btn03.Visible = true;
            }

            if (tbVieren.Text == "" && !btn4.Visible)
            {
                btn04.Visible = true;
            }

            if (tbVijven.Text == "" && !btn5.Visible)
            {
                btn05.Visible = true;
            }

            if (tbZessen.Text == "" && !btn6.Visible)
            {
                btn06.Visible = true;
            }

            if (tbThreeOfAKind.Text == "" && !btnThreeOfAKind.Visible)
            {
                btn0ThreeOfAKind.Visible = true;
            }

            if (tbCarré.Text == "" && !btnCarré.Visible)
            {
                btn0Carré.Visible = true;
            }

            if (tbFullHouse.Text == "" && !btnFullHouse.Visible)
            {
                btn0FullHouse.Visible = true;
            }

            if (tbKleineStraat.Text == "" && !btnKleineStraat.Visible)
            {
                btn0KleineStraat.Visible = true;
            }

            if (tbGroteStraat.Text == "" && !btnGroteStraat.Visible)
            {
                btn0GroteStraat.Visible = true;
            }

            if (tbYahtzee.Text == "" && !btnYahtzee.Visible)
            {
                btn0Yahtzee.Visible = true;
            }


        }

        void ButtonsNietTonen()
        {
            //0 buttons
            btn01.Visible = false;
            btn02.Visible = false;
            btn03.Visible = false;
            btn04.Visible = false;
            btn05.Visible = false;
            btn06.Visible = false;
            btn0ThreeOfAKind.Visible = false;
            btn0Carré.Visible = false;
            btn0FullHouse.Visible = false;
            btn0KleineStraat.Visible = false;
            btn0GroteStraat.Visible = false;
            btn0Yahtzee.Visible = false;

            //Score buttons
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;
            btnThreeOfAKind.Visible = false;
            btnCarré.Visible = false;
            btnFullHouse.Visible = false;
            btnKleineStraat.Visible = false;
            btnGroteStraat.Visible = false;
            btnYahtzee.Visible = false;
            btnChange.Visible = false;
            btnYahtzeeBonus.Visible = false;


        }

    void Volgende()
        {
            intRondeTeller++;

            intTellerAantalWorpen = 0;



            intStraatTeller = 0;

            ButtonsNietTonen();

            boo3OfAKind = false;
            boo2OfAKind = false;
            booKleineStraat = false;

            btnWerpen.Enabled = true;
            btnStop.Enabled = false;

            for (intTeller = 1; intTeller <= 6; intTeller++)
            {
                arrayUitslag[intTeller] = 0;
            }

            strScore = "";

            rtbWorp1.Text = "";
            rtbWorp2.Text = "";
            rtbWorp3.Text = "";
            rtbWorp4.Text = "";
            rtbWorp5.Text = "";

            btnHold1.Text = "Hold";
            btnHold2.Text = "Hold";
            btnHold3.Text = "Hold";
            btnHold4.Text = "Hold";
            btnHold5.Text = "Hold";

            if (intRondeTeller == 13)
            {
                EindeSpel();
            }

            if(intRondeTeller < 13)
            {
                lblAantalWorpen.Text = Convert.ToString(3 - intTellerAantalWorpen);
            }

            return;

        }
    void EindeSpel()
        {
            if (tbYahtzeeBonus.Text == "")
            {
                tbYahtzeeBonus.Text = "0";
            }


            arrayScore[1] = Convert.ToInt16(tbEnen.Text);
            arrayScore[2] = Convert.ToInt16(tbTweeën.Text);
            arrayScore[3] = Convert.ToInt16(tbDrieën.Text);
            arrayScore[4] = Convert.ToInt16(tbVieren.Text);
            arrayScore[5] = Convert.ToInt16(tbVijven.Text);
            arrayScore[6] = Convert.ToInt16(tbZessen.Text);
            arrayScore[7] = Convert.ToInt16(tbThreeOfAKind.Text);
            arrayScore[8] = Convert.ToInt16(tbCarré.Text);
            arrayScore[9] = Convert.ToInt16(tbFullHouse.Text);
            arrayScore[10] = Convert.ToInt16(tbKleineStraat.Text);
            arrayScore[11] = Convert.ToInt16(tbGroteStraat.Text);
            arrayScore[12] = Convert.ToInt16(tbYahtzee.Text);
            arrayScore[13] = Convert.ToInt16(tbChance.Text);
            arrayScore[14] = Convert.ToInt16(tbYahtzeeBonus.Text);

            for(intTeller = 1; intTeller <= 6; intTeller++)
            {
                intScoreBovensteHelft += arrayScore[intTeller];
            }

            if (intScoreBovensteHelft >= 63)
            {
                intScoreBovensteHelft += 35;
                tbBonus.Text = 35.ToString();
            }

            for(intTeller = 7; intTeller <= 14; intTeller++)
            {
                intScoreOnderteHelft += arrayScore[intTeller];
            }

            intTotaalGeneraal = intScoreBovensteHelft + intScoreOnderteHelft;

            tbEindScore.Text = intTotaalGeneraal.ToString();

            btnWerpen.Enabled = false;

            btnVolgende.Visible = true;

            return;
        }
    }
}
