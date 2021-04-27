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
    public partial class VisualiserRapportMenu : Form
    {
        private gsbEntities gsbData;
        private List<VisualiserRapport> lesRapports;
        public VisualiserRapportMenu(gsbEntities gsbData)
        {
            InitializeComponent();
            this.gsbData = gsbData;
            this.lesRapports = new List<VisualiserRapport>();
            this.dataGridRapports.DataSource = new BindingSource(new BindingList<VisualiserRapport>(this.lesRapports), null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VisualiserRapportMenu_Load(object sender, EventArgs e)
        {
            foreach (medecin med in this.gsbData.medecin.OrderBy(medecin => medecin.nom).ToList())
            {
                string leMedecin = med.nom + " " + med.prenom;
                this.cmb_Medecin.Items.Add(leMedecin);
            }

            foreach (visiteur vis in this.gsbData.visiteur.OrderBy(visiteur => visiteur.nom).ToList())
            {
                string leVisiteur = vis.nom + " " + vis.prenom;
                this.cmb_Visiteur.Items.Add(leVisiteur);
            }

            foreach (famille fam in this.gsbData.famille.ToList())
            {
                this.cmb_FamilleMedicament.Items.Add(fam.libelle);
            }
        }

        private void cmb_FamilleMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmb_Medicament.SelectedItem = null;
            this.cmb_Medicament.Items.Clear();
        
            var query = from medic in gsbData.medicament
                        join fam in gsbData.famille on medic.idFamille equals fam.id
                        where fam.libelle == this.cmb_FamilleMedicament.SelectedItem.ToString()
                        select medic;
            foreach(var res in query)
            {
                cmb_Medicament.Items.Add(res.nomCommercial);
            }
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            this.lesRapports.Clear();
            this.gsbData.Configuration.ProxyCreationEnabled = false;

            var query = from off in gsbData.offrir
                        join rapp in gsbData.rapport on off.idRapport equals rapp.id
                        join med in gsbData.medecin on rapp.idMedecin equals med.id
                        join medic in gsbData.medicament on off.idMedicament equals medic.id
                        join fam in gsbData.famille on medic.idFamille equals fam.id
                        join vis in gsbData.visiteur on rapp.idVisiteur equals vis.id
                        select new { NomMedecin = med.nom, PrenomMedecin = med.prenom, NomVisiteur = vis.nom, PrenomVisiteur = vis.prenom, FamilleMedicament = fam.libelle ,Medicament = medic.nomCommercial, Rapport = rapp.id };
            if (cmb_Medecin.SelectedItem != null)
            {
                string nom = cmb_Medecin.SelectedItem.ToString().Split(' ')[0];
                string prenom = cmb_Medecin.SelectedItem.ToString().Split(' ')[1];
                query = query.Where(off => off.NomMedecin == nom && off.PrenomMedecin == prenom);
            }

            if(cmb_Visiteur.SelectedItem != null)
            {
                string nom = cmb_Visiteur.SelectedItem.ToString().Split(' ')[0];
                string prenom = cmb_Visiteur.SelectedItem.ToString().Split(' ')[1];
                query = query.Where(off => off.NomVisiteur == nom && off.PrenomVisiteur == prenom);
            }

            if(cmb_Medicament.SelectedItem != null)
            {
                string nomCommercial = cmb_Medicament.SelectedItem.ToString();
                query = query.Where(off => off.Medicament == nomCommercial);
            }

            foreach (var offre in query.ToList())
            {
                if (offre != null)
                {
                    this.lesRapports.Add(new VisualiserRapport(offre.NomMedecin + ' ' + offre.PrenomMedecin, offre.NomVisiteur + ' ' + offre.PrenomVisiteur, offre.Rapport, offre.FamilleMedicament, offre.Medicament));
                }
            }
            this.dataGridRapports.DataSource = new BindingSource(new BindingList<VisualiserRapport>(this.lesRapports), null);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_Medecin.SelectedItem = null;
            cmb_Visiteur.SelectedItem = null;
            cmb_FamilleMedicament.SelectedItem = null;
            cmb_Medicament.SelectedItem = null;
        }

        private void dataGridRapports_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridRapports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string med = dataGridRapports.Rows[e.RowIndex].Cells[0].Value.ToString();
                string vis = dataGridRapports.Rows[e.RowIndex].Cells[1].Value.ToString();
                int rapp = Convert.ToInt32(dataGridRapports.Rows[e.RowIndex].Cells[2].Value.ToString());
                string medic = dataGridRapports.Rows[e.RowIndex].Cells[3].Value.ToString();
                string fam = dataGridRapports.Rows[e.RowIndex].Cells[4].Value.ToString();
                VisualiserRapport rapport = new VisualiserRapport(med, vis, rapp, fam, medic);
                DetailRapportMenu menu = new DetailRapportMenu(this.gsbData, rapport);
                menu.ShowDialog();
            }
        }
    }
}
