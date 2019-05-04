namespace GestionPersonneGUI
{
    partial class FrmEtat
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
            this.btnAfficher = new System.Windows.Forms.Button();
            this.crvRapport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(505, 0);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 1;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // crvRapport
            // 
            this.crvRapport.ActiveViewIndex = -1;
            this.crvRapport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRapport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRapport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRapport.Location = new System.Drawing.Point(0, 0);
            this.crvRapport.Name = "crvRapport";
            this.crvRapport.Size = new System.Drawing.Size(922, 625);
            this.crvRapport.TabIndex = 2;
            // 
            // FrmEtat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 625);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.crvRapport);
            this.MaximizeBox = false;
            this.Name = "FrmEtat";
            this.Text = "Etats de sorties";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfficher;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRapport;
    }
}