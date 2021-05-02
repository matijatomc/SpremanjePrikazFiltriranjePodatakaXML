namespace tomcMatijaSpremanjePrikazFiltriranjeXml
{
    partial class FormaXMLTransformerUnos
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRazred = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbRazred = new System.Windows.Forms.ComboBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 57);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail";
            // 
            // lblRazred
            // 
            this.lblRazred.AutoSize = true;
            this.lblRazred.Location = new System.Drawing.Point(12, 155);
            this.lblRazred.Name = "lblRazred";
            this.lblRazred.Size = new System.Drawing.Size(41, 13);
            this.lblRazred.TabIndex = 3;
            this.lblRazred.Text = "Razred";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(15, 25);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(244, 20);
            this.txtIme.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(15, 73);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(244, 20);
            this.txtPrezime.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // cmbRazred
            // 
            this.cmbRazred.FormattingEnabled = true;
            this.cmbRazred.Items.AddRange(new object[] {
            "1.A",
            "1.B",
            "1.C",
            "1.D",
            "2.A",
            "2.B",
            "2.C",
            "2.D",
            "3.A",
            "3.B",
            "3.C",
            "3.D",
            "4.A",
            "4.B",
            "4.C",
            "4.D"});
            this.cmbRazred.Location = new System.Drawing.Point(15, 171);
            this.cmbRazred.Name = "cmbRazred";
            this.cmbRazred.Size = new System.Drawing.Size(244, 21);
            this.cmbRazred.TabIndex = 7;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(12, 230);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(247, 23);
            this.btnUnos.TabIndex = 8;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Location = new System.Drawing.Point(12, 259);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(247, 23);
            this.btnZavrsi.TabIndex = 9;
            this.btnZavrsi.Text = "Završi";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // FormaXMLTransformerUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 294);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.cmbRazred);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblRazred);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "FormaXMLTransformerUnos";
            this.Text = "Unos Podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRazred;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbRazred;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnZavrsi;
    }
}