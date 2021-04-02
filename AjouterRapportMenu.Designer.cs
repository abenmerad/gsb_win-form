
namespace gsb_application
{
    partial class AjouterRapportMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_medecin = new System.Windows.Forms.Label();
            this.lbl_visiteur = new System.Windows.Forms.Label();
            this.lbl_bilan = new System.Windows.Forms.Label();
            this.richTxt_bilan = new System.Windows.Forms.RichTextBox();
            this.richTxt_motif = new System.Windows.Forms.RichTextBox();
            this.lbl_motif = new System.Windows.Forms.Label();
            this.btn_validerAjouterRapport = new System.Windows.Forms.Button();
            this.cmb_Medecin = new System.Windows.Forms.ComboBox();
            this.cmb_Visiteur = new System.Windows.Forms.ComboBox();
            this.dataGrid_listeMedicament = new System.Windows.Forms.DataGridView();
            this.btn_ajoutMedicament = new System.Windows.Forms.Button();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bndSrcMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bndSrcVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listeMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_medecin
            // 
            this.lbl_medecin.AutoSize = true;
            this.lbl_medecin.Location = new System.Drawing.Point(107, 34);
            this.lbl_medecin.Name = "lbl_medecin";
            this.lbl_medecin.Size = new System.Drawing.Size(48, 13);
            this.lbl_medecin.TabIndex = 0;
            this.lbl_medecin.Text = "Medecin";
            // 
            // lbl_visiteur
            // 
            this.lbl_visiteur.AutoSize = true;
            this.lbl_visiteur.Location = new System.Drawing.Point(441, 34);
            this.lbl_visiteur.Name = "lbl_visiteur";
            this.lbl_visiteur.Size = new System.Drawing.Size(41, 13);
            this.lbl_visiteur.TabIndex = 2;
            this.lbl_visiteur.Text = "Visiteur";
            // 
            // lbl_bilan
            // 
            this.lbl_bilan.AutoSize = true;
            this.lbl_bilan.Location = new System.Drawing.Point(103, 262);
            this.lbl_bilan.Name = "lbl_bilan";
            this.lbl_bilan.Size = new System.Drawing.Size(30, 13);
            this.lbl_bilan.TabIndex = 4;
            this.lbl_bilan.Text = "Bilan";
            // 
            // richTxt_bilan
            // 
            this.richTxt_bilan.Location = new System.Drawing.Point(106, 282);
            this.richTxt_bilan.Name = "richTxt_bilan";
            this.richTxt_bilan.Size = new System.Drawing.Size(314, 96);
            this.richTxt_bilan.TabIndex = 6;
            this.richTxt_bilan.Text = "";
            // 
            // richTxt_motif
            // 
            this.richTxt_motif.Location = new System.Drawing.Point(426, 282);
            this.richTxt_motif.Name = "richTxt_motif";
            this.richTxt_motif.Size = new System.Drawing.Size(316, 96);
            this.richTxt_motif.TabIndex = 8;
            this.richTxt_motif.Text = "";
            // 
            // lbl_motif
            // 
            this.lbl_motif.AutoSize = true;
            this.lbl_motif.Location = new System.Drawing.Point(423, 262);
            this.lbl_motif.Name = "lbl_motif";
            this.lbl_motif.Size = new System.Drawing.Size(30, 13);
            this.lbl_motif.TabIndex = 7;
            this.lbl_motif.Text = "Motif";
            // 
            // btn_validerAjouterRapport
            // 
            this.btn_validerAjouterRapport.Location = new System.Drawing.Point(340, 415);
            this.btn_validerAjouterRapport.Name = "btn_validerAjouterRapport";
            this.btn_validerAjouterRapport.Size = new System.Drawing.Size(142, 23);
            this.btn_validerAjouterRapport.TabIndex = 9;
            this.btn_validerAjouterRapport.Text = "Valider";
            this.btn_validerAjouterRapport.UseVisualStyleBackColor = true;
            this.btn_validerAjouterRapport.Click += new System.EventHandler(this.btn_validerAjouterRapport_Click);
            // 
            // cmb_Medecin
            // 
            this.cmb_Medecin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Medecin.FormattingEnabled = true;
            this.cmb_Medecin.Location = new System.Drawing.Point(178, 31);
            this.cmb_Medecin.Name = "cmb_Medecin";
            this.cmb_Medecin.Size = new System.Drawing.Size(189, 21);
            this.cmb_Medecin.TabIndex = 11;
            // 
            // cmb_Visiteur
            // 
            this.cmb_Visiteur.FormattingEnabled = true;
            this.cmb_Visiteur.Location = new System.Drawing.Point(512, 31);
            this.cmb_Visiteur.Name = "cmb_Visiteur";
            this.cmb_Visiteur.Size = new System.Drawing.Size(189, 21);
            this.cmb_Visiteur.TabIndex = 12;
            // 
            // dataGrid_listeMedicament
            // 
            this.dataGrid_listeMedicament.AllowUserToAddRows = false;
            this.dataGrid_listeMedicament.AllowUserToDeleteRows = false;
            this.dataGrid_listeMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listeMedicament.Location = new System.Drawing.Point(202, 103);
            this.dataGrid_listeMedicament.Name = "dataGrid_listeMedicament";
            this.dataGrid_listeMedicament.ReadOnly = true;
            this.dataGrid_listeMedicament.Size = new System.Drawing.Size(463, 96);
            this.dataGrid_listeMedicament.TabIndex = 13;
            this.dataGrid_listeMedicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_listeMedicament_CellContentClick);
            // 
            // btn_ajoutMedicament
            // 
            this.btn_ajoutMedicament.Location = new System.Drawing.Point(346, 205);
            this.btn_ajoutMedicament.Name = "btn_ajoutMedicament";
            this.btn_ajoutMedicament.Size = new System.Drawing.Size(150, 19);
            this.btn_ajoutMedicament.TabIndex = 14;
            this.btn_ajoutMedicament.Text = "Ajouter medicament";
            this.btn_ajoutMedicament.UseVisualStyleBackColor = true;
            this.btn_ajoutMedicament.Click += new System.EventHandler(this.btn_ajoutMedicament_Click);
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataSource = typeof(gsb_application.medicament);
            // 
            // bndSrcMedecin
            // 
            this.bndSrcMedecin.DataSource = typeof(gsb_application.medecin);
            // 
            // bndSrcVisiteur
            // 
            this.bndSrcVisiteur.DataSource = typeof(gsb_application.visiteur);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AjouterRapportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ajoutMedicament);
            this.Controls.Add(this.dataGrid_listeMedicament);
            this.Controls.Add(this.cmb_Visiteur);
            this.Controls.Add(this.cmb_Medecin);
            this.Controls.Add(this.btn_validerAjouterRapport);
            this.Controls.Add(this.richTxt_motif);
            this.Controls.Add(this.lbl_motif);
            this.Controls.Add(this.richTxt_bilan);
            this.Controls.Add(this.lbl_bilan);
            this.Controls.Add(this.lbl_visiteur);
            this.Controls.Add(this.lbl_medecin);
            this.DoubleBuffered = true;
            this.Name = "AjouterRapportMenu";
            this.Text = "AjouterRapportMenu";
            this.Load += new System.EventHandler(this.AjouterRapportMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listeMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_medecin;
        private System.Windows.Forms.Label lbl_visiteur;
        private System.Windows.Forms.Label lbl_bilan;
        private System.Windows.Forms.RichTextBox richTxt_bilan;
        private System.Windows.Forms.RichTextBox richTxt_motif;
        private System.Windows.Forms.Label lbl_motif;
        private System.Windows.Forms.Button btn_validerAjouterRapport;
        private System.Windows.Forms.ComboBox cmb_Medecin;
        private System.Windows.Forms.ComboBox cmb_Visiteur;
        private System.Windows.Forms.BindingSource bndSrcMedecin;
        private System.Windows.Forms.BindingSource bndSrcVisiteur;
        private System.Windows.Forms.DataGridView dataGrid_listeMedicament;
        private System.Windows.Forms.Button btn_ajoutMedicament;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}