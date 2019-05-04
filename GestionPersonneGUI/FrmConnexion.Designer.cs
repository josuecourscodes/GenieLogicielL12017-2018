namespace GestionPersonneGUI
{
    partial class FrmConnexion
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
            this.btnConnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboTypeDataBase = new System.Windows.Forms.ComboBox();
            this.txtServeur = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(159, 137);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 5;
            this.btnConnexion.Text = "Valider";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Base de données :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base de données :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mot de passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Utilisateur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Serveur :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(257, 137);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cboTypeDataBase
            // 
            this.cboTypeDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeDataBase.FormattingEnabled = true;
            this.cboTypeDataBase.Location = new System.Drawing.Point(138, 6);
            this.cboTypeDataBase.Name = "cboTypeDataBase";
            this.cboTypeDataBase.Size = new System.Drawing.Size(194, 21);
            this.cboTypeDataBase.TabIndex = 0;
            this.cboTypeDataBase.SelectedIndexChanged += new System.EventHandler(this.cboTypeDataBase_SelectedIndexChanged);
            // 
            // txtServeur
            // 
            this.txtServeur.Location = new System.Drawing.Point(138, 33);
            this.txtServeur.Name = "txtServeur";
            this.txtServeur.Size = new System.Drawing.Size(194, 20);
            this.txtServeur.TabIndex = 1;
            this.txtServeur.Text = "JOSAM";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(138, 85);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(194, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "sa";
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(138, 59);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(194, 20);
            this.txtBD.TabIndex = 2;
            this.txtBD.Text = "gestion_personne";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '$';
            this.txtPassword.Size = new System.Drawing.Size(194, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "isig";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 167);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtServeur);
            this.Controls.Add(this.cboTypeDataBase);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConnexion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cboTypeDataBase;
        private System.Windows.Forms.TextBox txtServeur;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.MaskedTextBox txtPassword;
    }
}

