namespace GestionPersonneGUI
{
    partial class FrmTelephone
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
            this.dgvTelephone = new System.Windows.Forms.DataGridView();
            this.cboPersonne = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtInitial = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelephone)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelephone
            // 
            this.dgvTelephone.AllowUserToAddRows = false;
            this.dgvTelephone.AllowUserToDeleteRows = false;
            this.dgvTelephone.AllowUserToOrderColumns = true;
            this.dgvTelephone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTelephone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelephone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTelephone.Location = new System.Drawing.Point(0, 139);
            this.dgvTelephone.MultiSelect = false;
            this.dgvTelephone.Name = "dgvTelephone";
            this.dgvTelephone.ReadOnly = true;
            this.dgvTelephone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelephone.Size = new System.Drawing.Size(546, 171);
            this.dgvTelephone.TabIndex = 66;
            this.dgvTelephone.SelectionChanged += new System.EventHandler(this.dgvTelephone_SelectionChanged);
            // 
            // cboPersonne
            // 
            this.cboPersonne.FormattingEnabled = true;
            this.cboPersonne.Location = new System.Drawing.Point(71, 31);
            this.cboPersonne.Name = "cboPersonne";
            this.cboPersonne.Size = new System.Drawing.Size(406, 21);
            this.cboPersonne.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(159, 110);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(321, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(240, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Mettre à jour";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(71, 6);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(406, 20);
            this.txtId.TabIndex = 60;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(402, 110);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Annuler";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Initial :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Numéro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Personne :";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(71, 84);
            this.txtNumero.Mask = "000000000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(405, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(71, 58);
            this.txtInitial.Mask = "+000";
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(405, 20);
            this.txtInitial.TabIndex = 1;
            // 
            // FrmTelephone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 310);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.dgvTelephone);
            this.Controls.Add(this.cboPersonne);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FrmTelephone";
            this.Text = "Saisie des numéro de téléphones";
            this.Load += new System.EventHandler(this.FrmTelephone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelephone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelephone;
        private System.Windows.Forms.ComboBox cboPersonne;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtInitial;
    }
}