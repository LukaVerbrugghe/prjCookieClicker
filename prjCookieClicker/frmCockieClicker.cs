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
        float floatTotaalAantalKeerGeklikt = 0;
        float floatTotaalAutomatischGeproduceerd = 0;
        float floatAantalKinderen = 0;
        float floatAantalKinderenPerSeconde = 0;

        float floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs = 150;
        float floatVereisteKinderenUpgrade1VerdundKippenvoerExtraKinderenPerSeconde = 1;

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

        public frmCockieClicker()
        {
            InitializeComponent();
            tmrAnimatie.Start();
            UpdateScherm();
        }

        private void picCock_MouseDown(object sender, MouseEventArgs e)
        {
            //er is op de cock geklikt
            floatAantalKinderen++;

            floatTotaalAantalKeerGeklikt++;
            UpdateScherm();
            //checken of er al 1000 keer geklikt is (advancement)
            if (floatTotaalAantalKeerGeklikt == 1000)
            {
                advancement1Bereikt = true;
            }
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            //messegebox met uitleg weergeven
            MessageBox.Show("Klik op de cock om kinderen te produceren.\nKoop met kinderen upgrades om de kinderproductie te automatiseren.\n\nNaast een upgrade staat telkens de prijs. Wanneer de upgrade groen wordt kan je deze kopen. Dan kan je er gewoon op klikken. Een upgrade wordt duurder per keer dat je deze koopt.", "Help");
        }

        private void picUpgrade1VerdundKippenvoer_Click(object sender, EventArgs e)
        {
            if (IsUpgradeBeschikbaar(floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs))
            {
                //verdund kippenvoer gekocht
                floatAantalKinderen = floatAantalKinderen - floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs;
                floatAantalKinderenPerSeconde = floatAantalKinderenPerSeconde + floatVereisteKinderenUpgrade1VerdundKippenvoerExtraKinderenPerSeconde;
                UpdateScherm();
                tmrExtraKinderen.Start();
            }

            //prijs verhogen
            floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs = floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs * 1.2f;
            UpdateScherm();
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
            lblUpgrade1VerdundKippenvoerPrijs.Text = "Prijs: " + floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs.ToString();
            //kleur van de label aanpassen om aan te tonen of het product wel of niet gekocht kan worden
            if (IsUpgradeBeschikbaar(floatVereisteKinderenUpgrade1VerdundKippenvoerPrijs))
            {
                lblUpgrade1VerdundKippenvoer.ForeColor = Color.Green;
            }
            else
            {
                lblUpgrade1VerdundKippenvoer.ForeColor = Color.Red;
            }

            //stats
            lblTotaalAantalKliks.Text = "Aantal keer geklikt: " + floatTotaalAantalKeerGeklikt.ToString();
            lblTotaalAutomatischGeproduceerd.Text = "Automatisch geproduceerd: " + Convert.ToString(Math.Round(floatTotaalAutomatischGeproduceerd, 1));

            //advancements
            if (advancement1Bereikt)
            {
                MessageBox.Show("U heeft al 1000 keer op de cock geklikt. Misschien is het een goed idee om eventjes naar buiten te gaan en gras aan te raken.", "Advancement: No life");
                picAdvancement1.Image = Properties.Resources.nolife;
            }
            if (advancement2Bereikt)
            {
                MessageBox.Show("U heeft al 1000 kinderen automatisch geproduceerd zonder ook maar een vinger uit te steken.", "Advancement: Lazy");
                picAdvancement2.Image = Properties.Resources.lazy;

            }
        }

        private void tmrExtraKinderen_Tick(object sender, EventArgs e)
        {
            //er is 1/10e seconde gepasseerd
            //aantal kinderen verhogen
            floatAantalKinderen = floatAantalKinderen + floatAantalKinderenPerSeconde / 10;
            floatTotaalAutomatischGeproduceerd += floatAantalKinderenPerSeconde / 10;

            //checken voor advancement
            if (floatTotaalAutomatischGeproduceerd >= 1000 && !advancement2Bereikt)
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
    }
}
