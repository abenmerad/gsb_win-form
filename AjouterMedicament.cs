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
    public partial class AjouterMedicament : Form
    {
        private gsbEntities gsbData;
        private List<Medic> medic;

        public AjouterMedicament(gsbEntities gsbData, List<Medic> med)
        {
            InitializeComponent();
            this.gsbData = gsbData;
            this.medic = med;
            this.bndSrcMedicament.DataSource = this.gsbData.medicament.ToList();
            this.bndSrcFamilleMedicament.DataSource = this.gsbData.famille.ToList();
        }
        private List<famille> LesFamillesMedicament
        {
            get
            {
                var query = (from fam in this.gsbData.famille select fam).OrderBy(famille => famille.libelle);
                var lesFamilles = query.ToList();
                return lesFamilles;
            }
        }

        private List<medicament> LesMedicaments
        {
            get
            {
                var query = (from medic in this.gsbData.medicament select medic).OrderBy(medicament => medicament.nomCommercial);
                var lesMedicaments = query.ToList();
                return lesMedicaments;
            }
        }

        private string getIdFamilleParLibelle(string libel)
        {
            var query = (from fam in this.gsbData.famille where fam.libelle == libel select fam.id);
            return query.ToString();
        }

        private medicament getMedicamentParNom(string libel)
        {
            var query = (from med in this.gsbData.medicament where med.nomCommercial == libel select med);
            return query.First();
        }
        private void AjouterMedicament_Load(object sender, EventArgs e)
        {
            this.btn_validerNouveauMedicament.Enabled = false;
            for (int i = 1; i <= 30; i++)
                this.cmb_qteMedicament.Items.Add(i);

            foreach (famille fam in this.LesFamillesMedicament)
            {
                this.cmb_familleMedicament.Items.Add(fam.libelle);
            }
        }

        private void cmb_familleMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmb_medicament.Items.Clear();
            foreach (medicament medic in this.LesMedicaments)
            {
                if (this.cmb_familleMedicament.SelectedItem.ToString() == medic.famille.libelle)
                {
                    this.cmb_medicament.Items.Add(medic.nomCommercial);
                }
            }
        }

        private void btn_validerNouveauMedicament_Click(object sender, EventArgs e)
        {
            medicament medic = getMedicamentParNom(this.cmb_medicament.SelectedItem.ToString());
            this.medic.Add(new Medic(medic.id, medic.nomCommercial, medic.famille.libelle, this.cmb_qteMedicament.SelectedItem.ToString()));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmb_medicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmb_medicament.SelectedItem != null)
            {
                medicament med = getMedicamentParNom(this.cmb_medicament.SelectedItem.ToString());
                this.txt_contreIndications.Text = med.contreIndications;
                this.txt_effets.Text = med.effets;
                this.txt_composition.Text = med.composition;
            }
            else if (this.cmb_medicament.SelectedItem != null && this.cmb_qteMedicament.SelectedItem != null)
            {
                this.btn_validerNouveauMedicament.Enabled = true;
            }
            else
            {
                this.btn_validerNouveauMedicament.Enabled = false;
            }
        }

        private void cmb_qteMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_medicament.SelectedItem != null && this.cmb_qteMedicament.SelectedItem != null)
            {
                this.btn_validerNouveauMedicament.Enabled = true;
            }
            else
            {
                this.btn_validerNouveauMedicament.Enabled = false;
            }
        }
    }
}
