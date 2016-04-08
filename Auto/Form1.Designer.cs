namespace Auto
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
            this.keresogomb = new System.Windows.Forms.Button();
            this.muszaki = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.nevkereso = new System.Windows.Forms.RadioButton();
            this.keresoeredmeny = new System.Windows.Forms.DataGridView();
            this.kereso = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.beallitasok = new System.Windows.Forms.Button();
            this.ujszerviz = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ujalvaz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rendszam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.marka = new System.Windows.Forms.TextBox();
            this.tipus = new System.Windows.Forms.TextBox();
            this.evjarat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tulajnev = new System.Windows.Forms.TextBox();
            this.fax = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.mobil = new System.Windows.Forms.TextBox();
            this.megye = new System.Windows.Forms.TextBox();
            this.Cim = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.szerviznyitas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keresoeredmeny)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // keresogomb
            // 
            this.keresogomb.Location = new System.Drawing.Point(12, 12);
            this.keresogomb.Name = "keresogomb";
            this.keresogomb.Size = new System.Drawing.Size(75, 23);
            this.keresogomb.TabIndex = 0;
            this.keresogomb.Text = "Kereső";
            this.keresogomb.UseVisualStyleBackColor = true;
            this.keresogomb.Click += new System.EventHandler(this.keresogomb_Click);
            // 
            // muszaki
            // 
            this.muszaki.Location = new System.Drawing.Point(120, 11);
            this.muszaki.Name = "muszaki";
            this.muszaki.Size = new System.Drawing.Size(75, 23);
            this.muszaki.TabIndex = 1;
            this.muszaki.Text = "Műszaki";
            this.muszaki.UseVisualStyleBackColor = true;
            this.muszaki.Click += new System.EventHandler(this.muszaki_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.nevkereso);
            this.panel1.Controls.Add(this.keresoeredmeny);
            this.panel1.Controls.Add(this.kereso);
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 487);
            this.panel1.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(139, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Alvázszám alapján";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // nevkereso
            // 
            this.nevkereso.AutoSize = true;
            this.nevkereso.Checked = true;
            this.nevkereso.Location = new System.Drawing.Point(13, 75);
            this.nevkereso.Name = "nevkereso";
            this.nevkereso.Size = new System.Drawing.Size(82, 17);
            this.nevkereso.TabIndex = 2;
            this.nevkereso.TabStop = true;
            this.nevkereso.Text = "Név alapján";
            this.nevkereso.UseVisualStyleBackColor = true;
            // 
            // keresoeredmeny
            // 
            this.keresoeredmeny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keresoeredmeny.Location = new System.Drawing.Point(12, 112);
            this.keresoeredmeny.Name = "keresoeredmeny";
            this.keresoeredmeny.Size = new System.Drawing.Size(751, 366);
            this.keresoeredmeny.TabIndex = 1;
            // 
            // kereso
            // 
            this.kereso.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.kereso.Location = new System.Drawing.Point(13, 21);
            this.kereso.Name = "kereso";
            this.kereso.Size = new System.Drawing.Size(751, 20);
            this.kereso.TabIndex = 0;
            this.kereso.Text = "Kereső";
            this.kereso.Click += new System.EventHandler(this.keresogomb_Click);
            this.kereso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.keresoUrit);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 469);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Location = new System.Drawing.Point(3, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 454);
            this.panel3.TabIndex = 1;
            this.panel3.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 112);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // beallitasok
            // 
            this.beallitasok.Location = new System.Drawing.Point(236, 11);
            this.beallitasok.Name = "beallitasok";
            this.beallitasok.Size = new System.Drawing.Size(75, 23);
            this.beallitasok.TabIndex = 4;
            this.beallitasok.Text = "Beállitások";
            this.beallitasok.UseVisualStyleBackColor = true;
            this.beallitasok.Click += new System.EventHandler(this.beallitasok_Click);
            // 
            // ujszerviz
            // 
            this.ujszerviz.Location = new System.Drawing.Point(12, 51);
            this.ujszerviz.Name = "ujszerviz";
            this.ujszerviz.Size = new System.Drawing.Size(75, 23);
            this.ujszerviz.TabIndex = 5;
            this.ujszerviz.Text = "Új szerviz";
            this.ujszerviz.UseVisualStyleBackColor = true;
            this.ujszerviz.Click += new System.EventHandler(this.ujszerviz_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.szerviznyitas);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.email);
            this.panel4.Controls.Add(this.Cim);
            this.panel4.Controls.Add(this.megye);
            this.panel4.Controls.Add(this.mobil);
            this.panel4.Controls.Add(this.telefon);
            this.panel4.Controls.Add(this.fax);
            this.panel4.Controls.Add(this.tulajnev);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.evjarat);
            this.panel4.Controls.Add(this.tipus);
            this.panel4.Controls.Add(this.marka);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.rendszam);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.ujalvaz);
            this.panel4.Location = new System.Drawing.Point(3, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 446);
            this.panel4.TabIndex = 6;
            this.panel4.Visible = false;
            // 
            // ujalvaz
            // 
            this.ujalvaz.Location = new System.Drawing.Point(11, 44);
            this.ujalvaz.Name = "ujalvaz";
            this.ujalvaz.Size = new System.Drawing.Size(150, 20);
            this.ujalvaz.TabIndex = 0;
            this.ujalvaz.TextChanged += new System.EventHandler(this.ujalvaz_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add meg az alvázszámot!";
            // 
            // rendszam
            // 
            this.rendszam.Enabled = false;
            this.rendszam.Location = new System.Drawing.Point(11, 107);
            this.rendszam.Name = "rendszam";
            this.rendszam.Size = new System.Drawing.Size(150, 20);
            this.rendszam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add meg a rendszámot!";
            // 
            // marka
            // 
            this.marka.Enabled = false;
            this.marka.Location = new System.Drawing.Point(222, 106);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(148, 20);
            this.marka.TabIndex = 4;
            // 
            // tipus
            // 
            this.tipus.Enabled = false;
            this.tipus.Location = new System.Drawing.Point(436, 107);
            this.tipus.Name = "tipus";
            this.tipus.Size = new System.Drawing.Size(144, 20);
            this.tipus.TabIndex = 5;
            // 
            // evjarat
            // 
            this.evjarat.Enabled = false;
            this.evjarat.Location = new System.Drawing.Point(644, 106);
            this.evjarat.Name = "evjarat";
            this.evjarat.Size = new System.Drawing.Size(125, 20);
            this.evjarat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Márka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Évjárat";
            // 
            // tulajnev
            // 
            this.tulajnev.Enabled = false;
            this.tulajnev.Location = new System.Drawing.Point(11, 180);
            this.tulajnev.Name = "tulajnev";
            this.tulajnev.Size = new System.Drawing.Size(150, 20);
            this.tulajnev.TabIndex = 10;
            // 
            // fax
            // 
            this.fax.Enabled = false;
            this.fax.Location = new System.Drawing.Point(9, 256);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(152, 20);
            this.fax.TabIndex = 11;
            // 
            // telefon
            // 
            this.telefon.Enabled = false;
            this.telefon.Location = new System.Drawing.Point(222, 256);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(148, 20);
            this.telefon.TabIndex = 12;
            // 
            // mobil
            // 
            this.mobil.Enabled = false;
            this.mobil.Location = new System.Drawing.Point(436, 256);
            this.mobil.Name = "mobil";
            this.mobil.Size = new System.Drawing.Size(144, 20);
            this.mobil.TabIndex = 13;
            // 
            // megye
            // 
            this.megye.Enabled = false;
            this.megye.Location = new System.Drawing.Point(222, 338);
            this.megye.Name = "megye";
            this.megye.Size = new System.Drawing.Size(148, 20);
            this.megye.TabIndex = 14;
            // 
            // Cim
            // 
            this.Cim.Enabled = false;
            this.Cim.Location = new System.Drawing.Point(436, 338);
            this.Cim.Name = "Cim";
            this.Cim.Size = new System.Drawing.Size(144, 20);
            this.Cim.TabIndex = 15;
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(10, 338);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(151, 20);
            this.email.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ügyfél Neve";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Telefon ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mobil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Megye";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cím";
            // 
            // szerviznyitas
            // 
            this.szerviznyitas.Enabled = false;
            this.szerviznyitas.Location = new System.Drawing.Point(644, 398);
            this.szerviznyitas.Name = "szerviznyitas";
            this.szerviznyitas.Size = new System.Drawing.Size(95, 23);
            this.szerviznyitas.TabIndex = 24;
            this.szerviznyitas.Text = "Szerviznyitas";
            this.szerviznyitas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ujszerviz);
            this.Controls.Add(this.beallitasok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.muszaki);
            this.Controls.Add(this.keresogomb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keresoeredmeny)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button keresogomb;
        private System.Windows.Forms.Button muszaki;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton nevkereso;
        private System.Windows.Forms.DataGridView keresoeredmeny;
        private System.Windows.Forms.TextBox kereso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button beallitasok;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ujszerviz;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ujalvaz;
        private System.Windows.Forms.TextBox rendszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox evjarat;
        private System.Windows.Forms.TextBox tipus;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox mobil;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox fax;
        private System.Windows.Forms.TextBox tulajnev;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox Cim;
        private System.Windows.Forms.TextBox megye;
        private System.Windows.Forms.Button szerviznyitas;
    }
}

