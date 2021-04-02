
namespace gsb_application
{
    partial class VisualiserRapport
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
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_medecin = new System.Windows.Forms.Label();
            this.lbl_visiteur = new System.Windows.Forms.Label();
            this.lbl_medicament = new System.Windows.Forms.Label();
            this.dTP_dateV = new System.Windows.Forms.DateTimePicker();
            this.cmb_medecin = new System.Windows.Forms.ComboBox();
            this.cmb_visiteur = new System.Windows.Forms.ComboBox();
            this.cmb_medicament = new System.Windows.Forms.ComboBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gsb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gsb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(12, 32);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(44, 20);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // lbl_medecin
            // 
            this.lbl_medecin.AutoSize = true;
            this.lbl_medecin.Location = new System.Drawing.Point(12, 65);
            this.lbl_medecin.Name = "lbl_medecin";
            this.lbl_medecin.Size = new System.Drawing.Size(69, 20);
            this.lbl_medecin.TabIndex = 1;
            this.lbl_medecin.Text = "Médecin";
            // 
            // lbl_visiteur
            // 
            this.lbl_visiteur.AutoSize = true;
            this.lbl_visiteur.Location = new System.Drawing.Point(7, 110);
            this.lbl_visiteur.Name = "lbl_visiteur";
            this.lbl_visiteur.Size = new System.Drawing.Size(62, 20);
            this.lbl_visiteur.TabIndex = 2;
            this.lbl_visiteur.Text = "Visiteur";
            // 
            // lbl_medicament
            // 
            this.lbl_medicament.AutoSize = true;
            this.lbl_medicament.Location = new System.Drawing.Point(7, 157);
            this.lbl_medicament.Name = "lbl_medicament";
            this.lbl_medicament.Size = new System.Drawing.Size(96, 20);
            this.lbl_medicament.TabIndex = 3;
            this.lbl_medicament.Text = "Médicament";
            // 
            // dTP_dateV
            // 
            this.dTP_dateV.Location = new System.Drawing.Point(110, 32);
            this.dTP_dateV.Name = "dTP_dateV";
            this.dTP_dateV.Size = new System.Drawing.Size(200, 26);
            this.dTP_dateV.TabIndex = 4;
            // 
            // cmb_medecin
            // 
            this.cmb_medecin.FormattingEnabled = true;
            this.cmb_medecin.Location = new System.Drawing.Point(109, 64);
            this.cmb_medecin.Name = "cmb_medecin";
            this.cmb_medecin.Size = new System.Drawing.Size(201, 28);
            this.cmb_medecin.TabIndex = 5;
            this.cmb_medecin.SelectedIndexChanged += new System.EventHandler(this.cmb_medecin_SelectedIndexChanged);
            // 
            // cmb_visiteur
            // 
            this.cmb_visiteur.FormattingEnabled = true;
            this.cmb_visiteur.Location = new System.Drawing.Point(109, 107);
            this.cmb_visiteur.Name = "cmb_visiteur";
            this.cmb_visiteur.Size = new System.Drawing.Size(201, 28);
            this.cmb_visiteur.TabIndex = 6;
            // 
            // cmb_medicament
            // 
            this.cmb_medicament.FormattingEnabled = true;
            this.cmb_medicament.Location = new System.Drawing.Point(109, 154);
            this.cmb_medicament.Name = "cmb_medicament";
            this.cmb_medicament.Size = new System.Drawing.Size(201, 28);
            this.cmb_medicament.TabIndex = 7;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(220, 276);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(173, 47);
            this.btn_valider.TabIndex = 8;
            this.btn_valider.Text = "VALIDER";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gsb_logo
            // 
            this.gsb_logo.Image = global::gsb_application.Properties.Resources.logo;
            this.gsb_logo.Location = new System.Drawing.Point(527, 12);
            this.gsb_logo.Name = "gsb_logo";
            this.gsb_logo.Size = new System.Drawing.Size(261, 193);
            this.gsb_logo.TabIndex = 9;
            this.gsb_logo.TabStop = false;
            // 
            // VisualiserRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gsb_logo);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.cmb_medicament);
            this.Controls.Add(this.cmb_visiteur);
            this.Controls.Add(this.cmb_medecin);
            this.Controls.Add(this.dTP_dateV);
            this.Controls.Add(this.lbl_medicament);
            this.Controls.Add(this.lbl_visiteur);
            this.Controls.Add(this.lbl_medecin);
            this.Controls.Add(this.lbl_date);
            this.Name = "VisualiserRapport";
            this.Text = "VisualiserRapport";
            this.Load += new System.EventHandler(this.VisualiserRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gsb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_medecin;
        private System.Windows.Forms.Label lbl_visiteur;
        private System.Windows.Forms.Label lbl_medicament;
        private System.Windows.Forms.DateTimePicker dTP_dateV;
        private System.Windows.Forms.ComboBox cmb_medecin;
        private System.Windows.Forms.ComboBox cmb_visiteur;
        private System.Windows.Forms.ComboBox cmb_medicament;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox gsb_logo;
    }
}