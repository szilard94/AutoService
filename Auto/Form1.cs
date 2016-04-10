﻿using System;
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
            frissit();
            szervizkereso(null, null);
        }

        private void keresogomb_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void muszaki_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void beallitasok_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible =true;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }
        private void ujszerviz_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void szerviztortenet_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
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
                kmora.Enabled = true;
                ConnectToDB lekeres = new ConnectToDB();
                DataSet datas = lekeres.selectFrom("SELECT rendszam, marka, tipus, evjarat, nev, fax, telefon, mobil, megye, cim, email FROM Jarmuvek JOIN Ugyfelek ON Jarmuvek.UID = Ugyfelek.UID WHERE alvazszam = '" + ujalvaz.Text.ToString() + "'");
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
                kmora.Enabled = false;
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
                DataSet datas = lekeres.selectFrom("SELECT rendszam, marka, tipus, evjarat, nev, fax, telefon, mobil, megye, cim, email FROM Jarmuvek JOIN Ugyfelek ON Jarmuvek.UID = Ugyfelek.UID WHERE alvazszam = '" + alvazmuszaki.Text.ToString() + "'");
                ConnectToDB muszaklekeres = new ConnectToDB();
                DataSet timedate = muszaklekeres.selectFrom("SELECT TOP 1 datum,lejarat FROM Muszaki WHERE AID =(SELECT AID FROM Jarmuvek WHERE alvazszam='" + alvazmuszaki.Text.ToString() + "') ORDER BY datum DESC");
                if (datas.Tables[0].Rows.Count != 0)
                {
                    muszakirendszam.Text = datas.Tables[0].Rows[0]["rendszam"].ToString();
                    muszakimarka.Text = datas.Tables[0].Rows[0]["marka"].ToString();
                    muszakitipus.Text = datas.Tables[0].Rows[0]["tipus"].ToString();
                    muszakievjarat.Text = datas.Tables[0].Rows[0]["evjarat"].ToString();
                    muszakiaktualizalas.Enabled = true;
                }
                else
                {
                    muszakiztatasideje.Value = DateTime.Today;
                    muszakilejarata.Value = DateTime.Today;
                    muszakirendszam.Text = "";
                    muszakimarka.Text = "";
                    muszakitipus.Text = "";
                    muszakievjarat.Text = "";
                }
                if (timedate.Tables[0].Rows.Count != 0)
                {
                    muszakiztatasideje.Value = Convert.ToDateTime(timedate.Tables[0].Rows[0]["datum"].ToString());
                    muszakilejarata.Value = Convert.ToDateTime(timedate.Tables[0].Rows[0]["lejarat"].ToString());
                }
            }
            else
            {
                muszakiztatasideje.Value = DateTime.Today;
                muszakilejarata.Value = DateTime.Today;
                muszakirendszam.Text = "";
                muszakimarka.Text = "";
                muszakitipus.Text = "";
                muszakievjarat.Text = "";
                muszakiaktualizalas.Enabled = false;
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
                ugyfellista.DataSource = lekeres.selectFrom("SELECT UID, nev AS Név, ceg AS Cég, fax AS Fax, telefon AS Telefon, mobil AS Mobil, email AS Email, megye AS Megye, cim AS Cím FROM Ugyfelek WHERE nev LIKE '%" + tulajnev.Text + "%'").Tables[0];
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

        private void szerviznyitas_Click(object sender, EventArgs e)
        {
            if(tulajnev.Enabled == false)
            {
                ConnectToDB kapcsolat = new ConnectToDB();
                string AID = kapcsolat.selectFrom("AID", "Jarmuvek", "alvazszam = '" + ujalvaz.Text.ToString() + "'").Tables[0].Rows[0]["AID"].ToString();
                kapcsolat.insertInto("Szerviz","AID, datum, kmOra", AID + ",GETDATE()," + kmora.Text.ToString());

                MessageBox.Show("Sikeres hozzáadás, később szerkeztheted.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ujalvaz.Text = "";
            }
            else
            {
                if(checkBox3.Checked == false)
                {
                    ConnectToDB kapcsolat = new ConnectToDB();
                    kapcsolat.insertInto("Jarmuvek", "UID, rendszam, alvazszam, marka, tipus, evjarat", ugyfellista.CurrentRow.Cells["UID"].Value.ToString() + ",'"
                                    + rendszam.Text.ToString() + "','" + ujalvaz.Text.ToString() + "','" + marka.Text.ToString() + "','"
                                    + tipus.Text.ToString() + "'," + evjarat.Text.ToString());
                    string AID = kapcsolat.selectFrom("AID", "Jarmuvek", "alvazszam = '" + ujalvaz.Text.ToString() + "'").Tables[0].Rows[0]["AID"].ToString();
                    kapcsolat.insertInto("Szerviz", "AID, datum, kmOra", AID + ",GETDATE()," + kmora.Text.ToString());
                    MessageBox.Show("Sikeres hozzáadás, később szerkeztheted. (Új autó mentése sikeres!)", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ujalvaz.Text = "";
                }
            }
        }

        private void szervizkereso(object sender, EventArgs e)
        {
            ConnectToDB lekeres = new ConnectToDB();
            string miszerint = "alvazszam";
            textBox5.MaxLength = 17;
            if (szervizrendszam.Checked)
            {
                miszerint = "rendszam";
                textBox5.MaxLength = 9;
            }
            if (checkBox4.Checked)
            {
                dataGridView2.DataSource = lekeres.selectFrom("SZID, rendszam AS Rendszám, marka AS Márka, tipus AS Típus, alvazszam AS Alvázszám, evjarat AS Évjárat, datum AS Szervizelés", "Szerviz", "Jarmuvek ON Jarmuvek.AID = Szerviz.AID", miszerint + " LIKE '%" + textBox5.Text.ToString() + "%' ORDER BY datum DESC").Tables[0];
            }
            else
            {
                dataGridView2.DataSource = lekeres.selectFrom("SZID, rendszam AS Rendszám, marka AS Márka, tipus AS Típus, alvazszam AS Alvázszám, evjarat AS Évjárat, datum AS Szervizelés", "Szerviz", "Jarmuvek ON Jarmuvek.AID = Szerviz.AID", miszerint + " LIKE '%" + textBox5.Text.ToString() + "%' AND lezarva = 0 ORDER BY datum DESC").Tables[0];
            }
        }

        private void kivalasztas(object sender, EventArgs e)
        {
            ConnectToDB kapcsolat = new ConnectToDB();
            if (kapcsolat.selectFrom("lezarva", "Szerviz", "SZID = '" + dataGridView2.CurrentRow.Cells["SZID"].Value.ToString() + "'").Tables[0].Rows[0][0].ToString() == "False")
            {
                hozzaad.Enabled = true;
            }
            else
            {
                hozzaad.Enabled = false;
            }
            label27.Text = dataGridView2.CurrentRow.Cells["Rendszám"].Value.ToString() + " - " + dataGridView2.CurrentRow.Cells["Alvázszám"].Value.ToString();
            DataSet adatok = kapcsolat.selectFrom("munkalatNeve, munkaAr", "Munkalatok", "SZID = '" + dataGridView2.CurrentRow.Cells["SZID"].Value.ToString() + "'");
            listBox1.Items.Clear();
            for (int i = 0; i < adatok.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(adatok.Tables[0].Rows[i]["munkalatNeve"].ToString() + " - " + adatok.Tables[0].Rows[i]["munkaAr"].ToString() + " Ft");
            }
        }

        private void muszakiaktualizalas_Click(object sender, EventArgs e)
        {
            ConnectToDB muszaki = new ConnectToDB();
            muszaki.insertInto("Muszaki", "AID,datum,lejarat", "'" + muszaki.selectFrom("SELECT AID  FROM Jarmuvek WHERE alvazszam ='" + alvazmuszaki.Text.ToString() + "'").Tables[0].Rows[0]["AID"].ToString() + "','" + muszakiztatasideje.Value.ToString("yyyy-MM-dd") + "','" + muszakilejarata.Value.ToString("yyyy-MM-dd") + "'");
            frissit();
        }

        private void frissit ()
        {
            ConnectToDB kapcsolat = new ConnectToDB();
            dataGridView1.DataSource = kapcsolat.selectFrom("SELECT Lejárat, nev AS Tulajnév, telefon AS Telefon, mobil AS Mobil, Rendszám, Alvázszám, Márka, Típus, Évjárat FROM (SELECT Jarmuvek.AID, rendszam AS Rendszám, alvazszam AS Alvázszám, marka AS Márka, tipus AS Típus, evjarat AS Évjárat, lejarat AS Lejárat, UID FROM (SELECT AID, MAX(lejarat) AS lejarat FROM Muszaki GROUP BY AID) temp JOIN Jarmuvek ON temp.AID = Jarmuvek.AID) temp2 JOIN Ugyfelek ON temp2.UID = Ugyfelek.UID").Tables[0];
        }

        private void muszakivalaszt(object sender, DataGridViewCellEventArgs e)
        {
            alvazmuszaki.Text = dataGridView1.CurrentRow.Cells["Alvázszám"].Value.ToString();
        }
    }
}
