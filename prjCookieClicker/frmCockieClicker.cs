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

        public frmCockieClicker()
        {
            InitializeComponent();
        }

        private void picCock_Click(object sender, EventArgs e)
        {
            //er is op de cock geklikt
            intAantalKinderen++;
            lblAantalKinderen.Text = "Aantal kinderen: " + intAantalKinderen.ToString();
        }
    }
}
