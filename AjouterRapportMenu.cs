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
        private List<Medic> lesMedicaments;
        public AjouterRapportMenu(gsbEntities gsbData)
        {
            InitializeComponent();
            this.gsbData = gsbData;
            this.lesMedicaments = new List<Medic>();
            var bindSource = new BindingList<Medic>(this.lesMedicaments);
            this.dataGrid_listeMedicament.DataSource = new BindingSource(bindSource, null);
            this.bndSrcMedecin.DataSource = this.gsbData.medecin.ToList();
            this.bndSrcVisiteur.DataSource = this.gsbData.visiteur.ToList();
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
        
        private List<visiteur> LesVisiteurs
        {
            get
            {
                var query = (from vis in this.gsbData.visiteur select vis).OrderBy(visiteur => visiteur.nom);
                var lesVisiteurs = query.ToList();
                return lesVisiteurs;
            }
        }

        private medecin getMedecinParNomPrenom(string nom, string prenom)
        {
            var query = (from med in this.gsbData.medecin where med.prenom == prenom && med.nom == nom select med);
            return (medecin)query;
        }
        private void AjouterRapportMenu_Load(object sender, EventArgs e)
        {
            foreach (medecin med in this.LesMedecins)
            {
                string leMedecin = med.nom + " " + med.prenom;
                this.cmb_Medecin.Items.Add(leMedecin);
            }


            foreach (visiteur vis in this.LesVisiteurs)
            {
                string leVisiteur = vis.nom + " " + vis.prenom;
                this.cmb_Visiteur.Items.Add(leVisiteur);
            }

        }

        private void btn_ajoutMedicament_Click(object sender, EventArgs e)
        {
            AjouterMedicament menu = new AjouterMedicament(this.gsbData, this.lesMedicaments);
            if(menu.ShowDialog() == DialogResult.OK)
            {
                this.dataGrid_listeMedicament.DataSource = new BindingSource(new BindingList<Medic>(this.lesMedicaments), null);
            }
        }
        private void dataGrid_listeMedicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_validerAjouterRapport_Click(object sender, EventArgs e)
        {
            if (this.cmb_Medecin.SelectedItem == null)
            {
                this.errorProvider1.SetError(this.cmb_Medecin, "Le champ doit être selectionné.");
            }
            else if (this.cmb_Visiteur.SelectedItem == null)
            {
                this.errorProvider1.SetError(this.cmb_Visiteur, "Le champ doit être selectionné.");
            }
            else if (this.lesMedicaments.Count == 0)
            {
                this.errorProvider1.SetError(this.dataGrid_listeMedicament, "Il faut ajouter au moins un medicament.");
            }
            else if (this.richTxt_bilan.Text == "")
            {
                this.errorProvider1.SetError(this.lbl_bilan, "Le champ ne peut être vide.");
            }
            else if (this.richTxt_motif.Text == "")
            {
                this.errorProvider1.SetError(this.lbl_motif, "Le champ ne peut être vide.");
            }
            else
            {
                rapport nouveauRapport = new rapport();
                nouveauRapport.date = DateTime.Now();
            }
        }
    }
}
