using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Matematyczny
{
    public partial class Test : Form
    {
        //  Tworzymy losowy obiekt o nazwie randomizer
        // do generowania liczb losowych.
        Random randomizer = new Random();

        // Te zmienne całkowite przechowują liczby
        // dla problemu dodawania. 
        int addend1;
        int addend2;

        // Te zmienne całkowite przechowują liczby
        // dla problemu odejmowania.
        int minuend;
        int subtrahend;

        // Te zmienne całkowite przechowują liczby
        // dla problemu mnożenia. 
        int multiplicand;
        int multiplier;

        // Te zmienne całkowite przechowują liczby
        // dla problemu dzielenia. 
        int dividend;
        int divisor;

        // Ta zmienna całkowita śledzi
        // pozostały czas.
        int timeLeft;

        /// <summary>
        /// Rozpocznij quiz, wypełniając wszystkie problemy
        /// i uruchomienie zegara.
        /// </summary>
        public void StartTheQuiz()
        {
            // Wypełnij problem dodawania.
            // Generowanie dwóch liczb losowych do dodania.
            // Przechowuj wartości w zmiennych „addend1” i „addend2”.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Konwertuje dwie losowo wygenerowane liczby
            // w łańcuchy, aby mogły być wyświetlane
            // w kontrolce etykiety.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();


            // „suma” to nazwa kontrolki NumericUpDown.
            // Ten krok zapewnia, że ​​jego wartość wynosi zero
            // dodając do niego dowolne wartości.
            sum.Value = 0;

            // Wypełnia problem odejmowania.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            roznica.Value = 0;

            // Wypełnia problem mnożenia.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            iloczyn.Value = 0;

            // Wypełnia problem dzielenia.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            iloraz.Value = 0;

            // Start zegaru.
            timeLeft = 30;
            timeLabel.Text = "30 sekund";
            timeLabel.BackColor = Color.White;
            timer1.Start();
        }
        public Test()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // Jeśli CheckTheAnswer () zwraca true, to użytkownik
                // dostał właściwą odpowiedź. Zatrzymaj stoper
                // i pokaż MessageBox.
                timer1.Stop();
                MessageBox.Show("Masz wszystkie poprawne odpowiedzi!",
                                "Gratulacje!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                
                // Jeśli CheckTheAnswer () zwraca false, kontynuuj liczenie
                // na dół. Zmniejsz czas pozostały o jedną sekundę i
                // wyświetl nowy czas po aktualizacji
                // Etykieta Time Left.
                timeLeft--;
                timeLabel.Text = timeLeft + " sekund";
                if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                // Jeśli zabrakło czasu, zatrzymaj timer, pokaż
                // a MessageBox i wypełnij odpowiedzi.
                timer1.Stop();
                timeLabel.Text ="Koniec czasu!";
                MessageBox.Show("Nie skończyłeś na czas.\n"+
                                "Przepraszam");
                sum.Value = addend1 + addend2;
                roznica.Value = minuend - subtrahend;
                iloczyn.Value = multiplicand * multiplier;
                iloraz.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }
        /// <summary>
        /// Sprawdź odpowiedź, aby sprawdzić, czy użytkownik ma wszystko dobrze.
        /// </summary>
        /// <returns>Prawda, jeśli odpowiedź jest poprawna, w przeciwnym razie fałsz.</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                  && (minuend - subtrahend == roznica.Value)
                  && (multiplicand * multiplier == iloczyn.Value)
                  && (dividend / divisor == iloraz.Value))
                return true;
            else
                return false;
        }
        private void answer_Enter(object sender, EventArgs e)
        {
            // Wybierz całą odpowiedź w kontrolce NumericUpDown.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }


        //Metoda dźwięku podczas poprawnej odpowiedzi
        private void CorrectPlay()
        {
            Stream soundfile = Properties.Resources.dobrze;
            SoundPlayer sound = new SoundPlayer(soundfile);
            sound.Play();
        }

        //Metoda dźwięku podczas złej odpowiedzi
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
            }
            else
                WrongPlay();
        }

        private void valueChanged1(object sender, EventArgs e)
        {
            if (minuend - subtrahend == roznica.Value)
            {
                CorrectPlay();
            }
            else
                WrongPlay();
        }

        private void valueChanged2(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == iloczyn.Value)
            {
                CorrectPlay();
            }
            else
                WrongPlay();
        }

        private void valueChanged3(object sender, EventArgs e)
        {
            if (dividend / divisor == iloraz.Value)
            {
                CorrectPlay();
            }
            else
                WrongPlay();
        }
    }
}
