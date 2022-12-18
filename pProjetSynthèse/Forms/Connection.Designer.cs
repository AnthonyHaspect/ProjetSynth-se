namespace pProjetSynthèse
{
    partial class Connection
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
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbListeUsager = new System.Windows.Forms.ComboBox();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbDeptart = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.lblDepartement = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.chkbGreant = new System.Windows.Forms.CheckBox();
            this.gbconnection = new System.Windows.Forms.GroupBox();
            this.gbCreer = new System.Windows.Forms.GroupBox();
            this.lblErreurUsager = new System.Windows.Forms.Label();
            this.gbconnection.SuspendLayout();
            this.gbCreer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(84, 150);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(130, 23);
            this.btnCreer.TabIndex = 0;
            this.btnCreer.Text = "Créer employer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(52, 57);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbListeUsager
            // 
            this.cmbListeUsager.FormattingEnabled = true;
            this.cmbListeUsager.Location = new System.Drawing.Point(32, 19);
            this.cmbListeUsager.Name = "cmbListeUsager";
            this.cmbListeUsager.Size = new System.Drawing.Size(121, 21);
            this.cmbListeUsager.TabIndex = 2;
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(84, 19);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(130, 20);
            this.txbNom.TabIndex = 3;
            // 
            // txbDeptart
            // 
            this.txbDeptart.Location = new System.Drawing.Point(84, 98);
            this.txbDeptart.Name = "txbDeptart";
            this.txbDeptart.Size = new System.Drawing.Size(130, 20);
            this.txbDeptart.TabIndex = 4;
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(84, 58);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(130, 20);
            this.txbPrenom.TabIndex = 5;
            // 
            // lblDepartement
            // 
            this.lblDepartement.AutoSize = true;
            this.lblDepartement.Location = new System.Drawing.Point(4, 101);
            this.lblDepartement.Name = "lblDepartement";
            this.lblDepartement.Size = new System.Drawing.Size(80, 13);
            this.lblDepartement.TabIndex = 6;
            this.lblDepartement.Text = "Deparetement :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(43, 18);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(26, 61);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom.TabIndex = 8;
            this.lblPrenom.Text = "Prenom : ";
            // 
            // chkbGreant
            // 
            this.chkbGreant.AutoSize = true;
            this.chkbGreant.Location = new System.Drawing.Point(117, 127);
            this.chkbGreant.Name = "chkbGreant";
            this.chkbGreant.Size = new System.Drawing.Size(58, 17);
            this.chkbGreant.TabIndex = 9;
            this.chkbGreant.Text = "Gérant";
            this.chkbGreant.UseVisualStyleBackColor = true;
            // 
            // gbconnection
            // 
            this.gbconnection.Controls.Add(this.cmbListeUsager);
            this.gbconnection.Controls.Add(this.btnConnect);
            this.gbconnection.Location = new System.Drawing.Point(-1, 17);
            this.gbconnection.Name = "gbconnection";
            this.gbconnection.Size = new System.Drawing.Size(169, 100);
            this.gbconnection.TabIndex = 10;
            this.gbconnection.TabStop = false;
            this.gbconnection.Text = "Connection";
            // 
            // gbCreer
            // 
            this.gbCreer.Controls.Add(this.txbNom);
            this.gbCreer.Controls.Add(this.btnCreer);
            this.gbCreer.Controls.Add(this.chkbGreant);
            this.gbCreer.Controls.Add(this.txbDeptart);
            this.gbCreer.Controls.Add(this.lblPrenom);
            this.gbCreer.Controls.Add(this.txbPrenom);
            this.gbCreer.Controls.Add(this.lblNom);
            this.gbCreer.Controls.Add(this.lblDepartement);
            this.gbCreer.Location = new System.Drawing.Point(184, 17);
            this.gbCreer.Name = "gbCreer";
            this.gbCreer.Size = new System.Drawing.Size(232, 185);
            this.gbCreer.TabIndex = 11;
            this.gbCreer.TabStop = false;
            this.gbCreer.Text = "Création d\'un compte";
            // 
            // lblErreurUsager
            // 
            this.lblErreurUsager.AutoSize = true;
            this.lblErreurUsager.Location = new System.Drawing.Point(28, 212);
            this.lblErreurUsager.Name = "lblErreurUsager";
            this.lblErreurUsager.Size = new System.Drawing.Size(65, 13);
            this.lblErreurUsager.TabIndex = 10;
            this.lblErreurUsager.Text = "Les erreurs: ";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 282);
            this.Controls.Add(this.lblErreurUsager);
            this.Controls.Add(this.gbCreer);
            this.Controls.Add(this.gbconnection);
            this.Name = "Connection";
            this.Text = " Comptes";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.gbconnection.ResumeLayout(false);
            this.gbCreer.ResumeLayout(false);
            this.gbCreer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbListeUsager;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbDeptart;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.Label lblDepartement;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.CheckBox chkbGreant;
        private System.Windows.Forms.GroupBox gbconnection;
        private System.Windows.Forms.GroupBox gbCreer;
        private System.Windows.Forms.Label lblErreurUsager;
    }
}