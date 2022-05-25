using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDnevnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm_Osoba = new Form3();
            frm_Osoba.Show();
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            string user = Program.user_ime + " " + Program.user_prezime;
        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm_sifarnik = new Form5("smer");
            frm_sifarnik.Show();
        }

        private void skolskeGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm_sifarnik = new Form5("skolska_godina");
            frm_sifarnik.Show();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm_sifarnik = new Form5("predmet");
            frm_sifarnik.Show();
        }

        private void osobeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 frm_sifarnik = new Form5("osoba");
            frm_sifarnik.Show();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm_raspodela = new Form4();
            frm_raspodela.Show();
        }
    }
}
