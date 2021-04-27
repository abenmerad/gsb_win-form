
namespace gsb_application
{
    partial class DetailRapportMenu
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
            this.grp_RapportDetail = new System.Windows.Forms.GroupBox();
            this.lbl_Medecin = new System.Windows.Forms.Label();
            this.lbl_MedecinInfo = new System.Windows.Forms.Label();
            this.lbl_VisiteurInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_RapportInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridMedicament = new System.Windows.Forms.DataGridView();
            this.idMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ajouterMedicament = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Sauvegarder = new System.Windows.Forms.Button();
            this.grp_RapportDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_RapportDetail
            // 
            this.grp_RapportDetail.Controls.Add(this.lbl_RapportInfo);
            this.grp_RapportDetail.Controls.Add(this.label3);
            this.grp_RapportDetail.Controls.Add(this.lbl_VisiteurInfo);
            this.grp_RapportDetail.Controls.Add(this.label2);
            this.grp_RapportDetail.Controls.Add(this.lbl_MedecinInfo);
            this.grp_RapportDetail.Controls.Add(this.lbl_Medecin);
            this.grp_RapportDetail.Location = new System.Drawing.Point(46, 16);
            this.grp_RapportDetail.Name = "grp_RapportDetail";
            this.grp_RapportDetail.Size = new System.Drawing.Size(214, 110);
            this.grp_RapportDetail.TabIndex = 0;
            this.grp_RapportDetail.TabStop = false;
            this.grp_RapportDetail.Text = "Rapport";
            // 
            // lbl_Medecin
            // 
            this.lbl_Medecin.AutoSize = true;
            this.lbl_Medecin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Medecin.Location = new System.Drawing.Point(6, 29);
            this.lbl_Medecin.Name = "lbl_Medecin";
            this.lbl_Medecin.Size = new System.Drawing.Size(48, 13);
            this.lbl_Medecin.TabIndex = 0;
            this.lbl_Medecin.Text = "Medecin";
            this.lbl_Medecin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_MedecinInfo
            // 
            this.lbl_MedecinInfo.AutoSize = true;
            this.lbl_MedecinInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MedecinInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_MedecinInfo.Location = new System.Drawing.Point(78, 27);
            this.lbl_MedecinInfo.Name = "lbl_MedecinInfo";
            this.lbl_MedecinInfo.Size = new System.Drawing.Size(37, 15);
            this.lbl_MedecinInfo.TabIndex = 1;
            this.lbl_MedecinInfo.Text = "AAAA";
            // 
            // lbl_VisiteurInfo
            // 
            this.lbl_VisiteurInfo.AutoSize = true;
            this.lbl_VisiteurInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_VisiteurInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_VisiteurInfo.Location = new System.Drawing.Point(78, 52);
            this.lbl_VisiteurInfo.Name = "lbl_VisiteurInfo";
            this.lbl_VisiteurInfo.Size = new System.Drawing.Size(37, 15);
            this.lbl_VisiteurInfo.TabIndex = 3;
            this.lbl_VisiteurInfo.Text = "AAAA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visiteur";
            // 
            // lbl_RapportInfo
            // 
            this.lbl_RapportInfo.AutoSize = true;
            this.lbl_RapportInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_RapportInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RapportInfo.Location = new System.Drawing.Point(78, 81);
            this.lbl_RapportInfo.Name = "lbl_RapportInfo";
            this.lbl_RapportInfo.Size = new System.Drawing.Size(37, 15);
            this.lbl_RapportInfo.TabIndex = 5;
            this.lbl_RapportInfo.Text = "AAAA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rapport N°";
            // 
            // dataGridMedicament
            // 
            this.dataGridMedicament.AllowUserToAddRows = false;
            this.dataGridMedicament.AllowUserToDeleteRows = false;
            this.dataGridMedicament.AutoGenerateColumns = false;
            this.dataGridMedicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMedicament.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridMedicament.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicamentDataGridViewTextBoxColumn,
            this.nomMedicamentDataGridViewTextBoxColumn,
            this.familleMedicamentDataGridViewTextBoxColumn,
            this.quantiteMedicamentDataGridViewTextBoxColumn});
            this.dataGridMedicament.DataSource = this.medicBindingSource;
            this.dataGridMedicament.Location = new System.Drawing.Point(72, 137);
            this.dataGridMedicament.Name = "dataGridMedicament";
            this.dataGridMedicament.ReadOnly = true;
            this.dataGridMedicament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMedicament.Size = new System.Drawing.Size(677, 131);
            this.dataGridMedicament.TabIndex = 1;
            // 
            // idMedicamentDataGridViewTextBoxColumn
            // 
            this.idMedicamentDataGridViewTextBoxColumn.DataPropertyName = "IdMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.HeaderText = "IdMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.Name = "idMedicamentDataGridViewTextBoxColumn";
            this.idMedicamentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomMedicamentDataGridViewTextBoxColumn
            // 
            this.nomMedicamentDataGridViewTextBoxColumn.DataPropertyName = "NomMedicament";
            this.nomMedicamentDataGridViewTextBoxColumn.HeaderText = "NomMedicament";
            this.nomMedicamentDataGridViewTextBoxColumn.Name = "nomMedicamentDataGridViewTextBoxColumn";
            this.nomMedicamentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familleMedicamentDataGridViewTextBoxColumn
            // 
            this.familleMedicamentDataGridViewTextBoxColumn.DataPropertyName = "FamilleMedicament";
            this.familleMedicamentDataGridViewTextBoxColumn.HeaderText = "FamilleMedicament";
            this.familleMedicamentDataGridViewTextBoxColumn.Name = "familleMedicamentDataGridViewTextBoxColumn";
            this.familleMedicamentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantiteMedicamentDataGridViewTextBoxColumn
            // 
            this.quantiteMedicamentDataGridViewTextBoxColumn.DataPropertyName = "QuantiteMedicament";
            this.quantiteMedicamentDataGridViewTextBoxColumn.HeaderText = "QuantiteMedicament";
            this.quantiteMedicamentDataGridViewTextBoxColumn.Name = "quantiteMedicamentDataGridViewTextBoxColumn";
            this.quantiteMedicamentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicBindingSource
            // 
            this.medicBindingSource.DataSource = typeof(gsb_application.Medic);
            // 
            // btn_ajouterMedicament
            // 
            this.btn_ajouterMedicament.Location = new System.Drawing.Point(455, 274);
            this.btn_ajouterMedicament.Name = "btn_ajouterMedicament";
            this.btn_ajouterMedicament.Size = new System.Drawing.Size(160, 23);
            this.btn_ajouterMedicament.TabIndex = 2;
            this.btn_ajouterMedicament.Text = "Ajouter medicament";
            this.btn_ajouterMedicament.UseVisualStyleBackColor = true;
            this.btn_ajouterMedicament.Click += new System.EventHandler(this.btn_ajouterMedicament_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Supprimer medicament(s)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Sauvegarder
            // 
            this.btn_Sauvegarder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sauvegarder.Location = new System.Drawing.Point(367, 384);
            this.btn_Sauvegarder.Name = "btn_Sauvegarder";
            this.btn_Sauvegarder.Size = new System.Drawing.Size(75, 23);
            this.btn_Sauvegarder.TabIndex = 4;
            this.btn_Sauvegarder.Text = "Sauvegarder";
            this.btn_Sauvegarder.UseVisualStyleBackColor = true;
            // 
            // DetailRapportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sauvegarder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ajouterMedicament);
            this.Controls.Add(this.dataGridMedicament);
            this.Controls.Add(this.grp_RapportDetail);
            this.Name = "DetailRapportMenu";
            this.Text = "DetailRapportMenu";
            this.Load += new System.EventHandler(this.DetailRapportMenu_Load);
            this.grp_RapportDetail.ResumeLayout(false);
            this.grp_RapportDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_RapportDetail;
        private System.Windows.Forms.Label lbl_Medecin;
        private System.Windows.Forms.Label lbl_MedecinInfo;
        private System.Windows.Forms.Label lbl_RapportInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_VisiteurInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicBindingSource;
        private System.Windows.Forms.Button btn_ajouterMedicament;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Sauvegarder;
    }
}