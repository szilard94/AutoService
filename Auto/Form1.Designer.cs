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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.beallitasok = new System.Windows.Forms.Button();
            this.ujszerviz = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keresoeredmeny)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(778, 481);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Location = new System.Drawing.Point(3, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 475);
            this.panel3.TabIndex = 1;
            this.panel3.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

