using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConnectToDB lekeres = new ConnectToDB();
            keresoeredmeny.DataSource = lekeres.selectFrom("*", "Jarmuvek").Tables[0];
            lekeres.closeConnection();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keresogomb_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
        }

        private void muszaki_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void beallitasok_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible =true;
            panel2.Visible = false;
            panel4.Visible = false;
        }
        private void ujszerviz_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = true;
        }



        private void keresoUrit(object sender, MouseEventArgs e)
        {
            kereso.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
    }

        private void ujalvaz_TextChanged(object sender, EventArgs e)
        {

        }

        private void rendszam_TextChanged(object sender, EventArgs e)
        {

        }

        private void marka_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipus_TextChanged(object sender, EventArgs e)
        {

        }

        private void evjarat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tulajnev_TextChanged(object sender, EventArgs e)
        {

        }

        private void fax_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
