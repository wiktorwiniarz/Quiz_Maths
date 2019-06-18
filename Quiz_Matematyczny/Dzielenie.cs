/**
 * @file Dzielenie.cs
 * @autor Wiktor Winiarz
 * @date June 12, 2019
 * @brief To jest klasa Dzielenie
 * 
 * Zawiera metody dzielenia
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
using System.IO;
using System.Media;

namespace Quiz_Matematyczny
{
    public partial class Dzielenie : Form
    {
        public Dzielenie()
        {
            InitializeComponent();
        }


        /* Tworzymy losowy obiekt o nazwie randomizer 
           do generowania liczb losowych.*/
        Random randomizer = new Random();

        //zmienne
        int dividend, divisor, dividend1, divisor1, dividend2, divisor2, dividend3, divisor3, dividend4, divisor4;

        //zmienna czasu
        int timeLabel;

        /// <summary> 
        /// Rozpocznij quiz, wypełniając wszystkie problemy
        /// i uruchomienie zegara. 
        /// </summary>
        public void StartTheQuiz()
        {
            
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            iloraz.Value = 0;

            
            divisor1 = randomizer.Next(2, 11);
            int temporaryQuotient1 = randomizer.Next(2, 11);
            dividend1 = divisor1 * temporaryQuotient1;
            dividedLeftLabel1.Text = dividend1.ToString();
            dividedRightLabel1.Text = divisor1.ToString();
            iloraz1.Value = 0;
            
            divisor2 = randomizer.Next(2, 11);
            int temporaryQuotient2 = randomizer.Next(2, 11);
            dividend2 = divisor2 * temporaryQuotient2;
            dividedLeftLabel2.Text = dividend2.ToString();
            dividedRightLabel2.Text = divisor2.ToString();
            iloraz2.Value = 0;

            
            divisor3 = randomizer.Next(2, 11);
            int temporaryQuotient3 = randomizer.Next(2, 11);
            dividend3 = divisor3 * temporaryQuotient3;
            dividedLeftLabel3.Text = dividend3.ToString();
            dividedRightLabel3.Text = divisor3.ToString();
            iloraz3.Value = 0;

           
            divisor4 = randomizer.Next(2, 11);
            int temporaryQuotient4 = randomizer.Next(2, 11);
            dividend4 = divisor4 * temporaryQuotient4;
            dividedLeftLabel4.Text = dividend4.ToString();
            dividedRightLabel4.Text = divisor4.ToString();
            iloraz4.Value = 0;

            timeLabel = 0;
            time.Text = "0 sekund";
            timer1.Start();
        }

        /// <summary> 
        /// Wywołaje metodę StartTheQuiz() i włącza
        /// przycisk START oraz ustawia pictureBox obraz na null. 
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void StartDzielenie_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            StartDzielenie.Enabled = false;
        }

        /// <summary> 
        /// Czas quizu
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                
                timer1.Stop();
                MessageBox.Show("Masz wszystkie poprawne odpowiedzi!",
                                "Gratulacje!");
                StartDzielenie.Enabled = true;
            }
            else if (timeLabel >= 0)
            {
                
                timeLabel++;
                time.Text = timeLabel + " sekund";

            }
        }

        /// <summary> 
        ///  Sprawdź odpowiedź, aby sprawdzić, czy użytkownik ma wszystko dobrze. 
        /// </summary> 
        /// <returns>Prawda, jeśli odpowiedź jest poprawna, w przeciwnym razie fałsz.</returns>
        private bool CheckTheAnswer()
        {
            if ((dividend / divisor == iloraz.Value)
                  && (dividend1 / divisor1 == iloraz1.Value)
                  && (dividend2 / divisor2 == iloraz2.Value)
                  && (dividend3 / divisor3 == iloraz3.Value)
                  && (dividend4 / divisor4 == iloraz4.Value))

                return true;
            else
                return false;
        }

        /// <summary> 
        /// Zmodyfikuj zachowanie kontrolki NumericUpDown,
        /// aby ułatwić wprowadzanie wartości liczbowych w quizie
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void answer_Enter(object sender, EventArgs e)
        {
            
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        /**Metoda dźwięku podczas poprawnej odpowiedzi*/
        private void CorrectPlay()
        {
            Stream soundfile = Properties.Resources.dobrze;
            SoundPlayer sound = new SoundPlayer(soundfile);
            sound.Play();
        }

        /**Metoda dźwięku podczas złej odpowiedzi*/
        private void WrongPlay()
        {
            Stream soundfile = Properties.Resources.zle;
            SoundPlayer sound = new SoundPlayer(soundfile);
            sound.Play();
        }

        /// <summary> 
        /// Metoda sprawdzania poprawnosc wyniku 1 dzielenia
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged(object sender, EventArgs e)
        {
            if (dividend / divisor == iloraz.Value)
            {
                CorrectPlay();
                pictureBox1.Image = Quiz_Matematyczny.Properties.Resources.dobrze1;
            }
            else
            {
                WrongPlay();
                pictureBox1.Image = Quiz_Matematyczny.Properties.Resources.zle1;
            }
        }

        /// <summary> 
        /// Metoda sprawdzania poprawnosc wyniku 2 dzielenia
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged1(object sender, EventArgs e)
        {
            if (dividend1 / divisor1 == iloraz1.Value)
            {
                CorrectPlay();
                pictureBox2.Image = Quiz_Matematyczny.Properties.Resources.dobrze1;
            }
            else
            {
                WrongPlay();
                pictureBox2.Image = Quiz_Matematyczny.Properties.Resources.zle1;
            }
        }

        /// <summary> 
        /// Metoda sprawdzania poprawnosc wyniku 3 dzielenia
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged2(object sender, EventArgs e)
        {
            if (dividend2 / divisor2 == iloraz2.Value)
            {
                CorrectPlay();
                pictureBox3.Image = Quiz_Matematyczny.Properties.Resources.dobrze1;
            }
            else
            {
                WrongPlay();
                pictureBox3.Image = Quiz_Matematyczny.Properties.Resources.zle1;
            }
        }

        /// <summary> 
        /// Metoda sprawdzania poprawnosc wyniku 4 dzielenia
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged3(object sender, EventArgs e)
        {
            if (dividend3 / divisor3 == iloraz3.Value)
            {
                CorrectPlay();
                pictureBox4.Image = Quiz_Matematyczny.Properties.Resources.dobrze1;
            }
            else
            {
                WrongPlay();
                pictureBox4.Image = Quiz_Matematyczny.Properties.Resources.zle1;
            }
        }

        /// <summary> 
        /// Metoda sprawdzania poprawnosc wyniku 5 dzielenia
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged4(object sender, EventArgs e)
        {
            if (dividend4 / divisor4 == iloraz4.Value)
            {
                CorrectPlay();
                pictureBox5.Image = Quiz_Matematyczny.Properties.Resources.dobrze1;
            }
            else
            {
                WrongPlay();
                pictureBox5.Image = Quiz_Matematyczny.Properties.Resources.zle1;
            }
        }


    }
}

