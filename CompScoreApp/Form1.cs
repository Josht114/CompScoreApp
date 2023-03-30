using System;
using static System.Net.Mime.MediaTypeNames;

namespace CompScoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seconds = 600;
        int tickerCount = 1;
        bool timerRunning = false;
        int redScoreTotal = 0;
        int blueScoreTotal = 0;






        private void startStop_Click(object sender, EventArgs e)
        {

            if (timerRunning)
            {
                timer1.Stop();
                timerRunning = false;
            }
            else
            {
                timer1.Start();
                timerRunning = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            string text = time.ToString(@"mm\:ss");

            timeLabel.Text = text;
            seconds = seconds - 1;



            ticker.Text = tickerCount++.ToString();
            secondslabel.Text = seconds.ToString();


            if (seconds < 0)
            {
                timer1.Stop();
            }
        }



        private void redOnePoint_Click(object sender, EventArgs e)
        {
            redScoreTotal++;
            redScore.Text = redScoreTotal.ToString();
        }

        private void redTwoPoint_Click(object sender, EventArgs e)
        {
            redScoreTotal = redScoreTotal + 2;
            redScore.Text = redScoreTotal.ToString();
        }

        private void redThreePoint_Click(object sender, EventArgs e)
        {
            redScoreTotal = redScoreTotal + 3;
            redScore.Text = redScoreTotal.ToString();
        }

        private void redFourPoint_Click(object sender, EventArgs e)
        {
            redScoreTotal = redScoreTotal + 4;
            redScore.Text = redScoreTotal.ToString();
        }

        private void redFivePoint_Click(object sender, EventArgs e)
        {
            redScoreTotal = redScoreTotal + 5;
            redScore.Text = redScoreTotal.ToString();
        }

        private void redSixPoint_Click(object sender, EventArgs e)
        {
            redScoreTotal = redScoreTotal + 6;
            redScore.Text = redScoreTotal.ToString();
        }

        private void blueOnePoint_Click(object sender, EventArgs e)
        {
            blueScoreTotal++;
            blueScore.Text = blueScoreTotal.ToString();
        }

        private void blueTwoPoint_Click(object sender, EventArgs e)
        {
            blueScoreTotal = blueScoreTotal + 2;
            blueScore.Text = blueScoreTotal.ToString();
        }

        private void blueThreePoint_Click(object sender, EventArgs e)
        {
            blueScoreTotal = blueScoreTotal + 3;
            blueScore.Text = blueScoreTotal.ToString();
        }

        private void blueFourPoint_Click(object sender, EventArgs e)
        {
            blueScoreTotal = blueScoreTotal + 4;
            blueScore.Text = blueScoreTotal.ToString();
        }

        private void blueFivePoint_Click(object sender, EventArgs e)
        {
            blueScoreTotal = blueScoreTotal + 5;
            blueScore.Text = blueScoreTotal.ToString();
        }

        private void blueSixPoint_Click(object sender, EventArgs e)
        {
            blueScoreTotal = blueScoreTotal + 6;
            blueScore.Text = blueScoreTotal.ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerRunning = false;
            redScoreTotal = 0;
            redScore.Text = redScoreTotal.ToString();
            blueScoreTotal = 0;
            blueScore.Text = blueScoreTotal.ToString();
            seconds = 600;
            timeLabel.Text = "10:00";

        }
    }
}