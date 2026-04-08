using Donnee;
using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmPraticienAjout : FrmBase
    {
        public FrmPraticienAjout(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
            this.parametrerComposant();
        }

        #region Procedures

        private void centrerFormulaire()
        {
            if (panelCentral != null)
            {
                panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
            }
        }

        private void FrmPraticienAjout_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            centrerFormulaire();
        }

        private void FrmPraticienAjout_Resize(object sender, EventArgs e)
        {
            centrerFormulaire();
        }

        #endregion

        #region Methodes

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Ajouter un Praticien";
            centrerFormulaire();

            var source = new AutoCompleteStringCollection();
            if (session?.MesVilles != null)
            {
                foreach (Ville ville in session.MesVilles)
                {
                    source.Add(ville.Nom);
                }
            }
            txtVille.AutoCompleteCustomSource = source;

            messageNom.Visible = false;
            messagePrenom.Visible = false;
            messageRue.Visible = false;
            messageVille.Visible = false;
            messageTelephone.Visible = false;
            messageMail.Visible = false;
            messageType.Visible = false;
            messageSpecialite.Visible = false;
        }

        private bool controlerChamp(TextBox txt, Label lblMessage, string message)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                lblMessage.Text = message;
                lblMessage.Visible = true;
                return false;
            }
            lblMessage.Text = string.Empty;
            lblMessage.Visible = false;
            return true;
        }

        private bool controlerVille()
        {
            if (string.IsNullOrWhiteSpace(txtVille.Text))
            {
                messageVille.Text = "La ville du praticien doit être précisée";
                messageVille.Visible = true;
                return false;
            }

            Ville? laVille = session!.MesVilles.Find(x => x.Nom == txtVille.Text);
            if (laVille is null)
            {
                messageVille.Text = "La ville saisie n'est pas valide";
                messageVille.Visible = true;
                return false;
            }

            messageVille.Text = string.Empty;
            messageVille.Visible = false;
            return true;
        }

        private bool controlerTelephone()
        {
            if (!mtbTelephone.MaskFull)
            {
                messageTelephone.Text = "Le téléphone du praticien doit être précisé";
                messageTelephone.Visible = true;
                return false;
            }
            messageTelephone.Visible = false;
            return true;
        }

        private bool controlerEmail()
        {
            if (txtMail.Text == string.Empty)
            {
                messageMail.Text = "L'adresse mail du praticien doit être précisée";
                messageMail.Visible = true;
                return false;
            }

            Regex uneExpression = new(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            if (!uneExpression.IsMatch(txtMail.Text))
            {
                messageMail.Text = "L'adresse mail n'est pas valide";
                messageMail.Visible = true;
                return false;
            }

            messageMail.Text = string.Empty;
            messageMail.Visible = false;
            return true;
        }

        private bool controlerType()
        {
            if (cbxType.SelectedIndex == -1)
            {
                messageType.Text = "Veuillez sélectionner le type de praticien.";
                messageType.Visible = true;
                return false;
            }
            messageType.Text = string.Empty;
            messageType.Visible = false;
            return true;
        }

        private void ajout()
        {
            bool nomOk = controlerChamp(txtNom, messageNom, "Le nom du praticien doit être précisé");
            bool prenomOk = controlerChamp(txtPrenom, messagePrenom, "Le prénom du praticien doit être précisé");
            bool rueOk = controlerChamp(txtRue, messageRue, "La rue du praticien doit être précisée");
            bool villeOk = controlerVille();
            bool emailOk = controlerEmail();
            bool telephoneOk = controlerTelephone();
            bool typeOk = controlerType();

            if (nomOk && prenomOk && rueOk && villeOk && emailOk && telephoneOk && typeOk)
            {
                ajouter();
            }
        }

        private void ajouter()
        {
            try
            {
                string nom = txtNom.Text.Trim();
                string prenom = txtPrenom.Text.Trim();
                string rue = txtRue.Text.Trim();
                string ville = txtVille.Text;
                string telephone = mtbTelephone.Text.Trim();
                string email = txtMail.Text.Trim();

                Ville laVille = session!.MesVilles.Find(x => x.Nom == txtVille.Text)!;
                string codePostal = laVille.Code;

                string idType = ((TypePraticien)cbxType.SelectedItem!).Id;
                string? idSpecialite = cbxSpecialite.SelectedIndex == -1
                    ? null
                    : ((Specialite)cbxSpecialite.SelectedItem!).Id;

                int id = Passerelle.ajouterPraticien(nom, prenom, rue, codePostal, laVille.Nom, telephone, email, idType, idSpecialite);

                TypePraticien? leType = session.LesTypesPraticien.Find(x => x.Id == idType);
                Specialite? laSpecialite = idSpecialite is null
                    ? null
                    : session.LesSpecialites.Find(x => x.Id == idSpecialite);

                Praticien unPraticien = new(id, nom, prenom, rue, codePostal, laVille.Nom, email, telephone, leType, laSpecialite);
                session.MesPraticiens.Add(unPraticien);
                session.MesPraticiens.Sort();

                viderChamps();
                MessageBox.Show("Le praticien a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'ajout du praticien : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void viderChamps()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtRue.Clear();
            txtVille.Clear();
            txtMail.Clear();
            mtbTelephone.Clear();
            cbxType.SelectedIndex = -1;
            cbxSpecialite.SelectedIndex = -1;
        }

        #endregion
    }
}