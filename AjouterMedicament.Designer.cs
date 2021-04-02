
namespace gsb_application
{
    partial class AjouterMedicament
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
            this.grp_medicament = new System.Windows.Forms.GroupBox();
            this.cmb_medicament = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_qteMedicament = new System.Windows.Forms.ComboBox();
            this.cmb_familleMedicament = new System.Windows.Forms.ComboBox();
            this.lbl_qteMedicament = new System.Windows.Forms.Label();
            this.lbl_familleMedicament = new System.Windows.Forms.Label();
            this.btn_validerNouveauMedicament = new System.Windows.Forms.Button();
            this.bndSrcMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.bndSrcFamilleMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.txt_contreIndications = new System.Windows.Forms.RichTextBox();
            this.txt_effets = new System.Windows.Forms.RichTextBox();
            this.txt_composition = new System.Windows.Forms.TextBox();
            this.lbl_contreIndication = new System.Windows.Forms.Label();
            this.lbl_effets = new System.Windows.Forms.Label();
            this.lbl_composition = new System.Windows.Forms.Label();
            this.grp_medicament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcFamilleMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_medicament
            // 
            this.grp_medicament.Controls.Add(this.lbl_composition);
            this.grp_medicament.Controls.Add(this.lbl_effets);
            this.grp_medicament.Controls.Add(this.lbl_contreIndication);
            this.grp_medicament.Controls.Add(this.btn_validerNouveauMedicament);
            this.grp_medicament.Controls.Add(this.txt_composition);
            this.grp_medicament.Controls.Add(this.txt_effets);
            this.grp_medicament.Controls.Add(this.txt_contreIndications);
            this.grp_medicament.Controls.Add(this.cmb_medicament);
            this.grp_medicament.Controls.Add(this.label1);
            this.grp_medicament.Controls.Add(this.cmb_qteMedicament);
            this.grp_medicament.Controls.Add(this.cmb_familleMedicament);
            this.grp_medicament.Controls.Add(this.lbl_qteMedicament);
            this.grp_medicament.Controls.Add(this.lbl_familleMedicament);
            this.grp_medicament.Location = new System.Drawing.Point(99, 74);
            this.grp_medicament.Name = "grp_medicament";
            this.grp_medicament.Size = new System.Drawing.Size(603, 318);
            this.grp_medicament.TabIndex = 5;
            this.grp_medicament.TabStop = false;
            this.grp_medicament.Text = "Medicament";
            // 
            // cmb_medicament
            // 
            this.cmb_medicament.FormattingEnabled = true;
            this.cmb_medicament.Location = new System.Drawing.Point(394, 25);
            this.cmb_medicament.Name = "cmb_medicament";
            this.cmb_medicament.Size = new System.Drawing.Size(153, 21);
            this.cmb_medicament.TabIndex = 6;
            this.cmb_medicament.SelectedIndexChanged += new System.EventHandler(this.cmb_medicament_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medicament";
            // 
            // cmb_qteMedicament
            // 
            this.cmb_qteMedicament.FormattingEnabled = true;
            this.cmb_qteMedicament.Location = new System.Drawing.Point(142, 56);
            this.cmb_qteMedicament.Name = "cmb_qteMedicament";
            this.cmb_qteMedicament.Size = new System.Drawing.Size(50, 21);
            this.cmb_qteMedicament.TabIndex = 4;
            this.cmb_qteMedicament.SelectedIndexChanged += new System.EventHandler(this.cmb_qteMedicament_SelectedIndexChanged);
            // 
            // cmb_familleMedicament
            // 
            this.cmb_familleMedicament.FormattingEnabled = true;
            this.cmb_familleMedicament.Location = new System.Drawing.Point(142, 25);
            this.cmb_familleMedicament.Name = "cmb_familleMedicament";
            this.cmb_familleMedicament.Size = new System.Drawing.Size(153, 21);
            this.cmb_familleMedicament.TabIndex = 3;
            this.cmb_familleMedicament.SelectedIndexChanged += new System.EventHandler(this.cmb_familleMedicament_SelectedIndexChanged);
            // 
            // lbl_qteMedicament
            // 
            this.lbl_qteMedicament.AutoSize = true;
            this.lbl_qteMedicament.Location = new System.Drawing.Point(71, 56);
            this.lbl_qteMedicament.Name = "lbl_qteMedicament";
            this.lbl_qteMedicament.Size = new System.Drawing.Size(47, 13);
            this.lbl_qteMedicament.TabIndex = 2;
            this.lbl_qteMedicament.Text = "Quantité";
            // 
            // lbl_familleMedicament
            // 
            this.lbl_familleMedicament.AutoSize = true;
            this.lbl_familleMedicament.Location = new System.Drawing.Point(71, 28);
            this.lbl_familleMedicament.Name = "lbl_familleMedicament";
            this.lbl_familleMedicament.Size = new System.Drawing.Size(39, 13);
            this.lbl_familleMedicament.TabIndex = 0;
            this.lbl_familleMedicament.Text = "Famille";
            // 
            // btn_validerNouveauMedicament
            // 
            this.btn_validerNouveauMedicament.Location = new System.Drawing.Point(226, 278);
            this.btn_validerNouveauMedicament.Name = "btn_validerNouveauMedicament";
            this.btn_validerNouveauMedicament.Size = new System.Drawing.Size(140, 23);
            this.btn_validerNouveauMedicament.TabIndex = 6;
            this.btn_validerNouveauMedicament.Text = "Valider";
            this.btn_validerNouveauMedicament.UseVisualStyleBackColor = true;
            this.btn_validerNouveauMedicament.Click += new System.EventHandler(this.btn_validerNouveauMedicament_Click);
            // 
            // bndSrcMedicament
            // 
            this.bndSrcMedicament.DataSource = typeof(gsb_application.medicament);
            // 
            // bndSrcFamilleMedicament
            // 
            this.bndSrcFamilleMedicament.DataSource = typeof(gsb_application.famille);
            // 
            // txt_contreIndications
            // 
            this.txt_contreIndications.Location = new System.Drawing.Point(18, 176);
            this.txt_contreIndications.Name = "txt_contreIndications";
            this.txt_contreIndications.ReadOnly = true;
            this.txt_contreIndications.Size = new System.Drawing.Size(277, 96);
            this.txt_contreIndications.TabIndex = 7;
            this.txt_contreIndications.Text = "";
            // 
            // txt_effets
            // 
            this.txt_effets.Location = new System.Drawing.Point(301, 176);
            this.txt_effets.Name = "txt_effets";
            this.txt_effets.ReadOnly = true;
            this.txt_effets.Size = new System.Drawing.Size(277, 96);
            this.txt_effets.TabIndex = 8;
            this.txt_effets.Text = "";
            // 
            // txt_composition
            // 
            this.txt_composition.Location = new System.Drawing.Point(18, 112);
            this.txt_composition.Name = "txt_composition";
            this.txt_composition.ReadOnly = true;
            this.txt_composition.Size = new System.Drawing.Size(559, 20);
            this.txt_composition.TabIndex = 9;
            // 
            // lbl_contreIndication
            // 
            this.lbl_contreIndication.AutoSize = true;
            this.lbl_contreIndication.Location = new System.Drawing.Point(15, 160);
            this.lbl_contreIndication.Name = "lbl_contreIndication";
            this.lbl_contreIndication.Size = new System.Drawing.Size(86, 13);
            this.lbl_contreIndication.TabIndex = 10;
            this.lbl_contreIndication.Text = "Contre-indication";
            // 
            // lbl_effets
            // 
            this.lbl_effets.AutoSize = true;
            this.lbl_effets.Location = new System.Drawing.Point(302, 160);
            this.lbl_effets.Name = "lbl_effets";
            this.lbl_effets.Size = new System.Drawing.Size(34, 13);
            this.lbl_effets.TabIndex = 11;
            this.lbl_effets.Text = "Effets";
            // 
            // lbl_composition
            // 
            this.lbl_composition.AutoEllipsis = true;
            this.lbl_composition.AutoSize = true;
            this.lbl_composition.Location = new System.Drawing.Point(15, 96);
            this.lbl_composition.Name = "lbl_composition";
            this.lbl_composition.Size = new System.Drawing.Size(64, 13);
            this.lbl_composition.TabIndex = 12;
            this.lbl_composition.Text = "Composition";
            // 
            // AjouterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.grp_medicament);
            this.Name = "AjouterMedicament";
            this.Text = "AjouterMedicament";
            this.Load += new System.EventHandler(this.AjouterMedicament_Load);
            this.grp_medicament.ResumeLayout(false);
            this.grp_medicament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndSrcFamilleMedicament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_medicament;
        private System.Windows.Forms.ComboBox cmb_medicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_qteMedicament;
        private System.Windows.Forms.ComboBox cmb_familleMedicament;
        private System.Windows.Forms.Label lbl_qteMedicament;
        private System.Windows.Forms.Label lbl_familleMedicament;
        private System.Windows.Forms.Button btn_validerNouveauMedicament;
        private System.Windows.Forms.BindingSource bndSrcMedicament;
        private System.Windows.Forms.BindingSource bndSrcFamilleMedicament;
        private System.Windows.Forms.Label lbl_composition;
        private System.Windows.Forms.Label lbl_effets;
        private System.Windows.Forms.Label lbl_contreIndication;
        private System.Windows.Forms.TextBox txt_composition;
        private System.Windows.Forms.RichTextBox txt_effets;
        private System.Windows.Forms.RichTextBox txt_contreIndications;
    }
}