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

        private int getMaxIdRapport()
        {
            var query = (from rap in this.gsbData.rapport select rap).Max(rap => rap.id);
            return (int)query; 
        }
        private medecin getMedecinParNomPrenom(string nom, string prenom)
        {
            var query = (from med in this.gsbData.medecin where med.prenom == prenom && med.nom == nom select med);
            return query.First();
        }
        private visiteur getVisiteurParNomPrenom(string nom, string prenom)
        {
            var query = (from vis in this.gsbData.visiteur where vis.prenom == prenom && vis.nom == nom select vis);
            return query.First();
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
                try
                {
                    rapport nouveauRapport = new rapport();
                    string medecin = cmb_Medecin.SelectedItem.ToString();
                    string visiteur = cmb_Visiteur.SelectedItem.ToString();
                    int idNouveauRapport = getMaxIdRapport() + 1;
                    nouveauRapport.date = DateTime.Now;
                    nouveauRapport.motif = this.richTxt_motif.Text;
                    nouveauRapport.bilan = this.richTxt_bilan.Text;
                    nouveauRapport.idMedecin = getMedecinParNomPrenom(medecin.Split(' ')[0], medecin.Split(' ')[1]).id;
                    nouveauRapport.idVisiteur = getVisiteurParNomPrenom(visiteur.Split(' ')[0], visiteur.Split(' ')[1]).id;
                    this.gsbData.rapport.Add(nouveauRapport);
                    this.gsbData.SaveChanges();
                    foreach (Medic m in this.lesMedicaments)
                    {
                        offrir nouvelleOffre = new offrir();
                        nouvelleOffre.idMedicament = m.IdMedicament;
                        nouvelleOffre.idRapport = idNouveauRapport;
                        nouvelleOffre.quantite = Convert.ToInt32(m.QuantiteMedicament);
                        richTxt_bilan.Text += nouvelleOffre.idMedicament + " - " + nouvelleOffre.idRapport + " - " + nouvelleOffre.quantite + "\n";
                        this.gsbData.offrir.Add(nouvelleOffre);
                        
                    }
                    this.gsbData.SaveChanges();
                    this.Close();
                }
                catch(Exception except)
                {
                    MessageBox.Show(except.ToString());
                }

            }
        }
    }
}
