namespace Interface
{
    partial class FrmConsultationVisite
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultationVisite));
            panelCentral = new Panel();
            dgvVisites = new DataGridView();
            panelDetail = new Panel();
            panelPraticien = new Panel();
            lblPraticien = new Label();
            lblRue = new Label();
            lblTelephone = new Label();
            lblEmail = new Label();
            lblType = new Label();
            lblSpecialite = new Label();
            lblMotif = new Label();
            lblBilan = new Label();
            lblBilanContenu = new Label();
            dgvEchantillon = new DataGridView();
            lstMedicament = new ListBox();

            panelCentral.SuspendLayout();
            panelDetail.SuspendLayout();
            panelPraticien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).BeginInit();
            SuspendLayout();

            // panelCentral
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 98);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1100, 550);
            panelCentral.TabIndex = 13;
            panelCentral.Controls.Add(dgvVisites);
            panelCentral.Controls.Add(panelDetail);

            // dgvVisites
            dgvVisites.Location = new Point(12, 10);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(280, 500);
            dgvVisites.TabIndex = 0;
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.RowHeadersWidth = 50;
            dgvVisites.SelectionChanged += dgvVisites_SelectionChanged;

            // panelDetail
            panelDetail.Location = new Point(305, 10);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(780, 530);
            panelDetail.TabIndex = 1;
            panelDetail.Controls.Add(panelPraticien);
            panelDetail.Controls.Add(lblMotif);
            panelDetail.Controls.Add(lblBilan);
            panelDetail.Controls.Add(lblBilanContenu);
            panelDetail.Controls.Add(dgvEchantillon);
            panelDetail.Controls.Add(lstMedicament);

            // panelPraticien
            panelPraticien.BorderStyle = BorderStyle.FixedSingle;
            panelPraticien.Location = new Point(0, 0);
            panelPraticien.Name = "panelPraticien";
            panelPraticien.Size = new Size(760, 110);
            panelPraticien.TabIndex = 0;
            panelPraticien.Controls.Add(lblPraticien);
            panelPraticien.Controls.Add(lblRue);
            panelPraticien.Controls.Add(lblTelephone);
            panelPraticien.Controls.Add(lblEmail);
            panelPraticien.Controls.Add(lblType);
            panelPraticien.Controls.Add(lblSpecialite);

            // lblPraticien
            lblPraticien.Location = new Point(10, 8);
            lblPraticien.Size = new Size(280, 20);
            lblPraticien.Name = "lblPraticien";

            // lblRue
            lblRue.Location = new Point(10, 32);
            lblRue.Size = new Size(350, 20);
            lblRue.Name = "lblRue";

            // lblTelephone
            lblTelephone.Location = new Point(10, 56);
            lblTelephone.Size = new Size(250, 20);
            lblTelephone.Name = "lblTelephone";

            // lblEmail
            lblEmail.Location = new Point(10, 80);
            lblEmail.Size = new Size(280, 20);
            lblEmail.Name = "lblEmail";

            // lblType
            lblType.Location = new Point(420, 8);
            lblType.Size = new Size(300, 20);
            lblType.Name = "lblType";

            // lblSpecialite
            lblSpecialite.Location = new Point(420, 32);
            lblSpecialite.Size = new Size(300, 40);
            lblSpecialite.Name = "lblSpecialite";

            // lblMotif
            lblMotif.Text = "Motif";
            lblMotif.Location = new Point(0, 125);
            lblMotif.Size = new Size(380, 20);
            lblMotif.Name = "lblMotif";

            // lblBilan (titre)
            lblBilan.Text = "Bilan de la visite";
            lblBilan.Location = new Point(0, 152);
            lblBilan.Size = new Size(150, 20);
            lblBilan.Name = "lblBilan";

            // lblBilanContenu
            lblBilanContenu.Location = new Point(0, 175);
            lblBilanContenu.Size = new Size(380, 130);
            lblBilanContenu.Name = "lblBilanContenu";
            lblBilanContenu.BorderStyle = BorderStyle.FixedSingle;

            // dgvEchantillon
            dgvEchantillon.Location = new Point(420, 125);
            dgvEchantillon.Size = new Size(330, 180);
            dgvEchantillon.Name = "dgvEchantillon";
            dgvEchantillon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEchantillon.TabIndex = 4;

            // lstMedicament
            lstMedicament.Location = new Point(0, 320);
            lstMedicament.Size = new Size(180, 120);
            lstMedicament.Name = "lstMedicament";
            lstMedicament.TabIndex = 5;

            // FrmConsultationVisite
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 680);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmConsultationVisite";
            Text = "Consultation des visites";
            Load += FrmConsultationVisite_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);

            panelPraticien.ResumeLayout(false);
            panelDetail.ResumeLayout(false);
            panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelCentral;
        private Panel panelDetail;
        private DataGridView dgvVisites;
        private Panel panelPraticien;
        private Label lblPraticien;
        private Label lblRue;
        private Label lblTelephone;
        private Label lblEmail;
        private Label lblType;
        private Label lblSpecialite;
        private Label lblMotif;
        private Label lblBilan;
        private Label lblBilanContenu;
        private DataGridView dgvEchantillon;
        private ListBox lstMedicament;
    }
}