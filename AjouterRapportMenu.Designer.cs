
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
            this.grp_medicament = new System.Windows.Forms.GroupBox();
            this.cmb_qteMedicament = new System.Windows.Forms.ComboBox();
            this.cmb_Medicament = new System.Windows.Forms.ComboBox();
            this.lbl_qteMedicament = new System.Windows.Forms.Label();
            this.lbl_medicament = new System.Windows.Forms.Label();
            this.lbl_bilan = new System.Windows.Forms.Label();
            this.richTxt_bilan = new System.Windows.Forms.RichTextBox();
            this.richTxt_motif = new System.Windows.Forms.RichTextBox();
            this.lbl_motif = new System.Windows.Forms.Label();
            this.btn_validerAjouterRapport = new System.Windows.Forms.Button();
            this.cmb_Medecin = new System.Windows.Forms.ComboBox();
            this.cmb_Visiteur = new System.Windows.Forms.ComboBox();
            this.bndSrcMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bndSrcVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bndSrcMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.grp_medicament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcMedicament)).BeginInit();
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
            this.lbl_medecin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_visiteur
            // 
            this.lbl_visiteur.AutoSize = true;
            this.lbl_visiteur.Location = new System.Drawing.Point(107, 92);
            this.lbl_visiteur.Name = "lbl_visiteur";
            this.lbl_visiteur.Size = new System.Drawing.Size(41, 13);
            this.lbl_visiteur.TabIndex = 2;
            this.lbl_visiteur.Text = "Visiteur";
            // 
            // grp_medicament
            // 
            this.grp_medicament.Controls.Add(this.cmb_qteMedicament);
            this.grp_medicament.Controls.Add(this.cmb_Medicament);
            this.grp_medicament.Controls.Add(this.lbl_qteMedicament);
            this.grp_medicament.Controls.Add(this.lbl_medicament);
            this.grp_medicament.Location = new System.Drawing.Point(110, 126);
            this.grp_medicament.Name = "grp_medicament";
            this.grp_medicament.Size = new System.Drawing.Size(603, 100);
            this.grp_medicament.TabIndex = 4;
            this.grp_medicament.TabStop = false;
            this.grp_medicament.Text = "Medicament";
            // 
            // cmb_qteMedicament
            // 
            this.cmb_qteMedicament.FormattingEnabled = true;
            this.cmb_qteMedicament.Location = new System.Drawing.Point(142, 61);
            this.cmb_qteMedicament.Name = "cmb_qteMedicament";
            this.cmb_qteMedicament.Size = new System.Drawing.Size(50, 21);
            this.cmb_qteMedicament.TabIndex = 4;
            // 
            // cmb_Medicament
            // 
            this.cmb_Medicament.FormattingEnabled = true;
            this.cmb_Medicament.Location = new System.Drawing.Point(142, 30);
            this.cmb_Medicament.Name = "cmb_Medicament";
            this.cmb_Medicament.Size = new System.Drawing.Size(153, 21);
            this.cmb_Medicament.TabIndex = 3;
            // 
            // lbl_qteMedicament
            // 
            this.lbl_qteMedicament.AutoSize = true;
            this.lbl_qteMedicament.Location = new System.Drawing.Point(71, 61);
            this.lbl_qteMedicament.Name = "lbl_qteMedicament";
            this.lbl_qteMedicament.Size = new System.Drawing.Size(47, 13);
            this.lbl_qteMedicament.TabIndex = 2;
            this.lbl_qteMedicament.Text = "Quantité";
            this.lbl_qteMedicament.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_medicament
            // 
            this.lbl_medicament.AutoSize = true;
            this.lbl_medicament.Location = new System.Drawing.Point(71, 33);
            this.lbl_medicament.Name = "lbl_medicament";
            this.lbl_medicament.Size = new System.Drawing.Size(65, 13);
            this.lbl_medicament.TabIndex = 0;
            this.lbl_medicament.Text = "Medicament";
            // 
            // lbl_bilan
            // 
            this.lbl_bilan.AutoSize = true;
            this.lbl_bilan.Location = new System.Drawing.Point(107, 250);
            this.lbl_bilan.Name = "lbl_bilan";
            this.lbl_bilan.Size = new System.Drawing.Size(30, 13);
            this.lbl_bilan.TabIndex = 4;
            this.lbl_bilan.Text = "Bilan";
            // 
            // richTxt_bilan
            // 
            this.richTxt_bilan.Location = new System.Drawing.Point(110, 282);
            this.richTxt_bilan.Name = "richTxt_bilan";
            this.richTxt_bilan.Size = new System.Drawing.Size(209, 96);
            this.richTxt_bilan.TabIndex = 6;
            this.richTxt_bilan.Text = "";
            // 
            // richTxt_motif
            // 
            this.richTxt_motif.Location = new System.Drawing.Point(426, 282);
            this.richTxt_motif.Name = "richTxt_motif";
            this.richTxt_motif.Size = new System.Drawing.Size(209, 96);
            this.richTxt_motif.TabIndex = 8;
            this.richTxt_motif.Text = "";
            // 
            // lbl_motif
            // 
            this.lbl_motif.AutoSize = true;
            this.lbl_motif.Location = new System.Drawing.Point(423, 250);
            this.lbl_motif.Name = "lbl_motif";
            this.lbl_motif.Size = new System.Drawing.Size(30, 13);
            this.lbl_motif.TabIndex = 7;
            this.lbl_motif.Text = "Motif";
            this.lbl_motif.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btn_validerAjouterRapport
            // 
            this.btn_validerAjouterRapport.Location = new System.Drawing.Point(340, 415);
            this.btn_validerAjouterRapport.Name = "btn_validerAjouterRapport";
            this.btn_validerAjouterRapport.Size = new System.Drawing.Size(142, 23);
            this.btn_validerAjouterRapport.TabIndex = 9;
            this.btn_validerAjouterRapport.Text = "Valider";
            this.btn_validerAjouterRapport.UseVisualStyleBackColor = true;
            // 
            // cmb_Medecin
            // 
            this.cmb_Medecin.FormattingEnabled = true;
            this.cmb_Medecin.Location = new System.Drawing.Point(178, 31);
            this.cmb_Medecin.Name = "cmb_Medecin";
            this.cmb_Medecin.Size = new System.Drawing.Size(189, 21);
            this.cmb_Medecin.TabIndex = 11;
            // 
            // cmb_Visiteur
            // 
            this.cmb_Visiteur.FormattingEnabled = true;
            this.cmb_Visiteur.Location = new System.Drawing.Point(178, 89);
            this.cmb_Visiteur.Name = "cmb_Visiteur";
            this.cmb_Visiteur.Size = new System.Drawing.Size(189, 21);
            this.cmb_Visiteur.TabIndex = 12;
            // 
            // bndSrcMedecin
            // 
            this.bndSrcMedecin.DataSource = typeof(gsb_application.medecin);
            // 
            // bndSrcVisiteur
            // 
            this.bndSrcVisiteur.DataSource = typeof(gsb_application.visiteur);
            // 
            // bndSrcMedicament
            // 
            this.bndSrcMedicament.DataSource = typeof(gsb_application.medicament);
            // 
            // AjouterRapportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_Visiteur);
            this.Controls.Add(this.cmb_Medecin);
            this.Controls.Add(this.btn_validerAjouterRapport);
            this.Controls.Add(this.richTxt_motif);
            this.Controls.Add(this.lbl_motif);
            this.Controls.Add(this.richTxt_bilan);
            this.Controls.Add(this.lbl_bilan);
            this.Controls.Add(this.grp_medicament);
            this.Controls.Add(this.lbl_visiteur);
            this.Controls.Add(this.lbl_medecin);
            this.Name = "AjouterRapportMenu";
            this.Text = "AjouterRapportMenu";
            this.Load += new System.EventHandler(this.AjouterRapportMenu_Load);
            this.grp_medicament.ResumeLayout(false);
            this.grp_medicament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_medecin;
        private System.Windows.Forms.Label lbl_visiteur;
        private System.Windows.Forms.GroupBox grp_medicament;
        private System.Windows.Forms.Label lbl_qteMedicament;
        private System.Windows.Forms.Label lbl_medicament;
        private System.Windows.Forms.Label lbl_bilan;
        private System.Windows.Forms.RichTextBox richTxt_bilan;
        private System.Windows.Forms.RichTextBox richTxt_motif;
        private System.Windows.Forms.Label lbl_motif;
        private System.Windows.Forms.Button btn_validerAjouterRapport;
        private System.Windows.Forms.ComboBox cmb_qteMedicament;
        private System.Windows.Forms.ComboBox cmb_Medicament;
        private System.Windows.Forms.ComboBox cmb_Medecin;
        private System.Windows.Forms.ComboBox cmb_Visiteur;
        private System.Windows.Forms.BindingSource bndSrcMedecin;
        private System.Windows.Forms.BindingSource bndSrcVisiteur;
        private System.Windows.Forms.BindingSource bndSrcMedicament;
    }
}