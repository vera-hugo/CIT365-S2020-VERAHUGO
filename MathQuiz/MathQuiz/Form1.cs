using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {


        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;


        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

           
            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'minued' and 'substrahend'
            minuend = randomizer.Next(1, 100);
            subtrahend = randomizer.Next(1, minuend);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();

            // 'difference' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            difference.Value = 0;

            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'multiplicand' and 'multiplier'
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();

            // 'product' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            product.Value = 0;

            /// Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'diviso' and 'dividend'
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();

            // 'quotient' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it
            quotient.Value = 0;

            // Start the timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        
        }


        public Form1()
        {
            InitializeComponent();
        }               

        private void startButton_Click_1(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            currentTime.Text = DateTime.Now.ToString("d MMMM yyyy");

            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }

            if (timeLeft == 6)
            {
                timeLabel.BackColor = Color.Red;
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";

                
            }

             /*if (timeLeft == 1){
                timeLabel.BackColor = Color.Transparent;
                //timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";

            }*/

            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() return false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show 
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.BackColor = Color.Transparent;
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                &&(minuend-subtrahend == difference.Value)
                &&(multiplicand*multiplier == product.Value)
                &&(dividend/divisor == quotient.Value))
                return true;
            else
                return false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void timesLeftLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
