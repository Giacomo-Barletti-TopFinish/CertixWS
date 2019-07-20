namespace TestApplication
{
    partial class Form1
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
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.btnMetodoTest = new System.Windows.Forms.Button();
            this.btnAcquisiceCodice = new System.Windows.Forms.Button();
            this.btnFinestraInserimentoDati = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.nIdLine = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nMeasure3 = new System.Windows.Forms.NumericUpDown();
            this.nMeasure2 = new System.Windows.Forms.NumericUpDown();
            this.nMeasure1 = new System.Windows.Forms.NumericUpDown();
            this.txtMaterial3 = new System.Windows.Forms.TextBox();
            this.txtMaterial2 = new System.Windows.Forms.TextBox();
            this.txtMaterial1 = new System.Windows.Forms.TextBox();
            this.nIdMeasure = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIdLine)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMeasure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMeasure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMeasure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIdMeasure)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessaggio.Location = new System.Drawing.Point(-3, 292);
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.ReadOnly = true;
            this.txtMessaggio.Size = new System.Drawing.Size(804, 160);
            this.txtMessaggio.TabIndex = 0;
            // 
            // btnMetodoTest
            // 
            this.btnMetodoTest.Location = new System.Drawing.Point(17, 43);
            this.btnMetodoTest.Name = "btnMetodoTest";
            this.btnMetodoTest.Size = new System.Drawing.Size(147, 23);
            this.btnMetodoTest.TabIndex = 1;
            this.btnMetodoTest.Text = "Lancia Metodo Test";
            this.btnMetodoTest.UseVisualStyleBackColor = true;
            this.btnMetodoTest.Click += new System.EventHandler(this.btnMetodoTest_Click);
            // 
            // btnAcquisiceCodice
            // 
            this.btnAcquisiceCodice.Location = new System.Drawing.Point(47, 105);
            this.btnAcquisiceCodice.Name = "btnAcquisiceCodice";
            this.btnAcquisiceCodice.Size = new System.Drawing.Size(147, 23);
            this.btnAcquisiceCodice.TabIndex = 1;
            this.btnAcquisiceCodice.Text = "Lancia Upload Code";
            this.btnAcquisiceCodice.UseVisualStyleBackColor = true;
            this.btnAcquisiceCodice.Click += new System.EventHandler(this.btnAcquisiceCodice_Click);
            // 
            // btnFinestraInserimentoDati
            // 
            this.btnFinestraInserimentoDati.Location = new System.Drawing.Point(260, 12);
            this.btnFinestraInserimentoDati.Name = "btnFinestraInserimentoDati";
            this.btnFinestraInserimentoDati.Size = new System.Drawing.Size(262, 23);
            this.btnFinestraInserimentoDati.TabIndex = 1;
            this.btnFinestraInserimentoDati.Text = "Finestra inserimento dati";
            this.btnFinestraInserimentoDati.UseVisualStyleBackColor = true;
            this.btnFinestraInserimentoDati.Click += new System.EventHandler(this.btnFinestraInserimentoDati_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMetodoTest);
            this.groupBox1.Location = new System.Drawing.Point(24, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo test";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.nIdLine);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAcquisiceCodice);
            this.groupBox2.Location = new System.Drawing.Point(236, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 161);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UploadCode";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(74, 50);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(120, 20);
            this.txtCode.TabIndex = 2;
            this.txtCode.Text = "12345678912345";
            // 
            // nIdLine
            // 
            this.nIdLine.Location = new System.Drawing.Point(74, 18);
            this.nIdLine.Name = "nIdLine";
            this.nIdLine.Size = new System.Drawing.Size(120, 20);
            this.nIdLine.TabIndex = 1;
            this.nIdLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdLine";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nMeasure3);
            this.groupBox3.Controls.Add(this.nMeasure2);
            this.groupBox3.Controls.Add(this.nMeasure1);
            this.groupBox3.Controls.Add(this.txtMaterial3);
            this.groupBox3.Controls.Add(this.txtMaterial2);
            this.groupBox3.Controls.Add(this.txtMaterial1);
            this.groupBox3.Controls.Add(this.nIdMeasure);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(482, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 195);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UploadMesaures";
            // 
            // nMeasure3
            // 
            this.nMeasure3.DecimalPlaces = 2;
            this.nMeasure3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nMeasure3.Location = new System.Drawing.Point(137, 102);
            this.nMeasure3.Name = "nMeasure3";
            this.nMeasure3.Size = new System.Drawing.Size(120, 20);
            this.nMeasure3.TabIndex = 9;
            this.nMeasure3.Value = new decimal(new int[] {
            33,
            0,
            0,
            65536});
            // 
            // nMeasure2
            // 
            this.nMeasure2.DecimalPlaces = 2;
            this.nMeasure2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nMeasure2.Location = new System.Drawing.Point(137, 76);
            this.nMeasure2.Name = "nMeasure2";
            this.nMeasure2.Size = new System.Drawing.Size(120, 20);
            this.nMeasure2.TabIndex = 7;
            this.nMeasure2.Value = new decimal(new int[] {
            22,
            0,
            0,
            65536});
            // 
            // nMeasure1
            // 
            this.nMeasure1.DecimalPlaces = 2;
            this.nMeasure1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nMeasure1.Location = new System.Drawing.Point(137, 51);
            this.nMeasure1.Name = "nMeasure1";
            this.nMeasure1.Size = new System.Drawing.Size(120, 20);
            this.nMeasure1.TabIndex = 5;
            this.nMeasure1.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // txtMaterial3
            // 
            this.txtMaterial3.Location = new System.Drawing.Point(14, 102);
            this.txtMaterial3.MaxLength = 10;
            this.txtMaterial3.Name = "txtMaterial3";
            this.txtMaterial3.Size = new System.Drawing.Size(100, 20);
            this.txtMaterial3.TabIndex = 8;
            this.txtMaterial3.Text = "Ni";
            // 
            // txtMaterial2
            // 
            this.txtMaterial2.Location = new System.Drawing.Point(14, 76);
            this.txtMaterial2.MaxLength = 10;
            this.txtMaterial2.Name = "txtMaterial2";
            this.txtMaterial2.Size = new System.Drawing.Size(100, 20);
            this.txtMaterial2.TabIndex = 6;
            this.txtMaterial2.Text = "Pd";
            // 
            // txtMaterial1
            // 
            this.txtMaterial1.Location = new System.Drawing.Point(14, 50);
            this.txtMaterial1.MaxLength = 10;
            this.txtMaterial1.Name = "txtMaterial1";
            this.txtMaterial1.Size = new System.Drawing.Size(100, 20);
            this.txtMaterial1.TabIndex = 4;
            this.txtMaterial1.Text = "Au";
            // 
            // nIdMeasure
            // 
            this.nIdMeasure.Location = new System.Drawing.Point(81, 20);
            this.nIdMeasure.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nIdMeasure.Name = "nIdMeasure";
            this.nIdMeasure.Size = new System.Drawing.Size(95, 20);
            this.nIdMeasure.TabIndex = 3;
            this.nIdMeasure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IdMeasure";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Lancia UploadMeasures";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAcquisisceMisure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFinestraInserimentoDati);
            this.Controls.Add(this.txtMessaggio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIdLine)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMeasure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMeasure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMeasure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIdMeasure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.Button btnMetodoTest;
        private System.Windows.Forms.Button btnAcquisiceCodice;
        private System.Windows.Forms.Button btnFinestraInserimentoDati;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.NumericUpDown nIdLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nMeasure3;
        private System.Windows.Forms.NumericUpDown nMeasure2;
        private System.Windows.Forms.NumericUpDown nMeasure1;
        private System.Windows.Forms.TextBox txtMaterial3;
        private System.Windows.Forms.TextBox txtMaterial2;
        private System.Windows.Forms.TextBox txtMaterial1;
        private System.Windows.Forms.NumericUpDown nIdMeasure;
        private System.Windows.Forms.Label label3;
    }
}

