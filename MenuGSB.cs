using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb_application
{
    public partial class MenuGSB : Form
    {
        private gsbEntities gsbData;
        public MenuGSB()
        {
            InitializeComponent();
            this.gsbData = new gsbEntities();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterRapportMenu menu = new AjouterRapportMenu(this.gsbData);
            menu.Show();
        }
    }
}
