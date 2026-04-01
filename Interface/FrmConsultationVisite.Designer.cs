namespace Interface
{
    partial class FrmConsultationVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultationVisite));
            panelCentral = new Panel();
            lstMedicament = new ListBox();
            dgvEchantillon = new DataGridView();
            lblBilan = new Label();
            lblMotif = new Label();
            panelPraticien = new Panel();
            lblSpecialite = new Label();
            lblType = new Label();
            lblEmail = new Label();
            lblTelephone = new Label();
            lblRue = new Label();
            lblPraticien = new Label();
            dgvVisites = new DataGridView();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).BeginInit();
            panelPraticien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            lblTitre.Text = "Consultation des visites";
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(lstMedicament);
            panelCentral.Controls.Add(dgvEchantillon);
            panelCentral.Controls.Add(lblBilan);
            panelCentral.Controls.Add(lblMotif);
            panelCentral.Controls.Add(panelPraticien);
            panelCentral.Controls.Add(dgvVisites);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 98);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(800, 307);
            panelCentral.TabIndex = 13;
            // 
            // lstMedicament
            // 
            lstMedicament.FormattingEnabled = true;
            lstMedicament.Location = new Point(243, 221);
            lstMedicament.Name = "lstMedicament";
            lstMedicament.Size = new Size(120, 79);
            lstMedicament.TabIndex = 5;
            // 
            // dgvEchantillon
            // 
            dgvEchantillon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEchantillon.Location = new Point(568, 154);
            dgvEchantillon.Name = "dgvEchantillon";
            dgvEchantillon.Size = new Size(200, 117);
            dgvEchantillon.TabIndex = 4;
            // 
            // lblBilan
            // 
            lblBilan.AutoSize = true;
            lblBilan.Location = new Point(243, 130);
            lblBilan.Name = "lblBilan";
            lblBilan.Size = new Size(91, 15);
            lblBilan.TabIndex = 3;
            lblBilan.Text = "Bilan de la visite";
            // 
            // lblMotif
            // 
            lblMotif.AutoSize = true;
            lblMotif.Location = new Point(243, 104);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(36, 15);
            lblMotif.TabIndex = 2;
            lblMotif.Text = "Motif";
            // 
            // panelPraticien
            // 
            panelPraticien.Controls.Add(lblSpecialite);
            panelPraticien.Controls.Add(lblType);
            panelPraticien.Controls.Add(lblEmail);
            panelPraticien.Controls.Add(lblTelephone);
            panelPraticien.Controls.Add(lblRue);
            panelPraticien.Controls.Add(lblPraticien);
            panelPraticien.Location = new Point(243, 33);
            panelPraticien.Name = "panelPraticien";
            panelPraticien.Size = new Size(525, 68);
            panelPraticien.TabIndex = 1;
            // 
            // lblSpecialite
            // 
            lblSpecialite.Location = new Point(265, 27);
            lblSpecialite.Name = "lblSpecialite";
            lblSpecialite.Size = new Size(100, 23);
            lblSpecialite.TabIndex = 5;
            lblSpecialite.Text = "label1";
            // 
            // lblType
            // 
            lblType.Location = new Point(265, 5);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 23);
            lblType.TabIndex = 4;
            lblType.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(21, 50);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "label1";
            // 
            // lblTelephone
            // 
            lblTelephone.Location = new Point(21, 35);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(38, 15);
            lblTelephone.TabIndex = 2;
            lblTelephone.Text = "label1";
            // 
            // lblRue
            // 
            lblRue.Location = new Point(21, 20);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(38, 15);
            lblRue.TabIndex = 1;
            lblRue.Text = "label1";
            // 
            // lblPraticien
            // 
            lblPraticien.Location = new Point(21, 5);
            lblPraticien.Name = "lblPraticien";
            lblPraticien.Size = new Size(38, 15);
            lblPraticien.TabIndex = 0;
            lblPraticien.Text = "label1";
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Location = new Point(12, 21);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.RowHeadersWidth = 50;
            dgvVisites.Size = new Size(216, 267);
            dgvVisites.TabIndex = 0;
            // 
            // FrmConsultationVisite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmConsultationVisite";
            Text = "Form1";
            Load += FrmConsultationVisite_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).EndInit();
            panelPraticien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private DataGridView dgvVisites;
        private Panel panelPraticien;
        private Label lblTelephone;
        private Label lblRue;
        private Label lblPraticien;
        private Label lblEmail;
        private Label lblBilan;
        private Label lblMotif;
        private Label lblSpecialite;
        private Label lblType;
        private ListBox lstMedicament;
        private DataGridView dgvEchantillon;
    }
}