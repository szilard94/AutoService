﻿namespace Auto
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
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.muszakilejarata = new System.Windows.Forms.DateTimePicker();
            this.muszakiztatasideje = new System.Windows.Forms.DateTimePicker();
            this.muszakiaktualizalas = new System.Windows.Forms.Button();
            this.muszakievjarat = new System.Windows.Forms.TextBox();
            this.muszakitipus = new System.Windows.Forms.TextBox();
            this.muszakimarka = new System.Windows.Forms.TextBox();
            this.muszakirendszam = new System.Windows.Forms.TextBox();
            this.alvazmuszaki = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.ugyfellista = new System.Windows.Forms.DataGridView();
            this.szerviznyitas = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.Cim = new System.Windows.Forms.TextBox();
            this.megye = new System.Windows.Forms.TextBox();
            this.mobil = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.fax = new System.Windows.Forms.TextBox();
            this.tulajnev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.evjarat = new System.Windows.Forms.TextBox();
            this.tipus = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rendszam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ujalvaz = new System.Windows.Forms.TextBox();
            this.beallitasok = new System.Windows.Forms.Button();
            this.ujszerviz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keresoeredmeny)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfellista)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 474);
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
            this.keresoeredmeny.AllowUserToAddRows = false;
            this.keresoeredmeny.AllowUserToDeleteRows = false;
            this.keresoeredmeny.AllowUserToResizeColumns = false;
            this.keresoeredmeny.AllowUserToResizeRows = false;
            this.keresoeredmeny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.keresoeredmeny.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.keresoeredmeny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keresoeredmeny.Location = new System.Drawing.Point(12, 112);
            this.keresoeredmeny.MultiSelect = false;
            this.keresoeredmeny.Name = "keresoeredmeny";
            this.keresoeredmeny.ReadOnly = true;
            this.keresoeredmeny.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.keresoeredmeny.RowTemplate.ReadOnly = true;
            this.keresoeredmeny.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.kereso.TextChanged += new System.EventHandler(this.keres);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.muszakilejarata);
            this.panel2.Controls.Add(this.muszakiztatasideje);
            this.panel2.Controls.Add(this.muszakiaktualizalas);
            this.panel2.Controls.Add(this.muszakievjarat);
            this.panel2.Controls.Add(this.muszakitipus);
            this.panel2.Controls.Add(this.muszakimarka);
            this.panel2.Controls.Add(this.muszakirendszam);
            this.panel2.Controls.Add(this.alvazmuszaki);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 469);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(375, 413);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Müszaki Lejárása";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(45, 413);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Utolsó Müszaki ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(677, 356);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Évjárat";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(486, 355);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Tipus";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(276, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Márka";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 356);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Rendszám";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Alvázszám";
            // 
            // muszakilejarata
            // 
            this.muszakilejarata.Location = new System.Drawing.Point(316, 432);
            this.muszakilejarata.Name = "muszakilejarata";
            this.muszakilejarata.Size = new System.Drawing.Size(200, 20);
            this.muszakilejarata.TabIndex = 11;
            // 
            // muszakiztatasideje
            // 
            this.muszakiztatasideje.Location = new System.Drawing.Point(12, 432);
            this.muszakiztatasideje.Name = "muszakiztatasideje";
            this.muszakiztatasideje.Size = new System.Drawing.Size(200, 20);
            this.muszakiztatasideje.TabIndex = 10;
            this.muszakiztatasideje.Value = new System.DateTime(2016, 4, 9, 0, 0, 0, 0);
            // 
            // muszakiaktualizalas
            // 
            this.muszakiaktualizalas.Location = new System.Drawing.Point(613, 429);
            this.muszakiaktualizalas.Name = "muszakiaktualizalas";
            this.muszakiaktualizalas.Size = new System.Drawing.Size(75, 23);
            this.muszakiaktualizalas.TabIndex = 9;
            this.muszakiaktualizalas.Text = "Aktualizálás";
            this.muszakiaktualizalas.UseVisualStyleBackColor = true;
            // 
            // muszakievjarat
            // 
            this.muszakievjarat.Enabled = false;
            this.muszakievjarat.Location = new System.Drawing.Point(631, 376);
            this.muszakievjarat.Name = "muszakievjarat";
            this.muszakievjarat.Size = new System.Drawing.Size(130, 20);
            this.muszakievjarat.TabIndex = 6;
            // 
            // muszakitipus
            // 
            this.muszakitipus.Enabled = false;
            this.muszakitipus.Location = new System.Drawing.Point(436, 375);
            this.muszakitipus.Name = "muszakitipus";
            this.muszakitipus.Size = new System.Drawing.Size(135, 20);
            this.muszakitipus.TabIndex = 5;
            // 
            // muszakimarka
            // 
            this.muszakimarka.Enabled = false;
            this.muszakimarka.Location = new System.Drawing.Point(226, 375);
            this.muszakimarka.Name = "muszakimarka";
            this.muszakimarka.Size = new System.Drawing.Size(143, 20);
            this.muszakimarka.TabIndex = 4;
            // 
            // muszakirendszam
            // 
            this.muszakirendszam.Enabled = false;
            this.muszakirendszam.Location = new System.Drawing.Point(13, 375);
            this.muszakirendszam.Name = "muszakirendszam";
            this.muszakirendszam.Size = new System.Drawing.Size(147, 20);
            this.muszakirendszam.TabIndex = 3;
            // 
            // alvazmuszaki
            // 
            this.alvazmuszaki.Location = new System.Drawing.Point(12, 323);
            this.alvazmuszaki.MaxLength = 17;
            this.alvazmuszaki.Name = "alvazmuszaki";
            this.alvazmuszaki.Size = new System.Drawing.Size(147, 20);
            this.alvazmuszaki.TabIndex = 2;
            this.alvazmuszaki.TextChanged += new System.EventHandler(this.alvazmuszaki_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Location = new System.Drawing.Point(3, 89);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Controls.Add(this.ugyfellista);
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
            this.panel4.Location = new System.Drawing.Point(-1, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(782, 446);
            this.panel4.TabIndex = 6;
            this.panel4.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(222, 132);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 17);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "Új ügyfél";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ugyfellista
            // 
            this.ugyfellista.AllowUserToAddRows = false;
            this.ugyfellista.AllowUserToDeleteRows = false;
            this.ugyfellista.AllowUserToResizeColumns = false;
            this.ugyfellista.AllowUserToResizeRows = false;
            this.ugyfellista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ugyfellista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ugyfellista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ugyfellista.Enabled = false;
            this.ugyfellista.Location = new System.Drawing.Point(222, 176);
            this.ugyfellista.MultiSelect = false;
            this.ugyfellista.Name = "ugyfellista";
            this.ugyfellista.ReadOnly = true;
            this.ugyfellista.RowTemplate.ReadOnly = true;
            this.ugyfellista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ugyfellista.Size = new System.Drawing.Size(542, 201);
            this.ugyfellista.TabIndex = 27;
            this.ugyfellista.Click += new System.EventHandler(this.ugyfellista_Click);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(526, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cím";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Megye";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mobil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Telefon ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ügyfél Neve";
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(7, 417);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(151, 20);
            this.email.TabIndex = 16;
            // 
            // Cim
            // 
            this.Cim.Enabled = false;
            this.Cim.Location = new System.Drawing.Point(474, 417);
            this.Cim.Name = "Cim";
            this.Cim.Size = new System.Drawing.Size(144, 20);
            this.Cim.TabIndex = 15;
            // 
            // megye
            // 
            this.megye.Enabled = false;
            this.megye.Location = new System.Drawing.Point(237, 417);
            this.megye.Name = "megye";
            this.megye.Size = new System.Drawing.Size(148, 20);
            this.megye.TabIndex = 14;
            // 
            // mobil
            // 
            this.mobil.Enabled = false;
            this.mobil.Location = new System.Drawing.Point(15, 340);
            this.mobil.Name = "mobil";
            this.mobil.Size = new System.Drawing.Size(144, 20);
            this.mobil.TabIndex = 13;
            // 
            // telefon
            // 
            this.telefon.Enabled = false;
            this.telefon.Location = new System.Drawing.Point(13, 279);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(148, 20);
            this.telefon.TabIndex = 12;
            // 
            // fax
            // 
            this.fax.Enabled = false;
            this.fax.Location = new System.Drawing.Point(15, 232);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(152, 20);
            this.fax.TabIndex = 11;
            // 
            // tulajnev
            // 
            this.tulajnev.Enabled = false;
            this.tulajnev.Location = new System.Drawing.Point(25, 130);
            this.tulajnev.Name = "tulajnev";
            this.tulajnev.Size = new System.Drawing.Size(150, 20);
            this.tulajnev.TabIndex = 10;
            this.tulajnev.TextChanged += new System.EventHandler(this.ugyfeltKeres);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Évjárat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Márka";
            // 
            // evjarat
            // 
            this.evjarat.Enabled = false;
            this.evjarat.Location = new System.Drawing.Point(640, 69);
            this.evjarat.Name = "evjarat";
            this.evjarat.Size = new System.Drawing.Size(125, 20);
            this.evjarat.TabIndex = 6;
            // 
            // tipus
            // 
            this.tipus.Enabled = false;
            this.tipus.Location = new System.Drawing.Point(440, 69);
            this.tipus.Name = "tipus";
            this.tipus.Size = new System.Drawing.Size(144, 20);
            this.tipus.TabIndex = 5;
            // 
            // marka
            // 
            this.marka.Enabled = false;
            this.marka.Location = new System.Drawing.Point(222, 69);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(148, 20);
            this.marka.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add meg a rendszámot!";
            // 
            // rendszam
            // 
            this.rendszam.Enabled = false;
            this.rendszam.Location = new System.Drawing.Point(11, 69);
            this.rendszam.Name = "rendszam";
            this.rendszam.Size = new System.Drawing.Size(150, 20);
            this.rendszam.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add meg az alvázszámot!";
            // 
            // ujalvaz
            // 
            this.ujalvaz.Location = new System.Drawing.Point(13, 24);
            this.ujalvaz.MaxLength = 17;
            this.ujalvaz.Name = "ujalvaz";
            this.ujalvaz.Size = new System.Drawing.Size(150, 20);
            this.ujalvaz.TabIndex = 0;
            this.ujalvaz.TextChanged += new System.EventHandler(this.ujalvaz_TextChanged);
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
            this.ujszerviz.Location = new System.Drawing.Point(357, 11);
            this.ujszerviz.Name = "ujszerviz";
            this.ujszerviz.Size = new System.Drawing.Size(75, 23);
            this.ujszerviz.TabIndex = 5;
            this.ujszerviz.Text = "Új szerviz";
            this.ujszerviz.UseVisualStyleBackColor = true;
            this.ujszerviz.Click += new System.EventHandler(this.ujszerviz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ujszerviz);
            this.Controls.Add(this.beallitasok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.muszaki);
            this.Controls.Add(this.keresogomb);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keresoeredmeny)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfellista)).EndInit();
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
        private System.Windows.Forms.TextBox alvazmuszaki;
        private System.Windows.Forms.TextBox muszakievjarat;
        private System.Windows.Forms.TextBox muszakitipus;
        private System.Windows.Forms.TextBox muszakimarka;
        private System.Windows.Forms.TextBox muszakirendszam;
        private System.Windows.Forms.DateTimePicker muszakilejarata;
        private System.Windows.Forms.DateTimePicker muszakiztatasideje;
        private System.Windows.Forms.Button muszakiaktualizalas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView ugyfellista;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

