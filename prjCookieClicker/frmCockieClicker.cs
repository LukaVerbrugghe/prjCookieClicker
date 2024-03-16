using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCookieClicker
{
    public partial class frmCockieClicker : Form
    {
        //algemeen
        float floatAantalKinderen = 0;
        float floatAantalKinderenPerSeconde = 0;

        //stats
        float floatTotaalAantalKeerGeklikt = 0;
        float floatTotaalAutomatischGeproduceerd = 0;
        float floatCPS = 0;
        float floatKliksDezeSeconde = 0;
        float floatMaxCPS = 0;

        //upgrades
        float floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs = 150;
        float floatVereisteKinderenUpgrade1VerdundKippenvoerExtraKinderenPerSeconde = 1;

        float floatVereisteKinderenUpgrade2EastereggPrijs = 500;
        float floatVereisteKinderenUpgrade2EastereggExtraKinderenPerSeconde = 1.5f;

        float floatVereisteKinderenUpgrade3KippenhekPrijs = 2000;
        float floatVereisteKinderenUpgrade3KippenhekExtraKinderenPerSeconde = 3;

        //advancements
        bool advancement1Bereikt = false;
        bool advancement2Bereikt = false;
        bool advancement3Bereikt = false;
        bool advancement4Bereikt = false;
        bool advancement5Bereikt = false;
        bool advancement6Bereikt = false;
        bool advancement7Bereikt = false;
        bool advancement8Bereikt = false;
        bool advancement9Bereikt = false;
        bool advancement10Bereikt = false;
        bool advancement11Bereikt = false;
        bool advancement12Bereikt = false;
        bool advancement13Bereikt = false;
        bool advancement14Bereikt = false;
        bool advancement15Bereikt = false;
        bool advancement16Bereikt = false;

        bool advancement1Shown = false;
        bool advancement2Shown = false;
        bool advancement3Shown = false;
        bool advancement4Shown = false;
        bool advancement5Shown = false;
        bool advancement6Shown = false;
        bool advancement7Shown = false;
        bool advancement8Shown = false;
        bool advancement9Shown = false;
        bool advancement10Shown = false;
        bool advancement11Shown = false;
        bool advancement12Shown = false;
        bool advancement13Shown = false;
        bool advancement14Shown = false;
        bool advancement15Shown = false;
        bool advancement16Shown = false;

        public frmCockieClicker()
        {
            InitializeComponent();
            tmrAnimatie.Start();
            tmrCPS.Start();
            tmrExtraKinderen.Start();
            UpdateScherm();
        }



        private void picCock_MouseDown(object sender, MouseEventArgs e)
        {
            //er is op de cock geklikt
            floatAantalKinderen++;
            floatKliksDezeSeconde++;

            floatTotaalAantalKeerGeklikt++;
            UpdateScherm();
            //checken of er al 1000 keer geklikt is (advancement)
            if (floatTotaalAantalKeerGeklikt == 1000)
            {
                advancement1Bereikt = true;
            }
        }

        /// <summary>
        /// Per upgrade is er een functie omdat de functie kan worden opgeroepen door zowel op de picturebox als de labels kan duwen om de upgrade te kopen.
        /// </summary>


        //upgrade 1
        private void picUpgrade1VerdundKippenvoer_Click(object sender, EventArgs e)
        {
            KoopUpgrade1();
        }

        private void lblUpgrade1VerdundKippenvoer_Click(object sender, EventArgs e)
        {
            KoopUpgrade1();
        }

        private void lblUpgrade1VerdundKippenvoerPrijs_Click(object sender, EventArgs e)
        {
            KoopUpgrade1();
        }
        private void lblUpgrade1VerdundKippenvoerKinderenPerSeconde_Click(object sender, EventArgs e)
        {
            KoopUpgrade1();
        }

        //functie om de upgrade te kopen
        private void KoopUpgrade1()
        {
            if (IsUpgradeBeschikbaar(floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs))
            {
                //verdund kippenvoer gekocht
                floatAantalKinderen = floatAantalKinderen - floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs;
                floatAantalKinderenPerSeconde = floatAantalKinderenPerSeconde + floatVereisteKinderenUpgrade1VerdundKippenvoerExtraKinderenPerSeconde;
                //prijs verhogen
                floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs = floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs * 1.2f;
                UpdateScherm();
            }

        }

        //upgrade 2
        private void picUpgrade2Easteregg_Click(object sender, EventArgs e)
        {
            KoopUpgrade2();
        }

        private void lblUpgrade2Easteregg_Click(object sender, EventArgs e)
        {
            KoopUpgrade2();
        }

        private void lblUpgrade2EastereggPrijs_Click(object sender, EventArgs e)
        {
            KoopUpgrade2();
        }

        private void lblUpgrade2EastereegExtraKinderenPerSeconde_Click(object sender, EventArgs e)
        {
            KoopUpgrade2();
        }

        private void KoopUpgrade2()
        {
            if (IsUpgradeBeschikbaar(floatVereisteKinderenUpgrade2EastereggPrijs))
            {
                //easteregg gekocht
                floatAantalKinderen = floatAantalKinderen - floatVereisteKinderenUpgrade2EastereggPrijs;
                floatAantalKinderenPerSeconde = floatAantalKinderenPerSeconde + floatVereisteKinderenUpgrade2EastereggExtraKinderenPerSeconde;
                //prijs verhogen
                floatVereisteKinderenUpgrade2EastereggPrijs = floatVereisteKinderenUpgrade2EastereggPrijs * 1.2f;
                UpdateScherm();
            }
        }

        //upgrade 3

        private void KoopUpgrade3()
        {
            if (IsUpgradeBeschikbaar(floatVereisteKinderenUpgrade3KippenhekPrijs))
            {
                //kippenhek gekocht
                floatAantalKinderen = floatAantalKinderen - floatVereisteKinderenUpgrade3KippenhekPrijs;
                floatAantalKinderenPerSeconde = floatAantalKinderenPerSeconde + floatVereisteKinderenUpgrade3KippenhekExtraKinderenPerSeconde;
                //prijs verhogen
                floatVereisteKinderenUpgrade3KippenhekPrijs = floatVereisteKinderenUpgrade3KippenhekPrijs * 1.2f;
                UpdateScherm();
            }
        }



        //functie om te checken of de upgrade nog beschikbaar is
        private bool IsUpgradeBeschikbaar(float floatVereisteKinderen)
        {
            if (floatAantalKinderen >= floatVereisteKinderen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //functie om labels te updaten
        private void UpdateScherm()
        {
            //algemeen
            lblAantalKinderen.Text = "Aantal kinderen: " + Convert.ToString(Math.Round(floatAantalKinderen, 1));
            lblKinderenPerSeconde.Text = "Kinderen per seconde: " + floatAantalKinderenPerSeconde.ToString();

            //upgrades
            //upgrade 1
            lblUpgrade1VerdundKippenvoerPrijs.Text = "Prijs: " + Convert.ToString(Math.Round(floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs, 1));
            //kleur van de label aanpassen om aan te tonen of het product wel of niet gekocht kan worden
            if (IsUpgradeBeschikbaar(floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs))
            {
                lblUpgrade1VerdundKippenvoer.ForeColor = Color.Green;
            }
            else
            {
                lblUpgrade1VerdundKippenvoer.ForeColor = Color.Red;
            }
            //upgrade 2
            lblUpgrade2EastereggPrijs.Text = "Prijs: " + Convert.ToString(Math.Round(floatVereisteKinderenUpgrade2EastereggPrijs, 1));
            //kleur van de label aanpassen om aan te tonen of het product wel of niet gekocht kan worden
            if (IsUpgradeBeschikbaar(floatVereisteKinderenUpgrade2EastereggPrijs))
            {
                lblUpgrade2Easteregg.ForeColor = Color.Green;
            }
            else
            {
                lblUpgrade2Easteregg.ForeColor = Color.Red;
            }
            //upgrade 3
            lblUpgrade3KippenhekPrijs.Text = "Prijs: " + Convert.ToString(Math.Round(floatVereisteKinderenUpgrade3KippenhekPrijs, 1));
            //kleur van de label aanpassen om aan te tonen of het product wel of niet gekocht kan worden
            if (IsUpgradeBeschikbaar(floatVereisteKinderenUpgrade3KippenhekPrijs))
            {
                lblUpgrade3Kippenhek.ForeColor = Color.Green;
            }
            else
            {
                lblUpgrade3Kippenhek.ForeColor = Color.Red;
            }

            //stats
            lblTotaalAantalKliks.Text = "Aantal keer geklikt: " + Convert.ToString(Math.Round(floatTotaalAantalKeerGeklikt, 1));
            lblTotaalAutomatischGeproduceerd.Text = "Automatisch geproduceerd: " + Convert.ToString(Math.Round(floatTotaalAutomatischGeproduceerd, 1));
            lblCPS.Text = "CPS: " + Convert.ToString(floatCPS) + " kliks per second";
            lblMaxCPS.Text = "Max CPS: " + Convert.ToString(Math.Round(floatMaxCPS, 1)) + " kliks per second";

            //advancements
            if (advancement1Bereikt && !advancement1Shown)
            {
                advancement1Shown = true;
                MessageBox.Show("U heeft al 1000 keer op de cock geklikt. Misschien is het een goed idee om eventjes naar buiten te gaan en gras aan te raken.", "Advancement: No life");
                picAdvancement1.Image = Properties.Resources.nolife;
            }
            if (advancement2Bereikt && !advancement2Shown)
            {
                advancement2Shown = true;
                MessageBox.Show("U heeft al 1000 kinderen automatisch geproduceerd zonder ook maar een vinger uit te steken.", "Advancement: Lazy");
                picAdvancement2.Image = Properties.Resources.lazy;
            }
            if (advancement3Bereikt && !advancement3Shown)
            {
                advancement3Shown = true;
                MessageBox.Show("U heeft 10 keer geklikt in 1 seconde. Gebruik je een autoclicker?", "Advancement: Autoclicker");
                picAdvancement3.Image = Properties.Resources.CPS;
            }
            if (advancement4Bereikt && !advancement4Shown)
            {
                advancement4Shown = true;
                MessageBox.Show("Chirp chirp, ik ben het geheime achievement kuiken.", "Advancement: Geheime achievement");
                picAdvancement4.Image = Properties.Resources.secrept;
            }
        }




        private void tmrExtraKinderen_Tick(object sender, EventArgs e)
        {
            //er is 1/10e seconde gepasseerd
            //aantal kinderen verhogen
            floatAantalKinderen = floatAantalKinderen + floatAantalKinderenPerSeconde / 10;
            floatTotaalAutomatischGeproduceerd += floatAantalKinderenPerSeconde / 10;

            //checken voor advancement
            if (floatTotaalAutomatischGeproduceerd >= 1000)
            {
                advancement2Bereikt = true;
            }
            UpdateScherm();
        }

        private void tmrAnimatie_Tick(object sender, EventArgs e)
        {
            //animatie
            ///Summary
            ///Nog afwerken
            ///Hier komt de code voor de animatie

        }

        private void tmrCPS_Tick(object sender, EventArgs e)
        {
            //CPS updaten
            floatCPS = floatKliksDezeSeconde;
            floatKliksDezeSeconde = 0;

            //checken voor advancement
            if (floatCPS >= 10)
            {
                advancement3Bereikt = true;
            }

            //checken voor max cps
            if (floatCPS > floatMaxCPS)
            {
                floatMaxCPS = floatCPS;
            }
            UpdateScherm();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //messegebox met uitleg weergeven
            MessageBox.Show("Klik op de cock om kinderen te produceren.\nKoop met kinderen upgrades om de kinderproductie te automatiseren.\n\nNaast een upgrade staat telkens de prijs. Wanneer de upgrade groen wordt kan je deze kopen. Je kan een upgrade kopen door op de foto of tekst te klikken. Een upgrade wordt duurder per keer dat je deze koopt.\n\nEr zijn in het spel 16 achievements. Haal jij ze allemaal?\n\nLinksonder zie je je stats.", "Help");
        }

        private void picKind_Click(object sender, EventArgs e)
        {
            advancement4Bereikt = true;
        }
    }
}
