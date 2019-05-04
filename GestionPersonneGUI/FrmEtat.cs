using System;
using System.Data;
using System.Windows.Forms;
using ManageSingleConnexion;
using System.Data.SqlClient;

namespace GestionPersonneGUI
{
    public partial class FrmEtat : Form
    {
        public FrmEtat()
        {
            InitializeComponent();
        }

        private void LoadReport()
        {
            if (ImplementeConnexion.Instance.Conn.State != ConnectionState.Open)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = @"select personne.id as Code,personne.nom + ' ' + ISNULL(personne.postnom,'') + ' ' + ISNULL(personne.prenom,'') as Nom,
                personne.sexe as Sexe,telephone.initial + '' + telephone.numero as 'Tél.' from personne
                left outer join telephone on personne.id=telephone.id_personne order by Nom asc ";

                SqlDataAdapter adapter = new SqlDataAdapter((SqlCommand)cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "lstPersonne");

                ListePersonne rpt = new ListePersonne();
                rpt.SetDataSource(dataset.Tables["lstPersonne"]);
                crvRapport.ReportSource = rpt;
                crvRapport.Refresh();

                dataset.Dispose();
            }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            try
            {
                LoadReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec du chargement du rapport " + ex.Message, "Affichage des personnes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                ImplementeConnexion.Instance.Conn.Close();
            }
        }
    }
}
