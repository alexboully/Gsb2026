using Donnee;
using Interface.Properties;
using Metier;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmConsultationVisite : FrmBase
    {
        public FrmConsultationVisite(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        #region Procedures

        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        private void FrmConsultationVisite_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            centrerFormulaire();
            remplirDgvVisites();
            afficher();
        }

        private void FrmConsultationVisite_Resize(object sender, EventArgs e)
        {
            centrerFormulaire();
        }

        private void dgvVisites_SelectionChanged(object sender, EventArgs e)
        {
            afficherVisite();
        }

        private void afficherVisite()
        {
            if (dgvVisites.SelectedRows.Count == 0) return;

            Visite? v = getVisiteSelectionnee();
            if (v == null) return;

            lblPraticien.Text = v.LePraticien.NomPrenom;
            lblRue.Text = v.LePraticien.Rue + ", " + v.LePraticien.CodePostal + " " + v.LePraticien.Ville;
            lblTelephone.Text = v.LePraticien.Telephone;
            lblEmail.Text = v.LePraticien.Email;
            lblType.Text = v.LePraticien.Type?.Libelle ?? string.Empty;
            lblSpecialite.Text = v.LePraticien.Specialite?.Libelle ?? string.Empty;

            lblMotif.Text = "Motif     " + v.LeMotif.Libelle;
            lblBilanContenu.Text = v.Bilan ?? string.Empty;

            lstMedicament.Items.Clear();
            if (v.PremierMedicament != null)
                lstMedicament.Items.Add(v.PremierMedicament.Nom);
            if (v.SecondMedicament != null)
                lstMedicament.Items.Add(v.SecondMedicament.Nom);

            // Remplissage échantillons uniquement
            dgvEchantillon.Rows.Clear();
            foreach (var e in v)
            {
                dgvEchantillon.Rows.Add(e.Key.Nom, e.Value);
            }
        }

        private Visite? getVisiteSelectionnee()
        {
            if (dgvVisites.SelectedRows.Count == 0) return null;
            return dgvVisites.SelectedRows[0].Cells["Visite"].Value as Visite;
        }

        #endregion

        #region Methodes

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Consultation des visites";
            centrerFormulaire();
            parametrerDgvEchantillons();
            parametrerDgv(dgvVisites);
        }

        private void parametrerDgvEchantillons()
        {
            dgvEchantillon.Columns.Clear();
            dgvEchantillon.Rows.Clear();
            dgvEchantillon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEchantillon.MultiSelect = false;
            dgvEchantillon.AllowUserToAddRows = false;
            dgvEchantillon.ReadOnly = true;
            dgvEchantillon.BorderStyle = BorderStyle.FixedSingle;
            dgvEchantillon.BackgroundColor = Color.White;
            dgvEchantillon.RowHeadersVisible = false;
            dgvEchantillon.EnableHeadersVisualStyles = false;
            dgvEchantillon.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvEchantillon.ColumnHeadersHeight = 30;
            dgvEchantillon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEchantillon.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvEchantillon.AllowUserToDeleteRows = false;

            DataGridViewColumn col;

            col = new DataGridViewTextBoxColumn();
            col.Name = "Nom";
            col.HeaderText = "Nom";
            dgvEchantillon.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Quantite";
            col.HeaderText = "Quantité";
            dgvEchantillon.Columns.Add(col);

            dgvEchantillon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < dgvEchantillon.ColumnCount; i++)
                dgvEchantillon.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void parametrerDgv(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            dgv.Enabled = true;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.BackgroundColor = Color.White;
            dgv.ForeColor = Color.Black;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.ColumnHeadersVisible = true;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.ColumnHeadersHeight = 40;
            dgv.RowHeadersVisible = false;

            DataGridViewColumn col;

            col = new DataGridViewTextBoxColumn();
            col.Name = "Visite";
            col.Visible = false;
            dgv.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Date";
            col.HeaderText = "Programmée le";
            dgv.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Heure";
            col.HeaderText = "à";
            dgv.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.Name = "Lieu";
            col.HeaderText = "sur";
            dgv.Columns.Add(col);

            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void remplirDgvVisites()
        {
            dgvVisites.Rows.Clear();
            foreach (Visite v in session.MesVisites
                .OrderBy(v => v.DateEtHeure))
            {
                dgvVisites.Rows.Add(
                    v,
                    v.DateEtHeure.ToShortDateString(),
                    v.DateEtHeure.ToLongTimeString(),
                    v.LePraticien.Ville
                );
            }
        }

        private void afficher()
        {
            if (dgvVisites.Rows.Count == 0 || dgvVisites.SelectedRows.Count == 0)
                ViderAffichage();
        }

        private void ViderAffichage()
        {
            lblPraticien.Text = string.Empty;
            lblRue.Text = string.Empty;
            lblTelephone.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblType.Text = string.Empty;
            lblSpecialite.Text = string.Empty;
            lblMotif.Text = "Motif";
            lblBilanContenu.Text = string.Empty;
            lstMedicament.Items.Clear();
            dgvEchantillon.Rows.Clear();
        }

        private Visite? getVisite()
        {
            if (dgvVisites.SelectedRows.Count == 0) return null;
            return dgvVisites.SelectedRows[0].Cells["Visite"].Value as Visite;
        }

        #endregion
    }
}