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
            keresoeredmeny.DataSource = lekeres.selectFrom("nev AS Név, cim AS Cím, ceg AS Cég, rendszam AS Rendszám, marka AS Márka, tipus AS Típus, alvazszam AS Alvázszám, evjarat AS Évjárat", "Jarmuvek", "Ugyfelek ON Jarmuvek.UID = Ugyfelek.UID", "1=1").Tables[0];

        }

        private void keresogomb_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
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

        private void ujszervizInit()
        {
            rendszam.Text = "";
            marka.Text = "";
            tipus.Text = "";
            evjarat.Text = "";
            tulajnev.Text = "";
            fax.Text = "";
            telefon.Text = "";
            mobil.Text = "";
            email.Text = "";
            megye.Text = "";
            Cim.Text = "";

            szerviznyitas.Enabled = false;

            rendszam.Enabled = true;
            marka.Enabled = true;
            tipus.Enabled = true;
            evjarat.Enabled = true;
            tulajnev.Enabled = true;
            checkBox3.Enabled = true;
        }

        private void ujalvaz_TextChanged(object sender, EventArgs e)
        {
            if (ujalvaz.Text.Length == 17)
            {
                ConnectToDB lekeres = new ConnectToDB();
                DataSet datas = lekeres.selectFrom("SELECT rendszam, marka, tipus, evjarat, nev, fax, telefon, mobil, megye, cim, email FROM Jarmuvek JOIN Ugyfelek ON Jarmuvek.UID = Ugyfelek.UID WHERE alvazszam = " + ujalvaz.Text);
                if (datas.Tables[0].Rows.Count != 0)
                {
                    rendszam.Text = datas.Tables[0].Rows[0]["rendszam"].ToString();
                    marka.Text = datas.Tables[0].Rows[0]["marka"].ToString();
                    tipus.Text = datas.Tables[0].Rows[0]["tipus"].ToString();
                    evjarat.Text = datas.Tables[0].Rows[0]["evjarat"].ToString();
                    tulajnev.Text = datas.Tables[0].Rows[0]["nev"].ToString();
                    fax.Text = datas.Tables[0].Rows[0]["fax"].ToString();
                    telefon.Text = datas.Tables[0].Rows[0]["telefon"].ToString();
                    mobil.Text = datas.Tables[0].Rows[0]["mobil"].ToString();
                    email.Text = datas.Tables[0].Rows[0]["email"].ToString();
                    megye.Text = datas.Tables[0].Rows[0]["megye"].ToString();
                    Cim.Text = datas.Tables[0].Rows[0]["cim"].ToString();

                    rendszam.Enabled = false;
                    marka.Enabled = false;
                    tipus.Enabled = false;
                    evjarat.Enabled = false;
                    tulajnev.Enabled = false;
                    fax.Enabled = false;
                    telefon.Enabled = false;
                    mobil.Enabled = false;
                    email.Enabled = false;
                    megye.Enabled = false;
                    Cim.Enabled = false;
                    szerviznyitas.Enabled = true;
                }
                
                else
                {
                    ujszervizInit();
                }
            }
            else
            {
                szerviznyitas.Enabled = false;
                rendszam.Enabled = false;
                marka.Enabled = false;
                tipus.Enabled = false;
                evjarat.Enabled = false;
                tulajnev.Enabled = false;
                fax.Enabled = false;
                telefon.Enabled = false;
                mobil.Enabled = false;
                email.Enabled = false;
                megye.Enabled = false;
                Cim.Enabled = false;
                checkBox3.Enabled = false;
                checkBox3.Checked = false;

                rendszam.Text = "";
                marka.Text = "";
                tipus.Text = "";
                evjarat.Text = "";
                tulajnev.Text = "";
                fax.Text = "";
                telefon.Text = "";
                mobil.Text = "";
                email.Text = "";
                megye.Text = "";
                Cim.Text = "";
            }
        }

        private void alvazmuszaki_TextChanged(object sender, EventArgs e)
        {
            if (alvazmuszaki.Text.Length == 17)
            {
                ConnectToDB lekeres = new ConnectToDB();
                DataSet datas = lekeres.selectFrom("SELECT rendszam, marka, tipus, evjarat, nev, fax, telefon, mobil, megye, cim, email FROM Jarmuvek JOIN Ugyfelek ON Jarmuvek.UID = Ugyfelek.UID WHERE alvazszam = " + alvazmuszaki.Text);
                if (datas.Tables[0].Rows.Count != 0)
                {
                    muszakirendszam.Text = datas.Tables[0].Rows[0]["rendszam"].ToString();
                    muszakimarka.Text = datas.Tables[0].Rows[0]["marka"].ToString();
                    muszakitipus.Text = datas.Tables[0].Rows[0]["tipus"].ToString();
                    muszakievjarat.Text = datas.Tables[0].Rows[0]["evjarat"].ToString();

                    szerviznyitas.Enabled = true;
                }

            }
            
        }

        private void keres(object sender, EventArgs e)
        {
            ConnectToDB lekeres = new ConnectToDB();
            string miszerint = "nev";
            kereso.MaxLength = 50;
            if (radioButton2.Checked)
            {
                miszerint = "alvazszam";
                kereso.MaxLength = 17;
            }
            keresoeredmeny.DataSource = lekeres.selectFrom("nev AS Név, cim AS Cím, ceg AS Cég, rendszam AS Rendszám, marka AS Márka, tipus AS Típus, alvazszam AS Alvázszám, evjarat AS Évjárat", "Jarmuvek", "Ugyfelek ON Jarmuvek.UID = Ugyfelek.UID", miszerint + " LIKE '%" + kereso.Text + "%'").Tables[0];
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                fax.Enabled = true;
                telefon.Enabled = true;
                mobil.Enabled = true;
                email.Enabled = true;
                megye.Enabled = true;
                Cim.Enabled = true;
                ugyfellista.Enabled = false;
                ugyfellista.DataSource = null;
                szerviznyitas.Enabled = true;

                fax.Text = "";
                telefon.Text = "";
                mobil.Text = "";
                email.Text = "";
                megye.Text = "";
                Cim.Text = "";
            }
            else
            {
                szerviznyitas.Enabled = false;
                fax.Enabled = false;
                telefon.Enabled = false;
                mobil.Enabled = false;
                email.Enabled = false;
                megye.Enabled = false;
                Cim.Enabled = false;
                ugyfellista.Enabled = true;
            }
        }

        private void ugyfeltKeres(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false && tulajnev.Enabled == true)
            {
                ugyfellista.Enabled = true;
                ConnectToDB lekeres = new ConnectToDB();
                ugyfellista.DataSource = lekeres.selectFrom("SELECT nev AS Név, ceg AS Cég, fax AS Fax, telefon AS Telefon, mobil AS Mobil, email AS Email, megye AS Megye, cim AS Cím FROM Ugyfelek WHERE nev LIKE '%" + tulajnev.Text + "%'").Tables[0];
            }
        }

        private void ugyfellista_Click(object sender, EventArgs e)
        {
            tulajnev.Text = ugyfellista.CurrentRow.Cells["Név"].Value.ToString();
            fax.Text = ugyfellista.CurrentRow.Cells["Fax"].Value.ToString();
            telefon.Text = ugyfellista.CurrentRow.Cells["Telefon"].Value.ToString();
            mobil.Text = ugyfellista.CurrentRow.Cells["Mobil"].Value.ToString();
            email.Text = ugyfellista.CurrentRow.Cells["Email"].Value.ToString();
            megye.Text = ugyfellista.CurrentRow.Cells["Megye"].Value.ToString();
            Cim.Text = ugyfellista.CurrentRow.Cells["Cím"].Value.ToString();
            szerviznyitas.Enabled = true;
        }
    }
}
