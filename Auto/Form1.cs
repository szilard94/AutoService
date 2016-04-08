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
                }
                else
                {
                    ujszervizInit();
                }
            }
        }
    }
}
