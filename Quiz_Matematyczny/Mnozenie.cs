﻿/**
 * @file Mnozenie.cs
 * @autor Wiktor Winiarz
 * @date June 12, 2019
 * @brief To jest klasa Mnozenie
 * 
 * Zawiera metody mnozenia
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
    public partial class Mnozenie : Form
    {
        public Mnozenie()
        {
            InitializeComponent();
        }


         /* Tworzymy losowy obiekt o nazwie randomizer 
            do generowania liczb losowych.*/
        Random randomizer = new Random();
 
        //zmienne
        int multiplicand, multiplier, multiplicand1, multiplier1, multiplicand2, multiplier2, multiplicand3, multiplier3, multiplicand4, multiplier4;
        
        //zmienna dla czasu
        int timeLabel;


        /// <summary> 
        /// Rozpocznij quiz, wypełniając wszystkie problemy
        /// i uruchomienie zegara. 
        /// </summary>
        public void StartTheQuiz()
        {
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            iloczyn.Value = 0;

            multiplicand1 = randomizer.Next(2, 11);
            multiplier1 = randomizer.Next(2, 11);
            timesLeftLabel1.Text = multiplicand1.ToString();
            timesRightLabel1.Text = multiplier1.ToString();
            iloczyn1.Value = 0;

            multiplicand2 = randomizer.Next(2, 11);
            multiplier2 = randomizer.Next(2, 11);
            timesLeftLabel2.Text = multiplicand2.ToString();
            timesRightLabel2.Text = multiplier2.ToString();
            iloczyn2.Value = 0;

            multiplicand3 = randomizer.Next(2, 11);
            multiplier3 = randomizer.Next(2, 11);
            timesLeftLabel3.Text = multiplicand3.ToString();
            timesRightLabel3.Text = multiplier3.ToString();
            iloczyn3.Value = 0;

            multiplicand4 = randomizer.Next(2, 11);
            multiplier4 = randomizer.Next(2, 11);
            timesLeftLabel4.Text = multiplicand4.ToString();
            timesRightLabel4.Text = multiplier4.ToString();
            iloczyn4.Value = 0;

            timeLabel = 0;
            time.Text = "0 sekund";
            timer1.Start();
        }

        /// <summary> 
        ///  Sprawdź odpowiedź, aby sprawdzić, czy użytkownik ma wszystko dobrze. 
        /// </summary> 
        /// <returns>Prawda, jeśli odpowiedź jest poprawna, w przeciwnym razie fałsz.</returns>
        private bool CheckTheAnswer()
        {
            if ((multiplicand * multiplier == iloczyn.Value)
                  && (multiplicand1 * multiplier1 == iloczyn1.Value)
                  && (multiplicand2 * multiplier2 == iloczyn2.Value)
                  && (multiplicand3 * multiplier3 == iloczyn3.Value)
                  && (multiplicand4 * multiplier4 == iloczyn4.Value))

                return true;
            else
                return false;
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
                StartMnozenie.Enabled = true;
            }
            else if (timeLabel >= 0)
            {
                
                timeLabel++;
                time.Text = timeLabel + " sekund";

            }
        }

        /// <summary> 
        /// Wywołaje metodę StartTheQuiz() i włącza
        /// przycisk START oraz ustawia pictureBox obraz na null. 
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void StartMnozenie_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            StartMnozenie.Enabled = false;
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
        /// Metoda sprawdzania poprawnosc wyniku 1 mnożenia 
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == iloczyn.Value)
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
        /// Metoda sprawdzania poprawnosc wyniku 2 mnożenia 
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged1(object sender, EventArgs e)
        {
            if (multiplicand1 * multiplier1 == iloczyn1.Value)
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
        /// Metoda sprawdzania poprawnosc wyniku 3 mnożenia 
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged2(object sender, EventArgs e)
        {
            if (multiplicand2 * multiplier2 == iloczyn2.Value)
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
        /// Metoda sprawdzania poprawnosc wyniku 4 mnożenia 
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged3(object sender, EventArgs e)
        {
            if (multiplicand3 * multiplier3 == iloczyn3.Value)
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
        /// Metoda sprawdzania poprawnosc wyniku 5 mnożenia 
        /// dla zasygnalizowania dźwiękiem i obrazkiem
        /// </summary> 
        /// <param name="sender"></param>
        ///  <param name="e"></param>
        private void valueChanged4(object sender, EventArgs e)
        {
            if (multiplicand4 * multiplier4 == iloczyn4.Value)
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

