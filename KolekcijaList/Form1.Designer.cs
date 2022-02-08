namespace KolekcijaList
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.labeLime = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.comboBoxRazred = new System.Windows.Forms.ComboBox();
            this.labelRazred = new System.Windows.Forms.Label();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(21, 185);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(118, 67);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(89, 78);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(210, 20);
            this.textBoxIme.TabIndex = 1;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(89, 105);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(210, 20);
            this.textBoxPrezime.TabIndex = 2;
            // 
            // labeLime
            // 
            this.labeLime.AutoSize = true;
            this.labeLime.Location = new System.Drawing.Point(42, 78);
            this.labeLime.Name = "labeLime";
            this.labeLime.Size = new System.Drawing.Size(24, 13);
            this.labeLime.TabIndex = 3;
            this.labeLime.Text = "Ime";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(39, 112);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(44, 13);
            this.labelPrezime.TabIndex = 4;
            this.labelPrezime.Text = "Prezime";
            // 
            // comboBoxRazred
            // 
            this.comboBoxRazred.FormattingEnabled = true;
            this.comboBoxRazred.Items.AddRange(new object[] {
            "1.",
            "2.",
            "3.",
            "4."});
            this.comboBoxRazred.Location = new System.Drawing.Point(89, 142);
            this.comboBoxRazred.Name = "comboBoxRazred";
            this.comboBoxRazred.Size = new System.Drawing.Size(210, 21);
            this.comboBoxRazred.TabIndex = 5;
            // 
            // labelRazred
            // 
            this.labelRazred.AutoSize = true;
            this.labelRazred.Location = new System.Drawing.Point(39, 150);
            this.labelRazred.Name = "labelRazred";
            this.labelRazred.Size = new System.Drawing.Size(41, 13);
            this.labelRazred.TabIndex = 6;
            this.labelRazred.Text = "Razred";
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(269, 185);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(118, 67);
            this.btnObrada.TabIndex = 7;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Location = new System.Drawing.Point(145, 185);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(118, 67);
            this.btnPregled.TabIndex = 8;
            this.btnPregled.Text = "Pregled";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(21, 283);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(366, 130);
            this.rtbIspis.TabIndex = 9;
            this.rtbIspis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 425);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.labelRazred);
            this.Controls.Add(this.comboBoxRazred);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labeLime);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.btnUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label labeLime;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.ComboBox comboBoxRazred;
        private System.Windows.Forms.Label labelRazred;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.RichTextBox rtbIspis;
    }
}

