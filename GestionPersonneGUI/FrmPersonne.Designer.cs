namespace GestionPersonneGUI
{
    partial class FrmPersonne
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPostnom = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSexe = new System.Windows.Forms.ComboBox();
            this.dgvPersonne = new System.Windows.Forms.DataGridView();
            this.dgvTelephone = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelephone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(77, 153);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(239, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(158, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Mettre à jour";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(77, 32);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(318, 20);
            this.txtNom.TabIndex = 0;
            // 
            // txtPostnom
            // 
            this.txtPostnom.Location = new System.Drawing.Point(77, 58);
            this.txtPostnom.Name = "txtPostnom";
            this.txtPostnom.Size = new System.Drawing.Size(318, 20);
            this.txtPostnom.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(77, 6);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(318, 20);
            this.txtId.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(320, 153);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Annuler";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Postnom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(77, 89);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(318, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sexe :";
            // 
            // cboSexe
            // 
            this.cboSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexe.FormattingEnabled = true;
            this.cboSexe.Location = new System.Drawing.Point(77, 119);
            this.cboSexe.Name = "cboSexe";
            this.cboSexe.Size = new System.Drawing.Size(318, 21);
            this.cboSexe.TabIndex = 3;
            // 
            // dgvPersonne
            // 
            this.dgvPersonne.AllowUserToAddRows = false;
            this.dgvPersonne.AllowUserToDeleteRows = false;
            this.dgvPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonne.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPersonne.Location = new System.Drawing.Point(0, 184);
            this.dgvPersonne.Name = "dgvPersonne";
            this.dgvPersonne.ReadOnly = true;
            this.dgvPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonne.Size = new System.Drawing.Size(802, 185);
            this.dgvPersonne.TabIndex = 50;
            this.dgvPersonne.SelectionChanged += new System.EventHandler(this.dgvPersonne_SelectionChanged);
            // 
            // dgvTelephone
            // 
            this.dgvTelephone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelephone.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvTelephone.Location = new System.Drawing.Point(401, 0);
            this.dgvTelephone.Name = "dgvTelephone";
            this.dgvTelephone.Size = new System.Drawing.Size(401, 184);
            this.dgvTelephone.TabIndex = 51;
            // 
            // FrmPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 369);
            this.Controls.Add(this.dgvTelephone);
            this.Controls.Add(this.dgvPersonne);
            this.Controls.Add(this.cboSexe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPostnom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MinimizeBox = false;
            this.Name = "FrmPersonne";
            this.Text = "Saisie des personnes";
            this.Load += new System.EventHandler(this.FrmPersonne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelephone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPostnom;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSexe;
        private System.Windows.Forms.DataGridView dgvPersonne;
        private System.Windows.Forms.DataGridView dgvTelephone;
    }
}