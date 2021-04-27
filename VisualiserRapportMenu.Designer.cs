
namespace gsb_application
{
    partial class VisualiserRapportMenu
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
            this.cmb_Medecin = new System.Windows.Forms.ComboBox();
            this.cmb_FamilleMedicament = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Medicament = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Visiteur = new System.Windows.Forms.ComboBox();
            this.lbl_visiteur = new System.Windows.Forms.Label();
            this.dataGridRapports = new System.Windows.Forms.DataGridView();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.medecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visualiserRapportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualiserRapportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_medecin
            // 
            this.lbl_medecin.AutoSize = true;
            this.lbl_medecin.Location = new System.Drawing.Point(263, 40);
            this.lbl_medecin.Name = "lbl_medecin";
            this.lbl_medecin.Size = new System.Drawing.Size(48, 13);
            this.lbl_medecin.TabIndex = 1;
            this.lbl_medecin.Text = "Medecin";
            // 
            // cmb_Medecin
            // 
            this.cmb_Medecin.FormattingEnabled = true;
            this.cmb_Medecin.Location = new System.Drawing.Point(333, 37);
            this.cmb_Medecin.Name = "cmb_Medecin";
            this.cmb_Medecin.Size = new System.Drawing.Size(161, 21);
            this.cmb_Medecin.TabIndex = 2;
            // 
            // cmb_FamilleMedicament
            // 
            this.cmb_FamilleMedicament.FormattingEnabled = true;
            this.cmb_FamilleMedicament.Location = new System.Drawing.Point(197, 101);
            this.cmb_FamilleMedicament.Name = "cmb_FamilleMedicament";
            this.cmb_FamilleMedicament.Size = new System.Drawing.Size(161, 21);
            this.cmb_FamilleMedicament.TabIndex = 4;
            this.cmb_FamilleMedicament.SelectedIndexChanged += new System.EventHandler(this.cmb_FamilleMedicament_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Famille";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_Medicament
            // 
            this.cmb_Medicament.FormattingEnabled = true;
            this.cmb_Medicament.Location = new System.Drawing.Point(467, 101);
            this.cmb_Medicament.Name = "cmb_Medicament";
            this.cmb_Medicament.Size = new System.Drawing.Size(161, 21);
            this.cmb_Medicament.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medicament";
            // 
            // cmb_Visiteur
            // 
            this.cmb_Visiteur.FormattingEnabled = true;
            this.cmb_Visiteur.Location = new System.Drawing.Point(333, 69);
            this.cmb_Visiteur.Name = "cmb_Visiteur";
            this.cmb_Visiteur.Size = new System.Drawing.Size(161, 21);
            this.cmb_Visiteur.TabIndex = 8;
            // 
            // lbl_visiteur
            // 
            this.lbl_visiteur.AutoSize = true;
            this.lbl_visiteur.Location = new System.Drawing.Point(263, 72);
            this.lbl_visiteur.Name = "lbl_visiteur";
            this.lbl_visiteur.Size = new System.Drawing.Size(41, 13);
            this.lbl_visiteur.TabIndex = 7;
            this.lbl_visiteur.Text = "Visiteur";
            // 
            // dataGridRapports
            // 
            this.dataGridRapports.AllowUserToAddRows = false;
            this.dataGridRapports.AllowUserToDeleteRows = false;
            this.dataGridRapports.AllowUserToResizeColumns = false;
            this.dataGridRapports.AllowUserToResizeRows = false;
            this.dataGridRapports.AutoGenerateColumns = false;
            this.dataGridRapports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRapports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRapports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medecinDataGridViewTextBoxColumn,
            this.visiteurDataGridViewTextBoxColumn,
            this.rapportDataGridViewTextBoxColumn,
            this.medicamentDataGridViewTextBoxColumn,
            this.familleMedicamentDataGridViewTextBoxColumn});
            this.dataGridRapports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridRapports.DataSource = this.visualiserRapportBindingSource;
            this.dataGridRapports.Location = new System.Drawing.Point(12, 177);
            this.dataGridRapports.MultiSelect = false;
            this.dataGridRapports.Name = "dataGridRapports";
            this.dataGridRapports.ReadOnly = true;
            this.dataGridRapports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRapports.Size = new System.Drawing.Size(786, 135);
            this.dataGridRapports.StandardTab = true;
            this.dataGridRapports.TabIndex = 9;
            this.dataGridRapports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRapports_CellContentClick);
            this.dataGridRapports.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRapports_CellContentDoubleClick);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(457, 318);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(115, 23);
            this.btn_Valider.TabIndex = 10;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(212, 318);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(115, 23);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Reinitialiser";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // medecinDataGridViewTextBoxColumn
            // 
            this.medecinDataGridViewTextBoxColumn.DataPropertyName = "Medecin";
            this.medecinDataGridViewTextBoxColumn.HeaderText = "Medecin";
            this.medecinDataGridViewTextBoxColumn.Name = "medecinDataGridViewTextBoxColumn";
            this.medecinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visiteurDataGridViewTextBoxColumn
            // 
            this.visiteurDataGridViewTextBoxColumn.DataPropertyName = "Visiteur";
            this.visiteurDataGridViewTextBoxColumn.HeaderText = "Visiteur";
            this.visiteurDataGridViewTextBoxColumn.Name = "visiteurDataGridViewTextBoxColumn";
            this.visiteurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rapportDataGridViewTextBoxColumn
            // 
            this.rapportDataGridViewTextBoxColumn.DataPropertyName = "Rapport";
            this.rapportDataGridViewTextBoxColumn.HeaderText = "Rapport";
            this.rapportDataGridViewTextBoxColumn.Name = "rapportDataGridViewTextBoxColumn";
            this.rapportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicamentDataGridViewTextBoxColumn
            // 
            this.medicamentDataGridViewTextBoxColumn.DataPropertyName = "Medicament";
            this.medicamentDataGridViewTextBoxColumn.HeaderText = "Medicament";
            this.medicamentDataGridViewTextBoxColumn.Name = "medicamentDataGridViewTextBoxColumn";
            this.medicamentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familleMedicamentDataGridViewTextBoxColumn
            // 
            this.familleMedicamentDataGridViewTextBoxColumn.DataPropertyName = "FamilleMedicament";
            this.familleMedicamentDataGridViewTextBoxColumn.HeaderText = "FamilleMedicament";
            this.familleMedicamentDataGridViewTextBoxColumn.Name = "familleMedicamentDataGridViewTextBoxColumn";
            this.familleMedicamentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visualiserRapportBindingSource
            // 
            this.visualiserRapportBindingSource.DataSource = typeof(gsb_application.VisualiserRapport);
            // 
            // VisualiserRapportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.dataGridRapports);
            this.Controls.Add(this.cmb_Visiteur);
            this.Controls.Add(this.lbl_visiteur);
            this.Controls.Add(this.cmb_Medicament);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_FamilleMedicament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Medecin);
            this.Controls.Add(this.lbl_medecin);
            this.Name = "VisualiserRapportMenu";
            this.Text = "VisualiserRapportMenu";
            this.Load += new System.EventHandler(this.VisualiserRapportMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualiserRapportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_medecin;
        private System.Windows.Forms.ComboBox cmb_Medecin;
        private System.Windows.Forms.ComboBox cmb_FamilleMedicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Medicament;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Visiteur;
        private System.Windows.Forms.Label lbl_visiteur;
        private System.Windows.Forms.DataGridView dataGridRapports;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rapportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource visualiserRapportBindingSource;
    }
}