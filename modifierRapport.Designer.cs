
namespace gsb_application
{
    partial class modifierRapport
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
            this.gb_med_qte = new System.Windows.Forms.GroupBox();
            this.lbl_medicament = new System.Windows.Forms.Label();
            this.qté = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmb_qte = new System.Windows.Forms.ComboBox();
            this.gb_date = new System.Windows.Forms.GroupBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_valider = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gb_med_qte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_med_qte
            // 
            this.gb_med_qte.Controls.Add(this.cmb_qte);
            this.gb_med_qte.Controls.Add(this.dataGridView2);
            this.gb_med_qte.Controls.Add(this.qté);
            this.gb_med_qte.Controls.Add(this.lbl_medicament);
            this.gb_med_qte.Location = new System.Drawing.Point(238, 129);
            this.gb_med_qte.Name = "gb_med_qte";
            this.gb_med_qte.Size = new System.Drawing.Size(458, 145);
            this.gb_med_qte.TabIndex = 0;
            this.gb_med_qte.TabStop = false;
            // 
            // lbl_medicament
            // 
            this.lbl_medicament.AutoSize = true;
            this.lbl_medicament.Location = new System.Drawing.Point(15, 42);
            this.lbl_medicament.Name = "lbl_medicament";
            this.lbl_medicament.Size = new System.Drawing.Size(96, 20);
            this.lbl_medicament.TabIndex = 0;
            this.lbl_medicament.Text = "Médicament";
            this.lbl_medicament.Click += new System.EventHandler(this.label1_Click);
            // 
            // qté
            // 
            this.qté.AutoSize = true;
            this.qté.Location = new System.Drawing.Point(15, 90);
            this.qté.Name = "qté";
            this.qté.Size = new System.Drawing.Size(67, 20);
            this.qté.TabIndex = 1;
            this.qté.Text = "quantité";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(117, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(142, 30);
            this.dataGridView2.TabIndex = 3;
            // 
            // cmb_qte
            // 
            this.cmb_qte.FormattingEnabled = true;
            this.cmb_qte.Location = new System.Drawing.Point(117, 82);
            this.cmb_qte.Name = "cmb_qte";
            this.cmb_qte.Size = new System.Drawing.Size(142, 28);
            this.cmb_qte.TabIndex = 4;
            // 
            // gb_date
            // 
            this.gb_date.Controls.Add(this.dateTimePicker1);
            this.gb_date.Controls.Add(this.lbl_date);
            this.gb_date.Location = new System.Drawing.Point(238, 306);
            this.gb_date.Name = "gb_date";
            this.gb_date.Size = new System.Drawing.Size(458, 95);
            this.gb_date.TabIndex = 1;
            this.gb_date.TabStop = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(37, 47);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(45, 20);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "date ";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(147, 108);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(403, 425);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(179, 41);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "VALIDER";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gsb_application.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(720, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 164);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // modifierRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_date);
            this.Controls.Add(this.gb_med_qte);
            this.Name = "modifierRapport";
            this.Text = "modifierRapport";
            this.Load += new System.EventHandler(this.modifierRapport_Load);
            this.gb_med_qte.ResumeLayout(false);
            this.gb_med_qte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_date.ResumeLayout(false);
            this.gb_date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_med_qte;
        private System.Windows.Forms.Label qté;
        private System.Windows.Forms.Label lbl_medicament;
        private System.Windows.Forms.ComboBox cmb_qte;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gb_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}