namespace GestionPersonneGUI
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smnConnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.smnDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.smnQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smnPersonne = new System.Windows.Forms.ToolStripMenuItem();
            this.smnTelephone = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smnListePersonne = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.affichageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnConnexion,
            this.smnDeconnexion,
            this.smnQuitter});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // smnConnexion
            // 
            this.smnConnexion.Name = "smnConnexion";
            this.smnConnexion.Size = new System.Drawing.Size(143, 22);
            this.smnConnexion.Text = "Connexion";
            this.smnConnexion.Click += new System.EventHandler(this.smnConnexion_Click);
            // 
            // smnDeconnexion
            // 
            this.smnDeconnexion.Name = "smnDeconnexion";
            this.smnDeconnexion.Size = new System.Drawing.Size(143, 22);
            this.smnDeconnexion.Text = "Déconnexion";
            this.smnDeconnexion.Click += new System.EventHandler(this.smnDeconnexion_Click);
            // 
            // smnQuitter
            // 
            this.smnQuitter.Name = "smnQuitter";
            this.smnQuitter.Size = new System.Drawing.Size(143, 22);
            this.smnQuitter.Text = "Quitter";
            this.smnQuitter.Click += new System.EventHandler(this.smnQuitter_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnPersonne,
            this.smnTelephone});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // smnPersonne
            // 
            this.smnPersonne.Name = "smnPersonne";
            this.smnPersonne.Size = new System.Drawing.Size(130, 22);
            this.smnPersonne.Text = "Personne";
            this.smnPersonne.Click += new System.EventHandler(this.smnPersonne_Click);
            // 
            // smnTelephone
            // 
            this.smnTelephone.Name = "smnTelephone";
            this.smnTelephone.Size = new System.Drawing.Size(130, 22);
            this.smnTelephone.Text = "Téléphone";
            this.smnTelephone.Click += new System.EventHandler(this.smnTelephone_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnListePersonne});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // smnListePersonne
            // 
            this.smnListePersonne.Name = "smnListePersonne";
            this.smnListePersonne.Size = new System.Drawing.Size(176, 22);
            this.smnListePersonne.Text = "Liste des personnes";
            this.smnListePersonne.Click += new System.EventHandler(this.smnListePersonne_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 352);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smnConnexion;
        private System.Windows.Forms.ToolStripMenuItem smnDeconnexion;
        private System.Windows.Forms.ToolStripMenuItem smnQuitter;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smnPersonne;
        private System.Windows.Forms.ToolStripMenuItem smnTelephone;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smnListePersonne;
    }
}