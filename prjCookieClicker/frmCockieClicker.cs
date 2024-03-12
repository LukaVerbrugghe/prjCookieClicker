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
        int intAantalKinderen = 0;
        int intAantalKinderenPerSeconde = 0;

        int intVereisteKinderenUpgrade1VerdundKippenvoerPrijs = 15;
        int intVereisteKinderenUpgrade1VerdundKippenvoerExtraKinderenPerSeconde = 1;

        public frmCockieClicker()
        {
            InitializeComponent();
            UpdateScherm();
        }

        private void picCock_Click(object sender, EventArgs e)
        {
            //er is op de cock geklikt
            intAantalKinderen++;
            UpdateScherm();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //messegebox met uitleg weergeven
            MessageBox.Show("Klik op de cock om kinderen te produceren.\nKoop met kinderen upgrades om de kinderupgrade te automatiseren.", "Help");
        }

        private void picUpgrade1VerdundKippenvoer_Click(object sender, EventArgs e)
        {
            if (IsUpgradeBeschikbaar(intAantalKinderen, intVereisteKinderenUpgrade1VerdundKippenvoerPrijs))
            {
                //verdund kippenvoer gekocht
                intAantalKinderen = intAantalKinderen - intVereisteKinderenUpgrade1VerdundKippenvoerPrijs;
                intAantalKinderenPerSeconde = intAantalKinderenPerSeconde + intVereisteKinderenUpgrade1VerdundKippenvoerExtraKinderenPerSeconde;
                UpdateScherm();
                BerekenIntervalTimerExtraKinderen();
                tmrExtraKinderen.Start();
            }
            else
            {
                //de gebruiker is te skeer om dit te kunnen betalen
                MessageBox.Show("U bent te skeer om dit te kunnen kopen.", "U bent skeer!");
            }
        }


        //functie om te checken of de upgrade nog beschikbaar is
        private bool IsUpgradeBeschikbaar(int intAanatalKinderen, int intVereisteKinderen)
        {
            if (intAanatalKinderen >= intVereisteKinderen)
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
            lblAantalKinderen.Text = "Aantal kinderen: " + intAantalKinderen.ToString();
            lblKinderenPerSeconde.Text = "Kinderen per seconde: " + intAantalKinderenPerSeconde.ToString();
        }

        private void tmrExtraKinderen_Tick(object sender, EventArgs e)
        {
            //plus 1 kind
            intAantalKinderen++;
            UpdateScherm();
        }

        private void BerekenIntervalTimerExtraKinderen()
        {
            tmrExtraKinderen.Interval = 1000 / intAantalKinderenPerSeconde;
        }
    }
}
