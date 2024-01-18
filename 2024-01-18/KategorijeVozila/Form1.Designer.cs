namespace KategorijeVozila
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
            this.model = new System.Windows.Forms.TextBox();
            this.godina_proizvodnje = new System.Windows.Forms.TextBox();
            this.broj_kotaca = new System.Windows.Forms.TextBox();
            this.unos_b = new System.Windows.Forms.Button();
            this.obrada_b = new System.Windows.Forms.Button();
            this.ispis_b = new System.Windows.Forms.Button();
            this.kategorija = new System.Windows.Forms.TextBox();
            this.ispis = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(204, 95);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(100, 26);
            this.model.TabIndex = 6;
            // 
            // godina_proizvodnje
            // 
            this.godina_proizvodnje.Location = new System.Drawing.Point(204, 147);
            this.godina_proizvodnje.Name = "godina_proizvodnje";
            this.godina_proizvodnje.Size = new System.Drawing.Size(100, 26);
            this.godina_proizvodnje.TabIndex = 7;
            // 
            // broj_kotaca
            // 
            this.broj_kotaca.Location = new System.Drawing.Point(204, 208);
            this.broj_kotaca.Name = "broj_kotaca";
            this.broj_kotaca.Size = new System.Drawing.Size(100, 26);
            this.broj_kotaca.TabIndex = 8;
            // 
            // unos_b
            // 
            this.unos_b.Location = new System.Drawing.Point(90, 336);
            this.unos_b.Name = "unos_b";
            this.unos_b.Size = new System.Drawing.Size(75, 23);
            this.unos_b.TabIndex = 9;
            this.unos_b.Text = "Unos";
            this.unos_b.UseVisualStyleBackColor = true;
            this.unos_b.Click += new System.EventHandler(this.unos_b_Click);
            // 
            // obrada_b
            // 
            this.obrada_b.Location = new System.Drawing.Point(204, 336);
            this.obrada_b.Name = "obrada_b";
            this.obrada_b.Size = new System.Drawing.Size(75, 23);
            this.obrada_b.TabIndex = 10;
            this.obrada_b.Text = "Obrada";
            this.obrada_b.UseVisualStyleBackColor = true;
            this.obrada_b.Click += new System.EventHandler(this.obrada_b_Click);
            // 
            // ispis_b
            // 
            this.ispis_b.Location = new System.Drawing.Point(321, 336);
            this.ispis_b.Name = "ispis_b";
            this.ispis_b.Size = new System.Drawing.Size(75, 23);
            this.ispis_b.TabIndex = 11;
            this.ispis_b.Text = "Ispis";
            this.ispis_b.UseVisualStyleBackColor = true;
            this.ispis_b.Click += new System.EventHandler(this.ispis_b_Click);
            // 
            // kategorija
            // 
            this.kategorija.Location = new System.Drawing.Point(204, 262);
            this.kategorija.Name = "kategorija";
            this.kategorija.ReadOnly = true;
            this.kategorija.Size = new System.Drawing.Size(100, 26);
            this.kategorija.TabIndex = 13;
            // 
            // ispis
            // 
            this.ispis.Location = new System.Drawing.Point(434, 70);
            this.ispis.Name = "ispis";
            this.ispis.ReadOnly = true;
            this.ispis.Size = new System.Drawing.Size(340, 289);
            this.ispis.TabIndex = 14;
            this.ispis.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Godina proizvodnje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Broj kotača:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kategorija:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ispis);
            this.Controls.Add(this.kategorija);
            this.Controls.Add(this.ispis_b);
            this.Controls.Add(this.obrada_b);
            this.Controls.Add(this.unos_b);
            this.Controls.Add(this.broj_kotaca);
            this.Controls.Add(this.godina_proizvodnje);
            this.Controls.Add(this.model);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox godina_proizvodnje;
        private System.Windows.Forms.TextBox broj_kotaca;
        private System.Windows.Forms.Button unos_b;
        private System.Windows.Forms.Button obrada_b;
        private System.Windows.Forms.Button ispis_b;
        private System.Windows.Forms.TextBox kategorija;
        private System.Windows.Forms.RichTextBox ispis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

