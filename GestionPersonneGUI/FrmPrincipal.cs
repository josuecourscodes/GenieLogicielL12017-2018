using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ManageSingleConnexion;

namespace GestionPersonneGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void smnConnexion_Click(object sender, EventArgs e)
        {
            FrmConnexion form = new FrmConnexion();
            form.MdiParent = this;
            form.Show();
        }

        private void smnQuitter_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void smnDeconnexion_Click(object sender, EventArgs e)
        {
            if (ImplementeConnexion.Instance.Conn.State != ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Close();
        }

        private void smnPersonne_Click(object sender, EventArgs e)
        {
            FrmPersonne form = new FrmPersonne();
            form.MdiParent = this;
            form.Show();
        }

        private void smnTelephone_Click(object sender, EventArgs e)
        {
            FrmTelephone form = new FrmTelephone();
            form.MdiParent = this;
            form.Show();
        }

        private void smnListePersonne_Click(object sender, EventArgs e)
        {
            FrmEtat form = new FrmEtat();
            form.MdiParent = this;
            form.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Voulez-vous quitter ?","Quitter l'application",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            //if (DialogResult == DialogResult.Yes)
            //    e.Cancel = true;
            //else
            //    e.Cancel = false;
        }
    }
}
