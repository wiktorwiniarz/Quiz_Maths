/**
 * @file Dodawanie.cs
 * @autor Wiktor Winiarz
 * @date June 12, 2019
 * @brief It is the main form of project
 * 
 * This Form conatains methods
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
    public partial class Dodawanie : Form
    {
        public Dodawanie()
        {
            InitializeComponent();
        }

  
     
     Random randomizer = new Random();

     
     int addend1, addend2, addend3, addend4, addend5, addend6, addend7, addend8, addend9, addend10;

     int timeLabel;
   

        
        public void StartTheQuiz()
            {
               
                addend1 = randomizer.Next(51);
                addend2 = randomizer.Next(51);
                addend3 = randomizer.Next(51);
                addend4 = randomizer.Next(51);
                addend5 = randomizer.Next(51);
                addend6 = randomizer.Next(51);
                addend7 = randomizer.Next(51);
                addend8 = randomizer.Next(51);
                addend9 = randomizer.Next(51);
                addend10 = randomizer.Next(51);

            
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            plusLeftLabel1.Text = addend3.ToString();
            plusRightLabel1.Text = addend4.ToString();
            plusLeftLabel2.Text = addend5.ToString();
            plusRightLabel2.Text = addend6.ToString();
            plusLeftLabel3.Text = addend7.ToString();
            plusRightLabel3.Text = addend8.ToString();
            plusLeftLabel4.Text = addend9.ToString();
            plusRightLabel4.Text = addend10.ToString();


            
            sum.Value = 0;
            sum1.Value = 0;
            sum2.Value = 0;
            sum3.Value = 0;
            sum4.Value = 0;

            timeLabel = 0;
            time.Text = "0 sekund";
            timer1.Start();
        }
  
          
            
            private bool CheckTheAnswer()
            {
                if ((addend1 + addend2 == sum.Value)
                      && (addend3 + addend4 == sum1.Value)
                      && (addend5 + addend6 == sum2.Value)
                      && (addend7 + addend8 == sum3.Value)
                      && (addend9 + addend10 == sum4.Value))
               
            return true;
                else
                    return false;
            }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (CheckTheAnswer())
            {
               
                timer1.Stop();
                MessageBox.Show("Masz wszystkie poprawne odpowiedzi!",
                                "Gratulacje!");
                StartDodawanie.Enabled = true;
            }
            else if (timeLabel >= 0)
            {
                
                timeLabel++;
                time.Text = timeLabel + " seconds";
                
            }
           
      
        }

        private void answer_Enter(object sender, EventArgs e)
            {
                
                NumericUpDown answerBox = sender as NumericUpDown;

                if (answerBox != null)
                {
                    int lengthOfAnswer = answerBox.Value.ToString().Length;
                    answerBox.Select(0, lengthOfAnswer);
                }
            }

            private void CorrectPlay()
            {
                Stream soundfile = Properties.Resources.dobrze;
                SoundPlayer sound = new SoundPlayer(soundfile);
                sound.Play();
            }

            private void WrongPlay()
            {
                Stream soundfile = Properties.Resources.zle;
                SoundPlayer sound = new SoundPlayer(soundfile);
                sound.Play();
            }

            private void valueChanged(object sender, EventArgs e)
            {
            if (addend1 + addend2 == sum.Value)
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

        private void valueChanged1(object sender, EventArgs e)
        {
            if (addend3 + addend4 == sum1.Value)
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

        private void valueChanged2(object sender, EventArgs e)
        {
            if (addend5 + addend6 == sum2.Value)
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

        private void valueChanged3(object sender, EventArgs e)
        {
            if (addend7 + addend8 == sum3.Value)
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
        private void valueChanged4(object sender, EventArgs e)
        {
            if (addend9 + addend10 == sum4.Value)
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

        private void StartDodawanie_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            StartDodawanie.Enabled = false;
        }
    }
}

