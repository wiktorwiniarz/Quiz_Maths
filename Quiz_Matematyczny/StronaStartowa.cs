/**
 * @file StronaStartowa.cs
 * @autor Wiktor Winiarz
 * @date June 12, 2019
 * @brief Jest ot glowny main projektu
 * 
 * Ten formularz dotyczy metod strony startowej
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
    public partial class StronaStartowa : Form
    {
        public StronaStartowa()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Przycisk zamknięcia aplikacji
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary> 
        /// Przycisk Zasady ma opis jak nalezy postepowac podczas uruchomienia aplikacji
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do wyboru są dwie opcje: ćwiczenia, dzięki którym możemy podszkolić swoje umiejętnosci obliczania\n" +
                            "oraz test sprawdzający, który pomaga nam w ćwiczeniu refleksu w obliczaniu.\n" +
                            "W Teście proszę nacisnąć przycisk 'start' i uzupełnić pola liczbami.\n" +
                            "Kiedy odpowiedz będzie prawidłowa usłyszysz odpowiedni dźwięk i wyświetli się poprawność wyniku.\n"+
                            "Proszę uważać test jest na czas.\n");
        }

        /// <summary> 
        /// Przycisk Autor ukazuje nam autora aplkacji
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Wiktor Winiarz \nNumer albumu: 58998 \nAplikcja do nauki");
        }

       
        private void StronaStartowa_Load(object sender, EventArgs e)
        {

        }

        /// <summary> 
        /// Uruchamia test quizu
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
        }
        
        /// <summary> 
        /// Uruchamia cwiczenia quizu
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Cwiczenia cwiczenia = new Cwiczenia();
            cwiczenia.Show();
        }
    }
}
