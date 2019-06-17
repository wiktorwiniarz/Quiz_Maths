/**
 * @file Ćwiczenia.cs
 * @autor Wiktor Winiarz
 * @date June 12, 2019
 * @brief It is the selectio of exercices form of project
 * 
 * This Form contains methods
 */



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

        /**Zamknięcie ćwiczenia*/
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /**Szereguje w poziomie*/
        private void uszeregujWPoziomieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        /**Szereguje w pionie*/
        private void uszeregujWPionieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        /**Szereguje kaskadowo*/
        private void uszeregujKaskadowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        /**Ten ivent jest przypisany do przycisku dodaj, Po naciśnieciu uruchamia ćwiczenie dodawanie*/
        private void dodawanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodawanie dodawanie = new Dodawanie();
            dodawanie.MdiParent = this;
            dodawanie.Show();
        }

        /**Ten ivent jest przypisany do przycisku odejmowanie, Po naciśnieciu uruchamia ćwiczenie odejmowanie*/
        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odejmowanie odejmowanie = new Odejmowanie();
            odejmowanie.MdiParent = this;
            odejmowanie.Show();
        }

        /**Ten ivent jest przypisany do przycisku mnożenie, Po naciśnieciu uruchamia ćwiczenie mnożenie*/
        private void mnożenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mnozenie mnozenie = new Mnozenie();
            mnozenie.MdiParent = this;
            mnozenie.Show();
        }


        /**Ten ivent jest przypisany do przycisku dzielenie, Po naciśnieciu uruchamia ćwiczenie dzielenie*/
        private void dzielenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dzielenie dzielenie = new Dzielenie();
            dzielenie.MdiParent = this;
            dzielenie.Show();
        }
    }
}
