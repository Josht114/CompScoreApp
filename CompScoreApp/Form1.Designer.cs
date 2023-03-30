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
            timeLabel.Font = new Font("Calibri", 120F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(723, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(808, 234);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "xx:xx";
            timeLabel.Click += timeLabel_Click;
            // 
            // startStop
            // 
            startStop.Font = new Font("Calibri", 72F, FontStyle.Bold, GraphicsUnit.Point);
            startStop.Location = new Point(633, 261);
            startStop.Name = "startStop";
            startStop.Size = new Size(663, 155);
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
            ticker.Location = new Point(1589, 9);
            ticker.Name = "ticker";
            ticker.Size = new Size(17, 20);
            ticker.TabIndex = 2;
            ticker.Text = "0";
            // 
            // secondslabel
            // 
            secondslabel.AutoSize = true;
            secondslabel.Location = new Point(1589, 52);
            secondslabel.Name = "secondslabel";
            secondslabel.Size = new Size(17, 20);
            secondslabel.TabIndex = 3;
            secondslabel.Text = "0";
            secondslabel.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 588);
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