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
        float floatUpgrade1Prijs = 10;
        float floatUpgrade1ExtraKinderenPerSeconde = 1;

        float floatUpgrade2Prijs = 10;
        float floatUpgrade2ExtraKinderenPerSeconde = 1.5f;

        float floatUpgrade3Prijs = 2;
        float floatUpgrade3ExtraKinderenPerSeconde = 3;

        float floatUpgrade4Prijs = 1;
        float floatUpgrade4ExtraKinderenPerSeconde = 10;

        float floatUpgrade5Prijs = 2;
        float floatUpgrade5ExtraKinderenPerSeconde = 20;

        float floatUpgrade6Prijs = 1;
        float floatUpgrade6ExtraKinderenPerSeconde = 100;

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

        //boerderij
        float floatUpgrade1Aantal = 0;
        float floatUpgrade2Aantal = 0;
        float floatUpgrade3Aantal = 0;
        float floatUpgrade4Aantal = 0;
        float floatUpgrade5Aantal = 0;
        float floatUpgrade6Aantal = 0;

        float floatUpgrade1KinderenPerSeconde = 0;
        float floatUpgrade2KinderenPerSeconde = 0;
        float floatUpgrade3KinderenPerSeconde = 0;
        float floatUpgrade4KinderenPerSeconde = 0;
        float floatUpgrade5KinderenPerSeconde = 0;
        float floatUpgrade6KinderenPerSeconde = 0;

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
            //checken of er al 10000 keer geklikt is (advancement)
            if (floatTotaalAantalKeerGeklikt == 10000)
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
            if (IsUpgradeBeschikbaar(floatUpgrade1Prijs))
            {
                //verdund kippenvoer gekocht
                floatAantalKinderen = floatAantalKinderen - floatUpgrade1Prijs;
                floatAantalKinderenPerSeconde = floatAantalKinderenPerSeconde + floatUpgrade1ExtraKinderenPerSeconde;
                //prijs verhogen
                floatUpgrade1Prijs = floatUpgrade1Prijs * 1.2f;

                floatUpgrade1Aantal++;
                floatUpgrade1KinderenPerSeconde = floatUpgrade1KinderenPerSeconde + floatUpgrade1ExtraKinderenPerSeconde;

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
            if (IsUpgradeBeschikbaar(floatUpgrade2Prijs))
            {
                //easteregg gekocht
                floatAantalKinderen = floatAantalKinderen - floatUpgrade2Prijs;
                floatAantalKinderenPerSeconde = floatAantalKinderenPerSeconde + floatUpgrade2ExtraKinderenPerSeconde;
                //prijs verhogen
                floatUpgrade2Prijs = floatUpgrade2Prijs * 1.2f;

                floatUpgrade2Aantal++;
                floatUpgrade2KinderenPerSeconde = floatUpgrade2KinderenPerSeconde + floatUpgrade2ExtraKinderenPerSeconde;

                UpdateScherm();
            }
        }

        //upgrade 3
        private void picUpgrade3Kippenhek_Click(object sender, EventArgs e)
        {
            KoopUpgrade3();
        }

        private void lblUpgrade3Kippenhek_Click(object sender, EventArgs e)
        {
            KoopUpgrade3();
        }

        private void lblUpgrade3KippenhekPrijs_Click(object sender, EventArgs e)
        {
            KoopUpgrade3();
        }

        private void lblUpgrade3KippenhekExtraKinderenPerSeconde_Click(object sender, EventArgs e)
        {
            KoopUpgrade3();
        }

        private void KoopUpgrade3()
        {
            if (IsUpgradeBeschikbaar(floatUpgrade3Prijs))
            {
                //kippenhek gekocht
                floatAantalKinderen = floatAantalKinderen - floatUpgrade3Prijs;
                floatAantalKinderenPerSeconde = floatAantalKinderenPerSeconde + floatUpgrade3ExtraKinderenPerSeconde;
                //prijs verhogen
                floatUpgrade3Prijs = floatUpgrade3Prijs * 1.2f;

                floatUpgrade3Aantal++;
                floatUpgrade3KinderenPerSeconde = floatUpgrade3KinderenPerSeconde + floatUpgrade3ExtraKinderenPerSeconde;

                UpdateScherm();
            }
        }

        //upgrade 4
        private void picUpgrade4VerwarmdKippenhok_Click(object sender, EventArgs e)
        {
            KoopUpgrade4();
        }

        private void lblUpgrade4VerwarmdKippenhok_Click(object sender, EventArgs e)
        {
            KoopUpgrade4();
        }

        private void lblUpgrade4VerwarmdKippenhokPrijs_Click(object sender, EventArgs e)
        {
            KoopUpgrade4();
        }

        private void lblUpgrade4VerwarmdKippenhokExtraKinderenPerSeconde_Click(object sender, EventArgs e)
        {
            KoopUpgrade4();
        }

        private void KoopUpgrade4()
        {
            if (IsUpgradeBeschikbaar(floatUpgrade4Prijs))
            {
                floatAantalKinderen = floatAantalKinderen - floatUpgrade4Prijs;
                floatAantalKinderenPerSeconde = floatAantalKinderenPerSeconde + floatUpgrade4ExtraKinderenPerSeconde;

                floatUpgrade4Prijs = floatUpgrade4Prijs * 1.2f;

                floatUpgrade4Aantal++;
                floatUpgrade4KinderenPerSeconde = floatUpgrade4KinderenPerSeconde + floatUpgrade4ExtraKinderenPerSeconde;

                UpdateScherm();
            }
        }

        //upgrade 5
        private void picUpgrade5ElektrischKippenpoortje_Click(object sender, EventArgs e)
        {
            KoopUpgrade5();
        }

        private void lblUpgrade5ElektrischKippenpoortje_Click(object sender, EventArgs e)
        {
            KoopUpgrade5();
        }

        private void lblUpgrade5ElektrischKippenpoortjePrijs_Click(object sender, EventArgs e)
        {
            KoopUpgrade5();
        }

        private void lblUpgrade5ElektrischKippenpoortjeExtraKinderenPerSeconde_Click(object sender, EventArgs e)
        {
            KoopUpgrade5();
        }

        private void KoopUpgrade5()
        {
            if (IsUpgradeBeschikbaar(floatUpgrade5Prijs))
            {
                floatAantalKinderen = floatAantalKinderen - floatUpgrade5Prijs;
                floatAantalKinderenPerSeconde = floatAantalKinderenPerSeconde + floatUpgrade5ExtraKinderenPerSeconde;

                floatUpgrade5Prijs = floatUpgrade5Prijs * 1.2f;

                floatUpgrade5Aantal++;
                floatUpgrade5KinderenPerSeconde = floatUpgrade5KinderenPerSeconde + floatUpgrade5ExtraKinderenPerSeconde;

                UpdateScherm();
            }
        }

        //upgrade 6
        private void picUpgrade6Hormonen_Click(object sender, EventArgs e)
        {
            KoopUpgrade6();
        }

        private void lblUpgrade6Hormonen_Click(object sender, EventArgs e)
        {
            KoopUpgrade6();
        }

        private void lblUpgrade6HormonenPrijs_Click(object sender, EventArgs e)
        {
            KoopUpgrade6();
        }

        private void lblUpgrade6HormonenExtraKinderenPerSeconde_Click(object sender, EventArgs e)
        {
            KoopUpgrade6();
        }

        private void KoopUpgrade6()
        {
            if (IsUpgradeBeschikbaar(floatUpgrade6Prijs))
            {
                floatAantalKinderen = floatAantalKinderen - floatUpgrade6Prijs;
                floatAantalKinderenPerSeconde = floatAantalKinderenPerSeconde + floatUpgrade6ExtraKinderenPerSeconde;

                floatUpgrade6Prijs = floatUpgrade6Prijs * 1.2f;

                floatUpgrade6Aantal++;
                floatUpgrade6KinderenPerSeconde = floatUpgrade6KinderenPerSeconde + floatUpgrade6ExtraKinderenPerSeconde;

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
            lblUpgrade1VerdundKippenvoerPrijs.Text = "Prijs: " + Convert.ToString(Math.Round(floatUpgrade1Prijs, 1));
            if (IsUpgradeBeschikbaar(floatUpgrade1Prijs))
            {
                lblUpgrade1VerdundKippenvoer.ForeColor = Color.Green;
            }
            else
            {
                lblUpgrade1VerdundKippenvoer.ForeColor = Color.Red;
            }
            //upgrade 2
            lblUpgrade2EastereggPrijs.Text = "Prijs: " + Convert.ToString(Math.Round(floatUpgrade2Prijs, 1));
            if (IsUpgradeBeschikbaar(floatUpgrade2Prijs))
            {
                lblUpgrade2Easteregg.ForeColor = Color.Green;
            }
            else
            {
                lblUpgrade2Easteregg.ForeColor = Color.Red;
            }
            //upgrade 3
            lblUpgrade3KippenhekPrijs.Text = "Prijs: " + Convert.ToString(Math.Round(floatUpgrade3Prijs, 1));
            if (IsUpgradeBeschikbaar(floatUpgrade3Prijs))
            {
                lblUpgrade3Kippenhek.ForeColor = Color.Green;
            }
            else
            {
                lblUpgrade3Kippenhek.ForeColor = Color.Red;
            }
            //upgrade 4
            lblUpgrade4VerwarmdKippenhokPrijs.Text = "Prijs: " + Convert.ToString(Math.Round(floatUpgrade4Prijs, 1));
            if (IsUpgradeBeschikbaar(floatUpgrade4Prijs))
            {
                lblUpgrade4VerwarmdKippenhok.ForeColor = Color.Green;
            }
            else
            {
                lblUpgrade4VerwarmdKippenhok.ForeColor = Color.Red;
            }
            //upgrade 5
            lblUpgrade5ElektrischKippenpoortjePrijs.Text = "Prijs: " + Convert.ToString(Math.Round(floatUpgrade5Prijs, 1));
            if (IsUpgradeBeschikbaar(floatUpgrade5Prijs))
            {
                lblUpgrade5ElektrischKippenpoortje.ForeColor = Color.Green;
            }
            else
            {
                lblUpgrade5ElektrischKippenpoortje.ForeColor = Color.Red;
            }
            //upgrade 6
            lblUpgrade6HormonenPrijs.Text = "Prijs: " + Convert.ToString(Math.Round(floatUpgrade6Prijs, 1));
            if (IsUpgradeBeschikbaar(floatUpgrade6Prijs))
            {
                lblUpgrade6Hormonen.ForeColor = Color.Green;
            }
            else
            {
                lblUpgrade6Hormonen.ForeColor = Color.Red;
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
                MessageBox.Show("U heeft al 10000 keer op de cock geklikt. Misschien is het een goed idee om eventjes naar buiten te gaan en gras aan te raken.", "Advancement: No life");
                picAdvancement1.Image = Properties.Resources.nolife;
            }
            if (advancement2Bereikt && !advancement2Shown)
            {
                advancement2Shown = true;
                MessageBox.Show("U heeft al 10000 kinderen automatisch geproduceerd zonder ook maar een vinger uit te steken.", "Advancement: Lazy");
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
            if (advancement5Bereikt && !advancement5Shown)
            {
                advancement5Shown = true;
                MessageBox.Show("U heeft uw eerste van vele upgrades gekocht. Bluvn goan!", "Advancement: Eerste upgrade");
                picAdvancement5.Image = Properties.Resources.upgrade;
            }
            if (advancement6Bereikt && !advancement6Shown)
            {
                advancement6Shown = true;
                MessageBox.Show("U heeft al 5 keer de duurste upgrade gekocht. Geen geld tekort blijkbaar.", "Advancement: Rijke stinkerd");
                picAdvancement6.Image = Properties.Resources.money_with_wings;
            }

            //boerderij
            lblUpgrade1Aantal.Text = "Aantal: " + Convert.ToString(floatUpgrade1Aantal);
            lblUpgrade2Aantal.Text = "Aantal: " + Convert.ToString(floatUpgrade2Aantal);
            lblUpgrade3Aantal.Text = "Aantal: " + Convert.ToString(floatUpgrade3Aantal);
            lblUpgrade4Aantal.Text = "Aantal: " + Convert.ToString(floatUpgrade4Aantal);
            lblUpgrade5Aantal.Text = "Aantal: " + Convert.ToString(floatUpgrade5Aantal);
            lblUpgrade6Aantal.Text = "Aantal: " + Convert.ToString(floatUpgrade6Aantal);

            lblUpgrade1KinderenPerSeconde.Text = "Kinderen per seconde: " + Convert.ToString(floatUpgrade1KinderenPerSeconde);
            lblUpgrade2KinderenPerSeconde.Text = "Kinderen per seconde: " + Convert.ToString(floatUpgrade2KinderenPerSeconde);
            lblUpgrade3KinderenPerSeconde.Text = "Kinderen per seconde: " + Convert.ToString(floatUpgrade3KinderenPerSeconde);
            lblUpgrade4KinderenPerSeconde.Text = "Kinderen per seconde: " + Convert.ToString(floatUpgrade4KinderenPerSeconde);
            lblUpgrade5KinderenPerSeconde.Text = "Kinderen per seconde: " + Convert.ToString(floatUpgrade5KinderenPerSeconde);
            lblUpgrade6KinderenPerSeconde.Text = "Kinderen per seconde: " + Convert.ToString(floatUpgrade6KinderenPerSeconde);

            lblUpgrade1Procent.Text = "Aandeel in productie: " + Convert.ToString(Math.Round((floatUpgrade1KinderenPerSeconde / floatAantalKinderenPerSeconde) * 100, 1)) + "%";
            lblUpgrade2Procent.Text = "Aandeel in productie: " + Convert.ToString(Math.Round((floatUpgrade2KinderenPerSeconde / floatAantalKinderenPerSeconde) * 100, 1)) + "%";
            lblUpgrade3Procent.Text = "Aandeel in productie: " + Convert.ToString(Math.Round((floatUpgrade3KinderenPerSeconde / floatAantalKinderenPerSeconde) * 100, 1)) + "%";
            lblUpgrade4Procent.Text = "Aandeel in productie: " + Convert.ToString(Math.Round((floatUpgrade4KinderenPerSeconde / floatAantalKinderenPerSeconde) * 100, 1)) + "%";
            lblUpgrade5Procent.Text = "Aandeel in productie: " + Convert.ToString(Math.Round((floatUpgrade5KinderenPerSeconde / floatAantalKinderenPerSeconde) * 100, 1)) + "%";
            lblUpgrade6Procent.Text = "Aandeel in productie: " + Convert.ToString(Math.Round((floatUpgrade6KinderenPerSeconde / floatAantalKinderenPerSeconde) * 100, 1)) + "%";

        }




        private void tmrExtraKinderen_Tick(object sender, EventArgs e)
        {
            //er is 1/10e seconde gepasseerd
            //aantal kinderen verhogen
            floatAantalKinderen = floatAantalKinderen + floatAantalKinderenPerSeconde / 10;
            floatTotaalAutomatischGeproduceerd += floatAantalKinderenPerSeconde / 10;

            //checken voor advancements
            if (floatTotaalAutomatischGeproduceerd >= 10000)
            {
                advancement2Bereikt = true;
            }

            if (floatUpgrade1Aantal == 1 || floatUpgrade2Aantal == 1 || floatUpgrade3Aantal == 1 || floatUpgrade4Aantal == 1 || floatUpgrade5Aantal == 1 || floatUpgrade6Aantal == 1)
            {
                advancement5Bereikt = true;
            }

            if (floatUpgrade6Aantal == 5)
            {
                advancement6Bereikt = true;
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
