namespace CompScoreApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            startStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ticker = new Label();
            secondslabel = new Label();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(347, 61);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(40, 20);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "xx:xx";
            // 
            // startStop
            // 
            startStop.Location = new Point(338, 111);
            startStop.Name = "startStop";
            startStop.Size = new Size(94, 29);
            startStop.TabIndex = 1;
            startStop.Text = "Start / Stop";
            startStop.UseVisualStyleBackColor = true;
            startStop.Click += startStop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ticker
            // 
            ticker.AutoSize = true;
            ticker.Location = new Point(616, 41);
            ticker.Name = "ticker";
            ticker.Size = new Size(17, 20);
            ticker.TabIndex = 2;
            ticker.Text = "0";
            // 
            // secondslabel
            // 
            secondslabel.AutoSize = true;
            secondslabel.Location = new Point(653, 125);
            secondslabel.Name = "secondslabel";
            secondslabel.Size = new Size(50, 20);
            secondslabel.TabIndex = 3;
            secondslabel.Text = "label1";
            secondslabel.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(secondslabel);
            Controls.Add(ticker);
            Controls.Add(startStop);
            Controls.Add(timeLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Button startStop;
        private System.Windows.Forms.Timer timer1;
        private Label ticker;
        private Label secondslabel;
    }
}