using Donnee;
using Interface.Properties;
using Metier;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void FrmConsultationVisite_Resize(object sender, EventArgs e)
        {
            centrerFormulaire();
        }

        private void dgvVisites_SelectionChanged(object sender, EventArgs e)
        {
            afficherVisite();
        }

        private void remplirDgv()
        {
            dgvVisites.Rows.Clear();
            var visites = session.MesVisites.OrderBy(v => v.DateEtHeure);

            foreach (Visite v in visites)
            {
                dgvVisites.Rows.Add(
                    v,
                    v.DateEtHeure.ToShortDateString(),
                    v.DateEtHeure.ToShortTimeString(),
                    v.LePraticien.Ville
                );
            }
        }

        private void afficherVisite()
        {
            if (dgvVisites.SelectedRows.Count == 0) return;

            Visite? v = getVisiteSelectionnee();
            if (v == null) return;

            lblPraticien.Text = v.LePraticien.NomPrenom;
        }

        private Visite? getVisiteSelectionnee()
        {
            if (dgvVisites.SelectedRows.Count == 0) return null;
            return dgvVisites.SelectedRows[0].Cells["Visite"].Value as Visite;
        }

        #endregion

        #region methodes

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
            dgvEchantillon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEchantillon.MultiSelect = false;
            dgvEchantillon.AllowUserToAddRows = false;
            dgvEchantillon.ReadOnly = true;
            dgvEchantillon.Columns.Add("Medicament", "Médicament");
            dgvEchantillon.Columns.Add("Quantite", "Quantité");
            dgvEchantillon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void parametrerDgv(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            #region paramètrage visuel
            dgv.Enabled = true;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.BackgroundColor = Color.White;
            dgv.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Georgia", 11);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            #endregion

            #region paramètrage Header
            dgv.ColumnHeadersVisible = true;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.Font = new Font("Georgia", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
            dgv.RowHeadersVisible = false;
            #endregion

            #region paramètrage des colonnes
            DataGridViewColumn col;

            // Colonne 0 : objet Visite
            col = new DataGridViewTextBoxColumn();
            col.Name = "Visite";
            col.Visible = false;
            dgv.Columns.Add(col);

            // Colonne 1 : Date
            col = new DataGridViewTextBoxColumn();
            col.Name = "Date";
            col.HeaderText = "Programmée le";
            col.Width = 200;
            dgv.Columns.Add(col);

            // Colonne 2 : Heure
            col = new DataGridViewTextBoxColumn();
            col.Name = "Heure";
            col.HeaderText = "à";
            col.Width = 50;
            dgv.Columns.Add(col);

            // Colonne 3 : Lieu
            col = new DataGridViewTextBoxColumn();
            col.Name = "Lieu";
            col.HeaderText = "sur";
            col.Width = 200;
            dgv.Columns.Add(col);

            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            #endregion
        }

        private void remplirDgvVisites()
        {
            dgvVisites.Rows.Clear();
            foreach (Visite v in session.MesVisites
                .Where(v => v.Bilan is null)
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
            {
                ViderAffichage();
            }
        }

        private void ViderAffichage()
        {
            lblPraticien.Text = string.Empty;
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