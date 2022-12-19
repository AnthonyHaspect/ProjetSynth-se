namespace pProjetSynthèse.Forms
{
    partial class Creations
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
            this.dgtCreations = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbArgentTot = new System.Windows.Forms.TextBox();
            this.txbItemTotal = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCommande = new System.Windows.Forms.Button();
            this.txbEmployer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNbHeure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRaffairchirs = new System.Windows.Forms.Button();
            this.txbCodeCmd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtCreations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgtCreations
            // 
            this.dgtCreations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtCreations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.NbItem,
            this.TotalHeure,
            this.Prix,
            this.Usager,
            this.NumeroCmd});
            this.dgtCreations.Location = new System.Drawing.Point(12, 12);
            this.dgtCreations.Name = "dgtCreations";
            this.dgtCreations.Size = new System.Drawing.Size(642, 212);
            this.dgtCreations.TabIndex = 0;
            this.dgtCreations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtCreations_CellClick);
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // NbItem
            // 
            this.NbItem.HeaderText = "Nb Item";
            this.NbItem.Name = "NbItem";
            // 
            // TotalHeure
            // 
            this.TotalHeure.HeaderText = "Heures";
            this.TotalHeure.Name = "TotalHeure";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // Usager
            // 
            this.Usager.HeaderText = "Usager";
            this.Usager.Name = "Usager";
            // 
            // NumeroCmd
            // 
            this.NumeroCmd.HeaderText = "NumeroCmd";
            this.NumeroCmd.Name = "NumeroCmd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Argent Total (CAD)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre d\'item total";
            // 
            // txbArgentTot
            // 
            this.txbArgentTot.Location = new System.Drawing.Point(166, 241);
            this.txbArgentTot.Name = "txbArgentTot";
            this.txbArgentTot.ReadOnly = true;
            this.txbArgentTot.Size = new System.Drawing.Size(123, 20);
            this.txbArgentTot.TabIndex = 3;
            // 
            // txbItemTotal
            // 
            this.txbItemTotal.Location = new System.Drawing.Point(166, 282);
            this.txbItemTotal.Name = "txbItemTotal";
            this.txbItemTotal.ReadOnly = true;
            this.txbItemTotal.Size = new System.Drawing.Size(123, 20);
            this.txbItemTotal.TabIndex = 4;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(285, 21);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(97, 23);
            this.btnModif.TabIndex = 14;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Enabled = false;
            this.btnSupp.Location = new System.Drawing.Point(411, 67);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(97, 23);
            this.btnSupp.TabIndex = 13;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbCodeCmd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSupp);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnCommande);
            this.groupBox1.Controls.Add(this.btnModif);
            this.groupBox1.Controls.Add(this.txbEmployer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbNbHeure);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 124);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouveau";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // btnCommande
            // 
            this.btnCommande.Location = new System.Drawing.Point(285, 80);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(97, 23);
            this.btnCommande.TabIndex = 20;
            this.btnCommande.Text = "Commander";
            this.btnCommande.UseVisualStyleBackColor = true;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // txbEmployer
            // 
            this.txbEmployer.Location = new System.Drawing.Point(109, 97);
            this.txbEmployer.Name = "txbEmployer";
            this.txbEmployer.ReadOnly = true;
            this.txbEmployer.Size = new System.Drawing.Size(155, 20);
            this.txbEmployer.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Employer";
            // 
            // txbNbHeure
            // 
            this.txbNbHeure.Location = new System.Drawing.Point(109, 60);
            this.txbNbHeure.Name = "txbNbHeure";
            this.txbNbHeure.Size = new System.Drawing.Size(155, 20);
            this.txbNbHeure.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre d\'heure";
            // 
            // btnRaffairchirs
            // 
            this.btnRaffairchirs.Location = new System.Drawing.Point(370, 238);
            this.btnRaffairchirs.Name = "btnRaffairchirs";
            this.btnRaffairchirs.Size = new System.Drawing.Size(97, 23);
            this.btnRaffairchirs.TabIndex = 20;
            this.btnRaffairchirs.Text = "Raffairchir liste";
            this.btnRaffairchirs.UseVisualStyleBackColor = true;
            this.btnRaffairchirs.Click += new System.EventHandler(this.btnRaffairchirs_Click);
            // 
            // txbCodeCmd
            // 
            this.txbCodeCmd.Location = new System.Drawing.Point(497, 20);
            this.txbCodeCmd.Name = "txbCodeCmd";
            this.txbCodeCmd.ReadOnly = true;
            this.txbCodeCmd.Size = new System.Drawing.Size(155, 20);
            this.txbCodeCmd.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "NumCommande";
            // 
            // Creations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRaffairchirs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbItemTotal);
            this.Controls.Add(this.txbArgentTot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtCreations);
            this.Name = "Creations";
            this.Text = "Creations";
            this.Load += new System.EventHandler(this.Creations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtCreations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtCreations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usager;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbArgentTot;
        private System.Windows.Forms.TextBox txbItemTotal;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbEmployer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNbHeure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCommande;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRaffairchirs;
        private System.Windows.Forms.TextBox txbCodeCmd;
        private System.Windows.Forms.Label label6;
    }
}