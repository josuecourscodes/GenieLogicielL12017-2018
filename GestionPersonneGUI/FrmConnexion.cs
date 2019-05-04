using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ManageSingleConnexion;
using GestionPersonneLib;

namespace GestionPersonneGUI
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            cboTypeDataBase.DataSource = Enum.GetNames(typeof(ConnexionType));//.GetValues(typeof(ConnexionType));
            //cboTypeDataBase.Items.Add(ConnexionType.SQLServer.ToString());
            //cboTypeDataBase.Items.Add(ConnexionType.MySQL.ToString());
            //cboTypeDataBase.Items.Add(ConnexionType.Oracle.ToString());
            //cboTypeDataBase.Items.Add(ConnexionType.PostGreSQL.ToString());
            //cboTypeDataBase.Items.Add(ConnexionType.Access.ToString());


            cboTypeDataBase.SelectedIndex = 0;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion connexion = new Connexion();
                
                connexion.Serveur = txtServeur.Text;
                connexion.Database = txtBD.Text;
                connexion.User = txtUser.Text;
                connexion.Password = txtPassword.Text;

                ///////
                ////connexion.Port = 1521;

                ImplementeConnexion.Instance.Initialise(connexion);

                if (ImplementeConnexion.Instance.Conn.State != ConnectionState.Open)
                    ImplementeConnexion.Instance.Conn.Open();

                MessageBox.Show("Connexion BD réussie", "Connexion BD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec Connexion BD, " + ex.Message, "Connexion BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                ImplementeConnexion.Instance.Conn.Close();
            }
        }

        private void cboTypeDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboTypeDataBase.SelectedIndex)
            {
                case 0:ImplementeConnexion.Instance.ConType = ConnexionType.SQLServer;
                    break;
                case 1: ImplementeConnexion.Instance.ConType = ConnexionType.MySQL;
                    break;
                case 2: ImplementeConnexion.Instance.ConType = ConnexionType.PostGreSQL;
                    break;
                case 3: ImplementeConnexion.Instance.ConType = ConnexionType.Oracle;
                    break;
                case 4: ImplementeConnexion.Instance.ConType = ConnexionType.Access;
                    break;
            }              
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
        }
    }
}
