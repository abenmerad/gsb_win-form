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
    public partial class VisualiserRapport : Form
    {
        private gsbEntities gsbData;
        public VisualiserRapport(gsbEntities gsbData)
        {
            InitializeComponent();
            this.gsbData = gsbData;
        }

        private void VisualiserRapport_Load(object sender, EventArgs e)
        {
            foreach(medecin m in lesMedecins())
            {
                string leMedecin = m.nom + " " + m.prenom;
                this.cmb_medecin.Items.Add(leMedecin); 
            }

            foreach (visiteur v in lesVisiteurs())
            {
                string leVisiteur = v.nom + " " + v.prenom;
                this.cmb_visiteur.Items.Add(leVisiteur);
            }

            foreach (medicament med in lesMedicaments())
            {
                string leMedicament = med.nomCommercial;
                this.cmb_medicament.Items.Add(leMedicament);
            }

        }

        private void cmb_medecin_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private List<medecin> lesMedecins()
        {
                var query = (from vis in this.gsbData.medecin select vis).OrderBy(medecin => medecin.nom);
                var lesMedecins = query.ToList();
                return lesMedecins;
            
        }

        private List<visiteur> lesVisiteurs()
        {
            var query = (from vis in this.gsbData.visiteur select vis).OrderBy(visiteur => visiteur.nom);
            var lesVisiteurs = query.ToList();
            return lesVisiteurs;

        }

        private List<medicament> lesMedicaments()
        {
            var query = (from vis in this.gsbData.medicament select vis).OrderBy(medicament => medicament.nomCommercial);
            var lesMedicaments = query.ToList();
            return lesMedicaments;

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {

        }
    }
}
