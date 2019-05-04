using System;
using System.Windows.Forms;
using GestionPersonneLib;
using ManageSingleConnexion;

namespace GestionPersonneGUI
{
    public partial class FrmPersonne : Form
    {
        public FrmPersonne()
        {
            InitializeComponent();
        }

        private void FrmPersonne_Load(object sender, EventArgs e)
        {
            cboSexe.DataSource = Enum.GetValues(typeof(Sexe));
            cboSexe.SelectedIndex = 0;
            //cboSexe.Items.Add(Sexe.Masculin.ToString());
            //cboSexe.Items.Add(Sexe.Féminin.ToString());

            //Chargement du DataGrid des personnes
            try
            {
                RefreshDGPersonnes();
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

        private void RefreshDGPersonnes()
        {
            IPersonne p = new Personne();
            dgvPersonne.DataSource = p.Personnes();
        }

        private void BindValuesPersonne(IPersonne p)
        {
            p.Id = int.Parse(txtId.Text);
            p.Nom = txtNom.Text;
            p.Postnom =txtPostnom.Text;
            p.Prenom = txtPrenom.Text;
            p.sex = cboSexe.Text.Equals("Masculin") ? Sexe.Masculin : Sexe.Féminin;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                IPersonne personne = new Personne();
                txtId.Text = personne.Nouveau().ToString();

                txtNom.Clear();
                txtPostnom.Clear();
                txtPrenom.Clear();
                cboSexe.SelectedIndex = 0;
                txtNom.Focus();
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
                IPersonne p = new Personne();

                this.BindValuesPersonne(p);

                //p.Enregistrer(p);

                //Enregistrement via une transaction
                p.EnregistrerTransaction(p);

                MessageBox.Show("Mise à jour effectué", "Mise à jour personne", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.RefreshDGPersonnes();
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
                    IPersonne p = new Personne();
                    p.Id = int.Parse(txtId.Text);
                    p.Supprimer(p.Id);

                    MessageBox.Show("Suppresion effectué", "Suppresion personne", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.RefreshDGPersonnes();
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

        private void dgvPersonne_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonne.SelectedRows.Count > 0)
                {
                    IPersonne p = new Personne();

                    p = (IPersonne)dgvPersonne.SelectedRows[0].DataBoundItem;

                    txtId.Text = p.Id.ToString();
                    txtNom.Text = p.Nom;
                    txtPostnom.Text = p.Postnom;
                    txtPrenom.Text = p.Prenom;
                    cboSexe.Text = p.sex.Equals(Sexe.Masculin) ? "Masculin" : "Féminin";

                    //Chargement des téléphone de la personne
                    dgvTelephone.DataSource = p.TelephonePersonne;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sélection d'une personne " + ex.Message, "Sélection personne", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
