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
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.datagridObj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre par heure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cout";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom de l\'item";
            // 
            // btnAjouterObj
            // 
            this.btnAjouterObj.Location = new System.Drawing.Point(68, 132);
            this.btnAjouterObj.Name = "btnAjouterObj";
            this.btnAjouterObj.Size = new System.Drawing.Size(97, 23);
            this.btnAjouterObj.TabIndex = 3;
            this.btnAjouterObj.Text = "Ajouter objet";
            this.btnAjouterObj.UseVisualStyleBackColor = true;
            this.btnAjouterObj.Click += new System.EventHandler(this.btnAjouterObj_Click);
            // 
            // txbNbParH
            // 
            this.txbNbParH.Location = new System.Drawing.Point(126, 12);
            this.txbNbParH.Name = "txbNbParH";
            this.txbNbParH.Size = new System.Drawing.Size(100, 20);
            this.txbNbParH.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // txbCout
            // 
            this.txbCout.Location = new System.Drawing.Point(126, 41);
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
            this.datagridObj.Name = "datagridObj";
            this.datagridObj.Size = new System.Drawing.Size(537, 150);
            this.datagridObj.TabIndex = 7;
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
            this.btnSupp.Location = new System.Drawing.Point(443, 181);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(97, 23);
            this.btnSupp.TabIndex = 10;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(65, 181);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(97, 23);
            this.btnModif.TabIndex = 12;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(126, 100);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(100, 20);
            this.txbCode.TabIndex = 14;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(62, 103);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 13;
            this.lblCode.Text = "Code";
            // 
            // Objets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 233);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.datagridObj);
            this.Controls.Add(this.txbCout);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.TextBox textBox2;
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
    }
}