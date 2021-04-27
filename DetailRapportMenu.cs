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
    public partial class DetailRapportMenu : Form
    {
        private gsbEntities gsbData;
        private VisualiserRapport detailRapport;
        private List<Medic> lesMedicaments;

        public DetailRapportMenu(gsbEntities gsbData, VisualiserRapport rapport)
        {
            InitializeComponent();
            this.gsbData = gsbData;
            this.detailRapport = rapport;
            this.lesMedicaments = new List<Medic>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DetailRapportMenu_Load(object sender, EventArgs e)
        {
            lbl_MedecinInfo.Text = this.detailRapport.Medecin;
            lbl_RapportInfo.Text = this.detailRapport.Rapport.ToString();
            lbl_VisiteurInfo.Text = this.detailRapport.Visiteur;

            var query = from off in gsbData.offrir
                        join medic in gsbData.medicament on off.idMedicament equals medic.id
                        join fam in gsbData.famille on medic.idFamille equals fam.id
                        where off.idRapport == detailRapport.Rapport
                        select new { IdMedicament = medic.id, NomMedicament = medic.nomCommercial, FamilleMedicament = fam.libelle, QuantiteMedicament = off.quantite};

            foreach(var res in query)
            {
                lesMedicaments.Add(new Medic(res.IdMedicament, res.NomMedicament, res.FamilleMedicament, (int)res.QuantiteMedicament));
            }
            dataGridMedicament.DataSource = new BindingSource(new BindingList<Medic>(lesMedicaments), null);
        }

        private void btn_ajouterMedicament_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
