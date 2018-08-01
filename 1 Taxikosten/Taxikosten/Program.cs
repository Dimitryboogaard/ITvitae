using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxikosten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instellen van de kleuren
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            //Declareren van de variabelen
            const double cdbKmPrijs = 1.00, cdbMinuutPrijsLaag = 0.25, cdbMinuutPrijsHoog = 0.45,
                         cdbWeekendToeslag = 15;
            DateTime dteStartDatum, dteEindDatum, dteStartTijd, dteEindTijd, dteStartDatumEnTijd,
                     dteEindDatumEnTijd, dteMidderNachtEersteDag, dteMidderNachtLaatsteDag,
                     dteReisInMinuten;
            int intWelkeDag, intDuurInMinuten = 0, intAantalKm, intTeller, intAantalVolleDagen,
                intWelkUur;
            double dblTotaalKosten = 0, dblKmPerMinuut;

            //Invoeren van de gegevens
            Console.Write("Geef de startdatum op (dd:mm) ");
            dteStartDatum = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Geef de starttijd op (hh:mm): ");
            dteStartTijd = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Geef de einddatum op (dd:mm): ");
            dteEindDatum = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Geef de eindtijd op (hh:mm): ");
            dteEindTijd = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Geef het aantal gereden kilometers op: ");
            intAantalKm = Convert.ToInt16(Console.ReadLine());


            //Samenvoegen van begindatum en begintijd + einddatum en eindtijd
            dteStartDatumEnTijd = new DateTime(dteStartDatum.Year, dteStartDatum.Month, dteStartDatum.Day, dteStartTijd.Hour, dteStartTijd.Minute, 00);
            dteEindDatumEnTijd = new DateTime(dteEindDatum.Year, dteEindDatum.Month, dteEindDatum.Day, dteEindTijd.Hour, dteEindTijd.Minute, 00);

            //Middernacht invullen
            dteMidderNachtEersteDag = new DateTime(dteStartDatumEnTijd.Year, dteStartDatumEnTijd.Month, dteStartDatumEnTijd.Day + 1, 0, 0, 0);
            dteMidderNachtLaatsteDag = new DateTime(dteEindDatumEnTijd.Year, dteEindDatumEnTijd.Month, dteEindDatumEnTijd.Day, 0, 0, 0);

            //Controle op samenvoegen
            Console.WriteLine("Startdatum en tijd: " + dteStartDatumEnTijd.ToString());
            Console.WriteLine("Eindatum en tijd: " + dteEindDatumEnTijd.ToString());

            //Bepalen van de duur in minuten
            intAantalVolleDagen = dteEindDatumEnTijd.DayOfYear - dteStartDatumEnTijd.DayOfYear - 1;

            //Controle op aantal volle dagen
            Console.WriteLine("Aantal volle dagen: " + intAantalVolleDagen);

            if(intAantalVolleDagen >= 1)
            {
                intDuurInMinuten += intAantalVolleDagen * 1440;
                intDuurInMinuten += dteMidderNachtEersteDag.Subtract(dteStartDatumEnTijd).Hours * 60;
                intDuurInMinuten += dteEindDatumEnTijd.Subtract(dteMidderNachtLaatsteDag).Hours * 60;
                intDuurInMinuten += dteMidderNachtEersteDag.Subtract(dteStartDatumEnTijd).Minutes;
                intDuurInMinuten += dteEindDatumEnTijd.Subtract(dteMidderNachtLaatsteDag).Minutes;
            }

            else if(intAantalVolleDagen == 0)
            {
                intDuurInMinuten += dteMidderNachtEersteDag.Subtract(dteStartDatumEnTijd).Hours * 60;
                intDuurInMinuten += dteEindDatumEnTijd.Subtract(dteMidderNachtLaatsteDag).Hours * 60;
                intDuurInMinuten += dteMidderNachtEersteDag.Subtract(dteStartDatumEnTijd).Minutes;
                intDuurInMinuten += dteEindDatumEnTijd.Subtract(dteMidderNachtLaatsteDag).Minutes;
            }

            else if(intAantalVolleDagen == -1)
            {
                intDuurInMinuten += dteEindDatumEnTijd.Subtract(dteStartDatumEnTijd).Hours * 60;
                intDuurInMinuten += dteEindDatumEnTijd.Subtract(dteStartDatumEnTijd).Minutes; 
            }

            //Controle op aantal minuten
            Console.WriteLine("Aantal minuten: " + intDuurInMinuten);

            //Aantal kilometers per minuut
            dblKmPerMinuut = intAantalKm / intDuurInMinuten;

            //Reis maken in minuten
            dteReisInMinuten = new DateTime(dteStartDatumEnTijd.Year, dteStartDatumEnTijd.Month, 
                                            dteStartDatumEnTijd.Day, dteStartDatumEnTijd.Hour, 
                                            dteStartDatumEnTijd.Minute, 00);
            
            for(intTeller = 1; intTeller <= intDuurInMinuten; intTeller++)
            {
                //Welk uur bepalen
                intWelkUur = (int)dteReisInMinuten.Hour;

                //Dag van de week bepalen
                intWelkeDag = (int)dteReisInMinuten.DayOfWeek;
               
                //Controle welke dag, uur en datum en tijd
                Console.Write(intWelkeDag + " " + intWelkUur + " " + dteReisInMinuten.ToString() + " ");
                

                //Maandag van 00:00 tot 08:00
                if (0 <= intWelkUur && intWelkUur < 8 && intWelkeDag == 1)
                {
                    dblTotaalKosten += cdbMinuutPrijsHoog * (1 + cdbWeekendToeslag / 100);
                    dblTotaalKosten += dblKmPerMinuut * cdbKmPrijs * (1 + cdbWeekendToeslag / 100);
                    Console.WriteLine(dblTotaalKosten);
                }

                //Dinsdag t/m vrijdag van 00:00 tot 08:00
                else if (0 <= intWelkUur && intWelkUur < 8 && 2 <= intWelkeDag && intWelkeDag <= 5)
                {
                    dblTotaalKosten += cdbMinuutPrijsHoog;
                    dblTotaalKosten += dblKmPerMinuut * cdbKmPrijs;

                    Console.WriteLine(dblTotaalKosten);

                }

                //Maandag t/m vrijdag van 08:00 tot 18:00
                else if (8 <= intWelkUur && intWelkUur < 18 && 1 <= intWelkeDag && intWelkeDag <= 5)
                {
                    dblTotaalKosten += cdbMinuutPrijsLaag;
                    dblTotaalKosten += dblKmPerMinuut * cdbKmPrijs;
                    Console.WriteLine(dblTotaalKosten);

                }
                //Maandag t/m donderdag van 18:00 tot 00:00
                else if(18 <= intWelkUur && intWelkUur < 24 && 1 <= intWelkeDag && intWelkeDag <= 4)
                {
                    dblTotaalKosten += cdbMinuutPrijsHoog;
                    dblTotaalKosten += dblKmPerMinuut * cdbKmPrijs;
                    Console.WriteLine(dblTotaalKosten);

                }

                //Vrijdag van 18:00 tot 22:00
                else if(18 <= intWelkUur && intWelkUur < 22 && intWelkeDag == 5)
                {
                    dblTotaalKosten += cdbMinuutPrijsHoog;
                    dblTotaalKosten += dblKmPerMinuut * cdbKmPrijs;
                    Console.WriteLine(dblTotaalKosten);

                }

                //Vrijdag van 22:00 tot 00:00
                else if(22 <= intWelkUur && intWelkUur < 24 && intWelkeDag == 5)
                {
                    dblTotaalKosten += cdbMinuutPrijsHoog * (1 + cdbWeekendToeslag / 100);
                    dblTotaalKosten += dblKmPerMinuut * cdbKmPrijs * (1 + cdbWeekendToeslag / 100);

                    Console.WriteLine(dblTotaalKosten);

                }

                //Zaterdag en zondag van 00:00 tot 08:00
                if (0 <= intWelkUur && intWelkUur < 8 && (intWelkeDag == 6 || intWelkeDag == 0))
                {
                    dblTotaalKosten += cdbMinuutPrijsHoog * (1 + cdbWeekendToeslag / 100);
                    dblTotaalKosten += dblKmPerMinuut * cdbKmPrijs * (1 + cdbWeekendToeslag / 100);

                    Console.WriteLine(dblTotaalKosten);

                }

                //Zaterdag en zondag van 08:00 tot 18:00
                if (8 <= intWelkUur && intWelkUur < 18 && (intWelkeDag == 6 || intWelkeDag == 0))

                {
                    dblTotaalKosten += cdbMinuutPrijsLaag* (1 + cdbWeekendToeslag / 100);
                    dblTotaalKosten += dblKmPerMinuut * cdbKmPrijs * (1 + cdbWeekendToeslag / 100);

                    Console.WriteLine(dblTotaalKosten);

                }

                //Zaterdag en zondag van 18:00 tot 00:00
                if (18 <= intWelkUur && intWelkUur < 24  && (intWelkeDag == 6 || intWelkeDag == 0))
                {
                    dblTotaalKosten += cdbMinuutPrijsHoog * (1 + cdbWeekendToeslag / 100);
                    dblTotaalKosten += dblKmPerMinuut * cdbKmPrijs * (1 + cdbWeekendToeslag / 100);

                    Console.WriteLine(dblTotaalKosten);

                }

                //Een minuut optellen
                dteReisInMinuten = dteReisInMinuten.AddMinutes(1);

               

            }

            Console.WriteLine("Kosten: " + Math.Round(dblTotaalKosten, 2));
            
            Console.ReadKey();
        }
    }
}
