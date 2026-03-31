namespace Interface
{
    partial class FrmVisiteImpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteImpression));
            panelCentral = new Panel();
            imgGsb = new PictureBox();
            panelSaisie = new Panel();
            messageInterval = new Label();
            message = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            imgImprimer = new PictureBox();
            imgApercu = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgGsb).BeginInit();
            panelSaisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgImprimer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgApercu).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(934, 86);
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(imgGsb);
            panelCentral.Controls.Add(panelSaisie);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 110);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(934, 373);
            panelCentral.TabIndex = 13;
            // 
            // imgGsb
            // 
            imgGsb.Image = Properties.Resources.logoGSB;
            imgGsb.Location = new Point(53, 46);
            imgGsb.Name = "imgGsb";
            imgGsb.Size = new Size(407, 265);
            imgGsb.TabIndex = 1;
            imgGsb.TabStop = false;
            // 
            // panelSaisie
            // 
            panelSaisie.Controls.Add(messageInterval);
            panelSaisie.Controls.Add(message);
            panelSaisie.Controls.Add(dateTimePicker2);
            panelSaisie.Controls.Add(dateTimePicker1);
            panelSaisie.Controls.Add(imgImprimer);
            panelSaisie.Controls.Add(imgApercu);
            panelSaisie.Location = new Point(494, 24);
            panelSaisie.Name = "panelSaisie";
            panelSaisie.Size = new Size(414, 318);
            panelSaisie.TabIndex = 0;
            // 
            // messageInterval
            // 
            messageInterval.AutoSize = true;
            messageInterval.Location = new Point(62, 113);
            messageInterval.Name = "messageInterval";
            messageInterval.Size = new Size(22, 15);
            messageInterval.TabIndex = 5;
            messageInterval.Text = "Au";
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(62, 37);
            message.Name = "message";
            message.Size = new Size(22, 15);
            message.TabIndex = 4;
            message.Text = "Du";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(90, 107);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(90, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // imgImprimer
            // 
            imgImprimer.Image = Properties.Resources.imprimer;
            imgImprimer.Location = new Point(226, 176);
            imgImprimer.Name = "imgImprimer";
            imgImprimer.Size = new Size(102, 111);
            imgImprimer.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImprimer.TabIndex = 1;
            imgImprimer.TabStop = false;
            // 
            // imgApercu
            // 
            imgApercu.Image = Properties.Resources.apercu;
            imgApercu.Location = new Point(50, 176);
            imgApercu.Name = "imgApercu";
            imgApercu.Size = new Size(124, 111);
            imgApercu.SizeMode = PictureBoxSizeMode.StretchImage;
            imgApercu.TabIndex = 0;
            imgApercu.TabStop = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // FrmVisiteImpression
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 528);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteImpression";
            Text = "Form1";
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgGsb).EndInit();
            panelSaisie.ResumeLayout(false);
            panelSaisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgImprimer).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgApercu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Procedures


        #endregion


        private Panel panelCentral;
        private PictureBox pictureBox1;
        private Panel panelSaisie;
        private PictureBox imgApercu;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private PictureBox imgImprimer;
        private PictureBox imgGsb;
        private Label message;
        private Label messageInterval;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}