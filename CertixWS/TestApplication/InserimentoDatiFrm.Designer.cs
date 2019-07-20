namespace TestApplication
{
    partial class InserimentoDatiFrm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdmagazz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdmagazzWip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinitura = new System.Windows.Forms.TextBox();
            this.dgvEtichette = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.ddlBrand = new System.Windows.Forms.ComboBox();
            this.txtModelloMagazz = new System.Windows.Forms.TextBox();
            this.txtModelloMagazzWip = new System.Windows.Forms.TextBox();
            this.lblMessaggio = new System.Windows.Forms.Label();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.ETICHETTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtichette)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codice a barre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "IDMAGAZZ";
            // 
            // txtIdmagazz
            // 
            this.txtIdmagazz.Location = new System.Drawing.Point(162, 69);
            this.txtIdmagazz.Name = "txtIdmagazz";
            this.txtIdmagazz.ReadOnly = true;
            this.txtIdmagazz.Size = new System.Drawing.Size(123, 24);
            this.txtIdmagazz.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "IDMAGAZZ_WIP";
            // 
            // txtIdmagazzWip
            // 
            this.txtIdmagazzWip.Location = new System.Drawing.Point(162, 107);
            this.txtIdmagazzWip.Name = "txtIdmagazzWip";
            this.txtIdmagazzWip.ReadOnly = true;
            this.txtIdmagazzWip.Size = new System.Drawing.Size(123, 24);
            this.txtIdmagazzWip.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Finitura";
            // 
            // txtFinitura
            // 
            this.txtFinitura.Location = new System.Drawing.Point(162, 183);
            this.txtFinitura.Name = "txtFinitura";
            this.txtFinitura.Size = new System.Drawing.Size(222, 24);
            this.txtFinitura.TabIndex = 3;
            // 
            // dgvEtichette
            // 
            this.dgvEtichette.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtichette.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ETICHETTA});
            this.dgvEtichette.Location = new System.Drawing.Point(83, 240);
            this.dgvEtichette.Name = "dgvEtichette";
            this.dgvEtichette.Size = new System.Drawing.Size(401, 209);
            this.dgvEtichette.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Etichette";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(508, 279);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(89, 27);
            this.btnSalva.TabIndex = 5;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // ddlBrand
            // 
            this.ddlBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBrand.FormattingEnabled = true;
            this.ddlBrand.Location = new System.Drawing.Point(162, 145);
            this.ddlBrand.Name = "ddlBrand";
            this.ddlBrand.Size = new System.Drawing.Size(222, 26);
            this.ddlBrand.TabIndex = 6;
            // 
            // txtModelloMagazz
            // 
            this.txtModelloMagazz.Location = new System.Drawing.Point(291, 69);
            this.txtModelloMagazz.Name = "txtModelloMagazz";
            this.txtModelloMagazz.ReadOnly = true;
            this.txtModelloMagazz.Size = new System.Drawing.Size(342, 24);
            this.txtModelloMagazz.TabIndex = 3;
            // 
            // txtModelloMagazzWip
            // 
            this.txtModelloMagazzWip.Location = new System.Drawing.Point(291, 107);
            this.txtModelloMagazzWip.Name = "txtModelloMagazzWip";
            this.txtModelloMagazzWip.ReadOnly = true;
            this.txtModelloMagazzWip.Size = new System.Drawing.Size(342, 24);
            this.txtModelloMagazzWip.TabIndex = 3;
            // 
            // lblMessaggio
            // 
            this.lblMessaggio.AutoSize = true;
            this.lblMessaggio.ForeColor = System.Drawing.Color.Red;
            this.lblMessaggio.Location = new System.Drawing.Point(12, 43);
            this.lblMessaggio.Name = "lblMessaggio";
            this.lblMessaggio.Size = new System.Drawing.Size(46, 18);
            this.lblMessaggio.TabIndex = 7;
            this.lblMessaggio.Text = "label6";
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(508, 329);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(89, 27);
            this.btnPulisci.TabIndex = 5;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // ETICHETTA
            // 
            this.ETICHETTA.FillWeight = 130F;
            this.ETICHETTA.HeaderText = "ETICHETTA";
            this.ETICHETTA.MaxInputLength = 10;
            this.ETICHETTA.Name = "ETICHETTA";
            this.ETICHETTA.Width = 130;
            // 
            // InserimentoDatiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 526);
            this.Controls.Add(this.lblMessaggio);
            this.Controls.Add(this.ddlBrand);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.dgvEtichette);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFinitura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelloMagazzWip);
            this.Controls.Add(this.txtIdmagazzWip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelloMagazz);
            this.Controls.Add(this.txtIdmagazz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InserimentoDatiFrm";
            this.Text = "InserimentoDatiFrm";
            this.Load += new System.EventHandler(this.InserimentoDatiFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtichette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdmagazz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdmagazzWip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFinitura;
        private System.Windows.Forms.DataGridView dgvEtichette;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.ComboBox ddlBrand;
        private System.Windows.Forms.TextBox txtModelloMagazz;
        private System.Windows.Forms.TextBox txtModelloMagazzWip;
        private System.Windows.Forms.Label lblMessaggio;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETICHETTA;
    }
}