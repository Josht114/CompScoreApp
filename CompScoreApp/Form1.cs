using System;

namespace CompScoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seconds = 100;
        int tickerCount = 1;
        bool timerRunning = false;





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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}