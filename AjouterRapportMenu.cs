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
    public partial class AjouterRapportMenu : Form
    {
        private gsbEntities gsbData;
        public AjouterRapportMenu(gsbEntities gsbData)
        {
            InitializeComponent();
            for (int i = 0; i <= 30; i++)
                this.cmb_qteMedicament.Items.Add(i);
            this.gsbData = gsbData;
            this.bndSrcMedecin.DataSource = this.gsbData.medecin.ToString();
            this.bndSrcMedicament.DataSource = this.gsbData.medicament.ToString();
            this.bndSrcVisiteur.DataSource = this.gsbData.visiteur.ToString();
        }

        private List<medecin> LesMedecins
        {
            get
            {
                var query = (from med in this.gsbData.medecin select med).OrderBy(medecin => medecin.nom);
                var lesMedecins = query.ToList();
                return lesMedecins;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void AjouterRapportMenu_Load(object sender, EventArgs e)
        {
            foreach (medecin med in this.LesMedecins)
            {
                string leMedecin = med.nom + " " + med.prenom;
                this.cmb_Medecin.Items.Add(leMedecin);
            }
        }
    }
}
