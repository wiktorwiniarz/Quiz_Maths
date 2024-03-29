﻿/**
 * @file Odejmowanie.cs
 * @autor Wiktor Winiarz
 * @date June 12, 2019
 * @brief To jest klasa Odejmowanie
 * 
 * Zawiera metody odejmowania
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
    public partial class Odejmowanie : Form
    {
        public Odejmowanie()
        {
            InitializeComponent();
        }



        /* Tworzymy losowy obiekt o nazwie randomizer 
           do generowania liczb losowych.*/
        Random randomizer = new Random();

         //zmienne int
        int minuend, subtrahend, minuend1, subtrahend1, minuend2, subtrahend2, minuend3, subtrahend3, minuend4, subtrahend4;



        int timeLabel;

        /// <summary> 
        /// Rozpocznij quiz, wypełniając wszystkie problemy
        /// i uruchomienie zegara. 
        /// </summary>
        public void StartTheQuiz()
        {
          

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            roznica.Value = 0;

            minuend1 = randomizer.Next(1, 101);
            subtrahend1 = randomizer.Next(1, minuend1);
            minusLeftLabel1.Text = minuend1.ToString();
            minusRightLabel1.Text = subtrahend1.ToString();
            roznica1.Value = 0;

            minuend2 = randomizer.Next(1, 101);
            subtrahend2 = randomizer.Next(1, minuend2);
            minusLeftLabel2.Text = minuend2.ToString();
            minusRightLabel2.Text = subtrahend2.ToString();
            roznica2.Value = 0;

            minuend3 = randomizer.Next(1, 101);
            subtrahend3 = randomizer.Next(1, minuend3);
            minusLeftLabel3.Text = minuend3.ToString();
            minusRightLabel3.Text = subtrahend3.ToString();
            roznica3.Value = 0;

            minuend4 = randomizer.Next(1, 101);
            subtrahend4 = randomizer.Next(1, minuend4);
            minusLeftLabel4.Text = minuend4.ToString();
            minusRightLabel4.Text = subtrahend4.ToString();
            roznica4.Value = 0;

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
        private void StartOdejmowanie_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            StartOdejmowanie.Enabled = false;
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
                StartOdejmowanie.Enabled = true;
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
            if ((minuend - subtrahend == roznica.Value)
                  && (minuend1 - subtrahend1 == roznica1.Value)
                  && (minuend2 - subtrahend2 == roznica2.Value)
                  && (minuend3 - subtrahend3 == roznica3.Value)
                  && (minuend4 - subtrahend4 == roznica4.Value))

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
        /// Metoda sprawdzania poprawnosc wyniku 1 odejmowania 
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged(object sender, EventArgs e)
        {
            if (minuend - subtrahend == roznica.Value)
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
        /// Metoda sprawdzania poprawnosc wyniku 2 odejmowania 
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged1(object sender, EventArgs e)
        {
            if (minuend1 - subtrahend1 == roznica1.Value)
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
        /// Metoda sprawdzania poprawnosc wyniku 3 odejmowania 
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged2(object sender, EventArgs e)
        {
            if (minuend2 - subtrahend2 == roznica2.Value)
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
        /// Metoda sprawdzania poprawnosc wyniku 4 odejmowania 
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged3(object sender, EventArgs e)
        {
            if (minuend3 - subtrahend3 == roznica3.Value)
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
        /// Metoda sprawdzania poprawnosc wyniku 5 odejmowania 
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged4(object sender, EventArgs e)
        {
            if (minuend4 - subtrahend4 == roznica4.Value)
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

