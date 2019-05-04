using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionPersonneLib;
using ManageSingleConnexion;

namespace GestionPersonneGUI
{
    public partial class FrmTelephone : Form
    {
        public FrmTelephone()
        {
            InitializeComponent();
        }

        private void FrmTelephone_Load(object sender, EventArgs e)
        {
            //Chargement du ComboBox des personnes
            try
            {
                IPersonne p = new Personne();

                cboPersonne.DataSource = p.Personnes();
                cboPersonne.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboPersonne.AutoCompleteSource = AutoCompleteSource.ListItems;
                cboPersonne.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec du chargement des personnes, " + ex.Message, "Chargement des personnes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                ImplementeConnexion.Instance.Conn.Close();
            }

            //Chargement du DataGrid des téléphones
            try
            {
                RefreshDG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec du chargement des personnes, " + ex.Message, "Chargement des personnes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                ImplementeConnexion.Instance.Conn.Close();
            }
        }

        private void RefreshDG()
        {
            ITelephone t = new Telephone();
            dgvTelephone.DataSource = t.Telephones();
        }

        private void BindValuesTelephone(ITelephone t)
        {
            t.Id = int.Parse(txtId.Text);
            t.Initial = txtInitial.Text;
            t.Numero = txtNumero.Text;
            t.Id_proprietaire = ((IPersonne)cboPersonne.SelectedItem).Id;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                ITelephone telephone = new Telephone();
                txtId.Text = telephone.Nouveau().ToString();

                txtInitial.Clear();
                txtNumero.Clear();
                cboPersonne.SelectedIndex = 0;
                cboPersonne.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec Génération ID, " + ex.Message, "Génération ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                ImplementeConnexion.Instance.Conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ITelephone t = new Telephone();

                this.BindValuesTelephone(t);

                t.Enregistrer(t);

                MessageBox.Show("Mise à jour effectué", "Mise à jour personne", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.RefreshDG();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de mise à jour, " + ex.Message, "Mise à jour personne", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                ImplementeConnexion.Instance.Conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez-vous supprimer cet enregistrement ?", "Suppression personne", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ITelephone t = new Telephone();
                    t.Id = int.Parse(txtId.Text);
                    t.Supprimer(t.Id);

                    MessageBox.Show("Suppresion effectué", "Suppresion personne", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.RefreshDG();
                }
                else
                    MessageBox.Show("Suppression Annulée", "Suppresion personne", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de suppression " + ex.Message, "Suppresion personne", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                ImplementeConnexion.Instance.Conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTelephone_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTelephone.SelectedRows.Count > 0)
                {
                    IPersonne p = new Personne();
                    ITelephone t = new Telephone();

                    t = (ITelephone)dgvTelephone.SelectedRows[0].DataBoundItem;

                    txtId.Text = t.Id.ToString();
                    txtInitial.Text = t.Initial;
                    txtNumero.Text = t.Numero;
                    cboPersonne.Text = p.OnePersonne(t.Id_proprietaire).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sélection d'un téléphone, " + ex.Message, "Sélection téléphone", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                ImplementeConnexion.Instance.Conn.Close();
            }
        }
    }
}
