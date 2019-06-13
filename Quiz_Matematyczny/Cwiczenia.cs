using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Matematyczny
{
    public partial class Cwiczenia : Form
    {
        public Cwiczenia()
        {
            InitializeComponent();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uszeregujWPoziomieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void uszeregujWPionieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void uszeregujKaskadowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void dodawanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodawanie dodawanie = new Dodawanie();
            dodawanie.MdiParent = this;
            dodawanie.Show();
        }

        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odejmowanie odejmowanie = new Odejmowanie();
            odejmowanie.MdiParent = this;
            odejmowanie.Show();
        }

        private void mnożenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mnozenie mnozenie = new Mnozenie();
            mnozenie.MdiParent = this;
            mnozenie.Show();
        }


        //Metoda dodająca w menuStrip przycik dzielenie
        private void dzielenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dzielenie dzielenie = new Dzielenie();
            dzielenie.MdiParent = this;
            dzielenie.Show();
        }
    }
}
