/**
 * @file Cwiczenia.cs
 * @autor Wiktor Winiarz
 * @date June 12, 2019
 * @brief Formularz cwiczenia
 * 
 * Ten formularz dotyczy metod wyboru cwiczenia
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

        /// <summary> 
        /// Zamknięcie ćwiczenia
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary> 
        /// Szereguje w poziomie
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void uszeregujWPoziomieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary> 
        /// Szereguje w pionie
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void uszeregujWPionieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary> 
        /// Szereguje kaskadowo
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void uszeregujKaskadowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary> 
        /// Te zdarzenie przypisane jest do przycisku dodawanie
        /// Po naciśnieciu uruchamia ćwiczenie dodawanie
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void dodawanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodawanie dodawanie = new Dodawanie();
            dodawanie.MdiParent = this;
            dodawanie.Show();
        }

        /// <summary> 
        /// Te zdarzenie przypisane jest do przycisku odejmowanie
        /// Po naciśnieciu uruchamia ćwiczenie odejmowanie
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odejmowanie odejmowanie = new Odejmowanie();
            odejmowanie.MdiParent = this;
            odejmowanie.Show();
        }

        /// <summary> 
        /// Te zdarzenie przypisane jest do przycisku mnozenie
        /// Po naciśnieciu uruchamia ćwiczenie mnozenie
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void mnożenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mnozenie mnozenie = new Mnozenie();
            mnozenie.MdiParent = this;
            mnozenie.Show();
        }


        /// <summary> 
        /// Te zdarzenie przypisane jest do przycisku dzielenie
        /// Po naciśnieciu uruchamia ćwiczenie dzielenie
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void dzielenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dzielenie dzielenie = new Dzielenie();
            dzielenie.MdiParent = this;
            dzielenie.Show();
        }
    }
}
