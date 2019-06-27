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
            this.btnAcquisisceMisure = new System.Windows.Forms.Button();
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
            this.btnMetodoTest.Location = new System.Drawing.Point(24, 12);
            this.btnMetodoTest.Name = "btnMetodoTest";
            this.btnMetodoTest.Size = new System.Drawing.Size(75, 23);
            this.btnMetodoTest.TabIndex = 1;
            this.btnMetodoTest.Text = "MetodoTest";
            this.btnMetodoTest.UseVisualStyleBackColor = true;
            this.btnMetodoTest.Click += new System.EventHandler(this.btnMetodoTest_Click);
            // 
            // btnAcquisiceCodice
            // 
            this.btnAcquisiceCodice.Location = new System.Drawing.Point(136, 12);
            this.btnAcquisiceCodice.Name = "btnAcquisiceCodice";
            this.btnAcquisiceCodice.Size = new System.Drawing.Size(75, 23);
            this.btnAcquisiceCodice.TabIndex = 1;
            this.btnAcquisiceCodice.Text = "Acquisisce codice";
            this.btnAcquisiceCodice.UseVisualStyleBackColor = true;
            this.btnAcquisiceCodice.Click += new System.EventHandler(this.btnAcquisiceCodice_Click);
            // 
            // btnAcquisisceMisure
            // 
            this.btnAcquisisceMisure.Location = new System.Drawing.Point(260, 12);
            this.btnAcquisisceMisure.Name = "btnAcquisisceMisure";
            this.btnAcquisisceMisure.Size = new System.Drawing.Size(75, 23);
            this.btnAcquisisceMisure.TabIndex = 1;
            this.btnAcquisisceMisure.Text = "Acquisice misure";
            this.btnAcquisisceMisure.UseVisualStyleBackColor = true;
            this.btnAcquisisceMisure.Click += new System.EventHandler(this.btnAcquisisceMisure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAcquisisceMisure);
            this.Controls.Add(this.btnAcquisiceCodice);
            this.Controls.Add(this.btnMetodoTest);
            this.Controls.Add(this.txtMessaggio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.Button btnMetodoTest;
        private System.Windows.Forms.Button btnAcquisiceCodice;
        private System.Windows.Forms.Button btnAcquisisceMisure;
    }
}

