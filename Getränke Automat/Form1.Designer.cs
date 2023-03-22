namespace Getränke_Automat
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_10ct = new System.Windows.Forms.Button();
            this.btn_20ct = new System.Windows.Forms.Button();
            this.btn_50ct = new System.Windows.Forms.Button();
            this.btn_1eur = new System.Windows.Forms.Button();
            this.btn_2eur = new System.Windows.Forms.Button();
            this.txt_eingabe = new System.Windows.Forms.TextBox();
            this.rb_03 = new System.Windows.Forms.RadioButton();
            this.rb_04 = new System.Windows.Forms.RadioButton();
            this.rb_wasser = new System.Windows.Forms.RadioButton();
            this.rb_fanta = new System.Windows.Forms.RadioButton();
            this.rb_cola = new System.Windows.Forms.RadioButton();
            this.rb_Apfelschorle = new System.Windows.Forms.RadioButton();
            this.btn_bestellen = new System.Windows.Forms.Button();
            this.txt_ausgabe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_10ct
            // 
            this.btn_10ct.Location = new System.Drawing.Point(12, 38);
            this.btn_10ct.Name = "btn_10ct";
            this.btn_10ct.Size = new System.Drawing.Size(75, 23);
            this.btn_10ct.TabIndex = 2;
            this.btn_10ct.Text = "10 ct";
            this.btn_10ct.UseVisualStyleBackColor = true;
            this.btn_10ct.Click += new System.EventHandler(this.geld_eingezahlt);
            // 
            // btn_20ct
            // 
            this.btn_20ct.Location = new System.Drawing.Point(12, 67);
            this.btn_20ct.Name = "btn_20ct";
            this.btn_20ct.Size = new System.Drawing.Size(75, 23);
            this.btn_20ct.TabIndex = 3;
            this.btn_20ct.Text = "20 ct";
            this.btn_20ct.UseVisualStyleBackColor = true;
            this.btn_20ct.Click += new System.EventHandler(this.geld_eingezahlt);
            // 
            // btn_50ct
            // 
            this.btn_50ct.Location = new System.Drawing.Point(12, 96);
            this.btn_50ct.Name = "btn_50ct";
            this.btn_50ct.Size = new System.Drawing.Size(75, 23);
            this.btn_50ct.TabIndex = 4;
            this.btn_50ct.Text = "50 ct";
            this.btn_50ct.UseVisualStyleBackColor = true;
            this.btn_50ct.Click += new System.EventHandler(this.geld_eingezahlt);
            // 
            // btn_1eur
            // 
            this.btn_1eur.Location = new System.Drawing.Point(12, 125);
            this.btn_1eur.Name = "btn_1eur";
            this.btn_1eur.Size = new System.Drawing.Size(75, 23);
            this.btn_1eur.TabIndex = 5;
            this.btn_1eur.Text = "1 €";
            this.btn_1eur.UseVisualStyleBackColor = true;
            this.btn_1eur.Click += new System.EventHandler(this.geld_eingezahlt);
            // 
            // btn_2eur
            // 
            this.btn_2eur.Location = new System.Drawing.Point(12, 154);
            this.btn_2eur.Name = "btn_2eur";
            this.btn_2eur.Size = new System.Drawing.Size(75, 23);
            this.btn_2eur.TabIndex = 6;
            this.btn_2eur.Text = "2 €";
            this.btn_2eur.UseVisualStyleBackColor = true;
            this.btn_2eur.Click += new System.EventHandler(this.geld_eingezahlt);
            // 
            // txt_eingabe
            // 
            this.txt_eingabe.Location = new System.Drawing.Point(12, 12);
            this.txt_eingabe.Name = "txt_eingabe";
            this.txt_eingabe.Size = new System.Drawing.Size(75, 20);
            this.txt_eingabe.TabIndex = 7;
            // 
            // rb_03
            // 
            this.rb_03.AutoSize = true;
            this.rb_03.Checked = true;
            this.rb_03.Location = new System.Drawing.Point(0, 0);
            this.rb_03.Name = "rb_03";
            this.rb_03.Size = new System.Drawing.Size(42, 17);
            this.rb_03.TabIndex = 8;
            this.rb_03.TabStop = true;
            this.rb_03.Text = "0,3l";
            this.rb_03.UseVisualStyleBackColor = true;
            // 
            // rb_04
            // 
            this.rb_04.AutoSize = true;
            this.rb_04.Location = new System.Drawing.Point(0, 28);
            this.rb_04.Name = "rb_04";
            this.rb_04.Size = new System.Drawing.Size(42, 17);
            this.rb_04.TabIndex = 9;
            this.rb_04.Text = "0,4l";
            this.rb_04.UseVisualStyleBackColor = true;
            // 
            // rb_wasser
            // 
            this.rb_wasser.AutoSize = true;
            this.rb_wasser.Checked = true;
            this.rb_wasser.Location = new System.Drawing.Point(0, 0);
            this.rb_wasser.Name = "rb_wasser";
            this.rb_wasser.Size = new System.Drawing.Size(61, 17);
            this.rb_wasser.TabIndex = 10;
            this.rb_wasser.TabStop = true;
            this.rb_wasser.Text = "Wasser";
            this.rb_wasser.UseVisualStyleBackColor = true;
            // 
            // rb_fanta
            // 
            this.rb_fanta.AutoSize = true;
            this.rb_fanta.Location = new System.Drawing.Point(0, 58);
            this.rb_fanta.Name = "rb_fanta";
            this.rb_fanta.Size = new System.Drawing.Size(52, 17);
            this.rb_fanta.TabIndex = 11;
            this.rb_fanta.Text = "Fanta";
            this.rb_fanta.UseVisualStyleBackColor = true;
            // 
            // rb_cola
            // 
            this.rb_cola.AutoSize = true;
            this.rb_cola.Location = new System.Drawing.Point(0, 87);
            this.rb_cola.Name = "rb_cola";
            this.rb_cola.Size = new System.Drawing.Size(46, 17);
            this.rb_cola.TabIndex = 12;
            this.rb_cola.Text = "Cola";
            this.rb_cola.UseVisualStyleBackColor = true;
            // 
            // rb_Apfelschorle
            // 
            this.rb_Apfelschorle.AutoSize = true;
            this.rb_Apfelschorle.Location = new System.Drawing.Point(0, 29);
            this.rb_Apfelschorle.Name = "rb_Apfelschorle";
            this.rb_Apfelschorle.Size = new System.Drawing.Size(83, 17);
            this.rb_Apfelschorle.TabIndex = 13;
            this.rb_Apfelschorle.Text = "Apfelschorle";
            this.rb_Apfelschorle.UseVisualStyleBackColor = true;
            // 
            // btn_bestellen
            // 
            this.btn_bestellen.Location = new System.Drawing.Point(12, 183);
            this.btn_bestellen.Name = "btn_bestellen";
            this.btn_bestellen.Size = new System.Drawing.Size(164, 48);
            this.btn_bestellen.TabIndex = 14;
            this.btn_bestellen.Text = "Bestellen";
            this.btn_bestellen.UseVisualStyleBackColor = true;
            this.btn_bestellen.Click += new System.EventHandler(this.btn_bestellen_Click);
            // 
            // txt_ausgabe
            // 
            this.txt_ausgabe.Location = new System.Drawing.Point(181, 12);
            this.txt_ausgabe.Name = "txt_ausgabe";
            this.txt_ausgabe.Size = new System.Drawing.Size(100, 20);
            this.txt_ausgabe.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_03);
            this.panel1.Controls.Add(this.rb_04);
            this.panel1.Location = new System.Drawing.Point(93, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 49);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_wasser);
            this.panel2.Controls.Add(this.rb_fanta);
            this.panel2.Controls.Add(this.rb_cola);
            this.panel2.Controls.Add(this.rb_Apfelschorle);
            this.panel2.Location = new System.Drawing.Point(93, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 110);
            this.panel2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 242);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_ausgabe);
            this.Controls.Add(this.btn_bestellen);
            this.Controls.Add(this.txt_eingabe);
            this.Controls.Add(this.btn_2eur);
            this.Controls.Add(this.btn_1eur);
            this.Controls.Add(this.btn_50ct);
            this.Controls.Add(this.btn_20ct);
            this.Controls.Add(this.btn_10ct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_10ct;
        private System.Windows.Forms.Button btn_20ct;
        private System.Windows.Forms.Button btn_50ct;
        private System.Windows.Forms.Button btn_1eur;
        private System.Windows.Forms.Button btn_2eur;
        private System.Windows.Forms.TextBox txt_eingabe;
        private System.Windows.Forms.RadioButton rb_03;
        private System.Windows.Forms.RadioButton rb_04;
        private System.Windows.Forms.RadioButton rb_wasser;
        private System.Windows.Forms.RadioButton rb_fanta;
        private System.Windows.Forms.RadioButton rb_cola;
        private System.Windows.Forms.RadioButton rb_Apfelschorle;
        private System.Windows.Forms.Button btn_bestellen;
        private System.Windows.Forms.TextBox txt_ausgabe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

