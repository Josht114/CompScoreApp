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
            redScore = new Label();
            blueScore = new Label();
            redOnePoint = new Button();
            redTwoPoint = new Button();
            redThreePoint = new Button();
            redFourPoint = new Button();
            redFivePoint = new Button();
            redSixPoint = new Button();
            blueSixPoint = new Button();
            blueFivePoint = new Button();
            blueFourPoint = new Button();
            blueThreePoint = new Button();
            blueTwoPoint = new Button();
            blueOnePoint = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            resetButton = new Button();
            redNegative = new Button();
            blueNegative = new Button();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.Font = new Font("Calibri", 120F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(650, -31);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(578, 213);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startStop
            // 
            startStop.Font = new Font("Calibri", 72F, FontStyle.Bold, GraphicsUnit.Point);
            startStop.Location = new Point(606, 185);
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
            secondslabel.Location = new Point(1644, 9);
            secondslabel.Name = "secondslabel";
            secondslabel.Size = new Size(17, 20);
            secondslabel.TabIndex = 3;
            secondslabel.Text = "0";
            // 
            // redScore
            // 
            redScore.Font = new Font("Calibri", 120F, FontStyle.Bold, GraphicsUnit.Point);
            redScore.Location = new Point(29, 9);
            redScore.Name = "redScore";
            redScore.Size = new Size(571, 228);
            redScore.TabIndex = 4;
            redScore.Text = "0";
            // 
            // blueScore
            // 
            blueScore.Font = new Font("Calibri", 120F, FontStyle.Bold, GraphicsUnit.Point);
            blueScore.Location = new Point(1452, 9);
            blueScore.Name = "blueScore";
            blueScore.Size = new Size(482, 234);
            blueScore.TabIndex = 5;
            blueScore.Text = "0";
            // 
            // redOnePoint
            // 
            redOnePoint.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            redOnePoint.Location = new Point(44, 366);
            redOnePoint.Name = "redOnePoint";
            redOnePoint.Size = new Size(646, 89);
            redOnePoint.TabIndex = 6;
            redOnePoint.Text = "Re-guard";
            redOnePoint.UseVisualStyleBackColor = true;
            redOnePoint.Click += redOnePoint_Click;
            // 
            // redTwoPoint
            // 
            redTwoPoint.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            redTwoPoint.Location = new Point(44, 461);
            redTwoPoint.Name = "redTwoPoint";
            redTwoPoint.Size = new Size(646, 89);
            redTwoPoint.TabIndex = 7;
            redTwoPoint.Text = "Pass";
            redTwoPoint.UseVisualStyleBackColor = true;
            redTwoPoint.Click += redTwoPoint_Click;
            // 
            // redThreePoint
            // 
            redThreePoint.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            redThreePoint.Location = new Point(44, 556);
            redThreePoint.Name = "redThreePoint";
            redThreePoint.Size = new Size(646, 89);
            redThreePoint.TabIndex = 8;
            redThreePoint.Text = "Re-guard and pass";
            redThreePoint.UseVisualStyleBackColor = true;
            redThreePoint.Click += redThreePoint_Click;
            // 
            // redFourPoint
            // 
            redFourPoint.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            redFourPoint.Location = new Point(44, 651);
            redFourPoint.Name = "redFourPoint";
            redFourPoint.Size = new Size(646, 89);
            redFourPoint.TabIndex = 9;
            redFourPoint.Text = "Double pass / double re-guard and pass";
            redFourPoint.UseVisualStyleBackColor = true;
            redFourPoint.Click += redFourPoint_Click;
            // 
            // redFivePoint
            // 
            redFivePoint.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            redFivePoint.Location = new Point(44, 746);
            redFivePoint.Name = "redFivePoint";
            redFivePoint.Size = new Size(646, 89);
            redFivePoint.TabIndex = 10;
            redFivePoint.Text = "Re-guard and double pass";
            redFivePoint.UseVisualStyleBackColor = true;
            redFivePoint.Click += redFivePoint_Click;
            // 
            // redSixPoint
            // 
            redSixPoint.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            redSixPoint.Location = new Point(44, 841);
            redSixPoint.Name = "redSixPoint";
            redSixPoint.Size = new Size(646, 89);
            redSixPoint.TabIndex = 11;
            redSixPoint.Text = "Double re-guard double pass";
            redSixPoint.UseVisualStyleBackColor = true;
            redSixPoint.Click += redSixPoint_Click;
            // 
            // blueSixPoint
            // 
            blueSixPoint.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            blueSixPoint.Location = new Point(1065, 841);
            blueSixPoint.Name = "blueSixPoint";
            blueSixPoint.Size = new Size(646, 89);
            blueSixPoint.TabIndex = 17;
            blueSixPoint.Text = "Double re-guard double pass";
            blueSixPoint.UseVisualStyleBackColor = true;
            blueSixPoint.Click += blueSixPoint_Click;
            // 
            // blueFivePoint
            // 
            blueFivePoint.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            blueFivePoint.Location = new Point(1065, 746);
            blueFivePoint.Name = "blueFivePoint";
            blueFivePoint.Size = new Size(646, 89);
            blueFivePoint.TabIndex = 16;
            blueFivePoint.Text = "Re-guard and double pass";
            blueFivePoint.UseVisualStyleBackColor = true;
            blueFivePoint.Click += blueFivePoint_Click;
            // 
            // blueFourPoint
            // 
            blueFourPoint.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            blueFourPoint.Location = new Point(1065, 651);
            blueFourPoint.Name = "blueFourPoint";
            blueFourPoint.Size = new Size(646, 89);
            blueFourPoint.TabIndex = 15;
            blueFourPoint.Text = "Double pass / double re-guard and pass";
            blueFourPoint.UseVisualStyleBackColor = true;
            blueFourPoint.Click += blueFourPoint_Click;
            // 
            // blueThreePoint
            // 
            blueThreePoint.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            blueThreePoint.Location = new Point(1065, 556);
            blueThreePoint.Name = "blueThreePoint";
            blueThreePoint.Size = new Size(646, 89);
            blueThreePoint.TabIndex = 14;
            blueThreePoint.Text = "Re-guard and pass";
            blueThreePoint.UseVisualStyleBackColor = true;
            blueThreePoint.Click += blueThreePoint_Click;
            // 
            // blueTwoPoint
            // 
            blueTwoPoint.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            blueTwoPoint.Location = new Point(1065, 461);
            blueTwoPoint.Name = "blueTwoPoint";
            blueTwoPoint.Size = new Size(646, 89);
            blueTwoPoint.TabIndex = 13;
            blueTwoPoint.Text = "Pass";
            blueTwoPoint.UseVisualStyleBackColor = true;
            blueTwoPoint.Click += blueTwoPoint_Click;
            // 
            // blueOnePoint
            // 
            blueOnePoint.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            blueOnePoint.Location = new Point(1065, 366);
            blueOnePoint.Name = "blueOnePoint";
            blueOnePoint.Size = new Size(646, 89);
            blueOnePoint.TabIndex = 12;
            blueOnePoint.Text = "Re-guard";
            blueOnePoint.UseVisualStyleBackColor = true;
            blueOnePoint.Click += blueOnePoint_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(846, 366);
            label1.Name = "label1";
            label1.Size = new Size(105, 89);
            label1.TabIndex = 18;
            label1.Text = "1";
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(846, 461);
            label2.Name = "label2";
            label2.Size = new Size(105, 89);
            label2.TabIndex = 19;
            label2.Text = "2";
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(846, 556);
            label3.Name = "label3";
            label3.Size = new Size(105, 89);
            label3.TabIndex = 20;
            label3.Text = "3";
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(846, 651);
            label4.Name = "label4";
            label4.Size = new Size(105, 89);
            label4.TabIndex = 21;
            label4.Text = "4";
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(846, 746);
            label5.Name = "label5";
            label5.Size = new Size(105, 89);
            label5.TabIndex = 22;
            label5.Text = "5";
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(846, 841);
            label6.Name = "label6";
            label6.Size = new Size(105, 89);
            label6.TabIndex = 23;
            label6.Text = "6";
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Arial Narrow", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            resetButton.Location = new Point(1234, 40);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(166, 112);
            resetButton.TabIndex = 24;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // redNegative
            // 
            redNegative.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            redNegative.Location = new Point(134, 274);
            redNegative.Name = "redNegative";
            redNegative.Size = new Size(360, 66);
            redNegative.TabIndex = 25;
            redNegative.Text = "Negative";
            redNegative.UseVisualStyleBackColor = true;
            redNegative.Click += redNegative_Click;
            // 
            // blueNegative
            // 
            blueNegative.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            blueNegative.Location = new Point(1320, 256);
            blueNegative.Name = "blueNegative";
            blueNegative.Size = new Size(360, 66);
            blueNegative.TabIndex = 26;
            blueNegative.Text = "Negative";
            blueNegative.UseVisualStyleBackColor = true;
            blueNegative.Click += blueNegative_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 1055);
            Controls.Add(blueNegative);
            Controls.Add(redNegative);
            Controls.Add(resetButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(blueSixPoint);
            Controls.Add(blueFivePoint);
            Controls.Add(blueFourPoint);
            Controls.Add(blueThreePoint);
            Controls.Add(blueTwoPoint);
            Controls.Add(blueOnePoint);
            Controls.Add(redSixPoint);
            Controls.Add(redFivePoint);
            Controls.Add(redFourPoint);
            Controls.Add(redThreePoint);
            Controls.Add(redTwoPoint);
            Controls.Add(redOnePoint);
            Controls.Add(blueScore);
            Controls.Add(redScore);
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
        private Label redScore;
        private Label blueScore;
        private Button redOnePoint;
        private Button redTwoPoint;
        private Button redThreePoint;
        private Button redFourPoint;
        private Button redFivePoint;
        private Button redSixPoint;
        private Button blueSixPoint;
        private Button blueFivePoint;
        private Button blueFourPoint;
        private Button blueThreePoint;
        private Button blueTwoPoint;
        private Button blueOnePoint;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button resetButton;
        private Button redNegative;
        private Button blueNegative;
    }
}