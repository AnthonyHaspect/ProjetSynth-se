namespace pProjetSynthèse.Forms
{
    partial class Objets
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjouterObj = new System.Windows.Forms.Button();
            this.txbNbParH = new System.Windows.Forms.TextBox();
            this.txbNomItem = new System.Windows.Forms.TextBox();
            this.txbCout = new System.Windows.Forms.TextBox();
            this.datagridObj = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txbPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErreurObj = new System.Windows.Forms.Label();
            this.btnRaffairchir = new System.Windows.Forms.Button();
            this.btnCreation = new System.Windows.Forms.Button();
            this.lbldatapassed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridObj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre par heure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cout par item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom de l\'item";
            // 
            // btnAjouterObj
            // 
            this.btnAjouterObj.Location = new System.Drawing.Point(65, 174);
            this.btnAjouterObj.Name = "btnAjouterObj";
            this.btnAjouterObj.Size = new System.Drawing.Size(97, 23);
            this.btnAjouterObj.TabIndex = 3;
            this.btnAjouterObj.Text = "Ajouter objet";
            this.btnAjouterObj.UseVisualStyleBackColor = true;
            this.btnAjouterObj.Click += new System.EventHandler(this.btnAjouterObj_Click);
            // 
            // txbNbParH
            // 
            this.txbNbParH.Location = new System.Drawing.Point(126, 44);
            this.txbNbParH.Name = "txbNbParH";
            this.txbNbParH.Size = new System.Drawing.Size(100, 20);
            this.txbNbParH.TabIndex = 4;
            // 
            // txbNomItem
            // 
            this.txbNomItem.Location = new System.Drawing.Point(126, 12);
            this.txbNomItem.Name = "txbNomItem";
            this.txbNomItem.Size = new System.Drawing.Size(100, 20);
            this.txbNomItem.TabIndex = 5;
            // 
            // txbCout
            // 
            this.txbCout.Location = new System.Drawing.Point(126, 74);
            this.txbCout.Name = "txbCout";
            this.txbCout.Size = new System.Drawing.Size(100, 20);
            this.txbCout.TabIndex = 6;
            // 
            // datagridObj
            // 
            this.datagridObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Nombre,
            this.Cout,
            this.Prix,
            this.Code});
            this.datagridObj.Location = new System.Drawing.Point(242, 12);
            this.datagridObj.MultiSelect = false;
            this.datagridObj.Name = "datagridObj";
            this.datagridObj.Size = new System.Drawing.Size(537, 150);
            this.datagridObj.TabIndex = 7;
            this.datagridObj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridObj_CellClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cout
            // 
            this.Cout.HeaderText = "Cout";
            this.Cout.Name = "Cout";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // btnSupp
            // 
            this.btnSupp.Enabled = false;
            this.btnSupp.Location = new System.Drawing.Point(476, 189);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(97, 23);
            this.btnSupp.TabIndex = 10;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnModif
            // 
            this.btnModif.Enabled = false;
            this.btnModif.Location = new System.Drawing.Point(65, 203);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(97, 23);
            this.btnModif.TabIndex = 12;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(126, 142);
            this.txbCode.Name = "txbCode";
            this.txbCode.ReadOnly = true;
            this.txbCode.Size = new System.Drawing.Size(100, 20);
            this.txbCode.TabIndex = 14;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(62, 145);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 13;
            this.lblCode.Text = "Code";
            // 
            // txbPrix
            // 
            this.txbPrix.Location = new System.Drawing.Point(126, 107);
            this.txbPrix.Name = "txbPrix";
            this.txbPrix.Size = new System.Drawing.Size(100, 20);
            this.txbPrix.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prix par tem";
            // 
            // lblErreurObj
            // 
            this.lblErreurObj.AutoSize = true;
            this.lblErreurObj.Location = new System.Drawing.Point(224, 246);
            this.lblErreurObj.Name = "lblErreurObj";
            this.lblErreurObj.Size = new System.Drawing.Size(65, 13);
            this.lblErreurObj.TabIndex = 18;
            this.lblErreurObj.Text = "Les erreurs: ";
            // 
            // btnRaffairchir
            // 
            this.btnRaffairchir.Location = new System.Drawing.Point(612, 189);
            this.btnRaffairchir.Name = "btnRaffairchir";
            this.btnRaffairchir.Size = new System.Drawing.Size(97, 23);
            this.btnRaffairchir.TabIndex = 19;
            this.btnRaffairchir.Text = "Raffairchir liste";
            this.btnRaffairchir.UseVisualStyleBackColor = true;
            this.btnRaffairchir.Click += new System.EventHandler(this.btnRaffairchir_Click);
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(369, 288);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(103, 23);
            this.btnCreation.TabIndex = 20;
            this.btnCreation.Text = "Passé Création";
            this.btnCreation.UseVisualStyleBackColor = true;
            this.btnCreation.Click += new System.EventHandler(this.btnCreation_Click);
            // 
            // lbldatapassed
            // 
            this.lbldatapassed.AutoSize = true;
            this.lbldatapassed.Location = new System.Drawing.Point(541, 288);
            this.lbldatapassed.Name = "lbldatapassed";
            this.lbldatapassed.Size = new System.Drawing.Size(0, 13);
            this.lbldatapassed.TabIndex = 21;
            this.lbldatapassed.Visible = false;
            // 
            // Objets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.lbldatapassed);
            this.Controls.Add(this.btnCreation);
            this.Controls.Add(this.btnRaffairchir);
            this.Controls.Add(this.lblErreurObj);
            this.Controls.Add(this.txbPrix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.datagridObj);
            this.Controls.Add(this.txbCout);
            this.Controls.Add(this.txbNomItem);
            this.Controls.Add(this.txbNbParH);
            this.Controls.Add(this.btnAjouterObj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Objets";
            this.Text = "Objets";
            this.Load += new System.EventHandler(this.Objets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjouterObj;
        private System.Windows.Forms.TextBox txbNbParH;
        private System.Windows.Forms.TextBox txbNomItem;
        private System.Windows.Forms.TextBox txbCout;
        private System.Windows.Forms.DataGridView datagridObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txbPrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErreurObj;
        private System.Windows.Forms.Button btnRaffairchir;
        private System.Windows.Forms.Button btnCreation;
        private System.Windows.Forms.Label lbldatapassed;
    }
}