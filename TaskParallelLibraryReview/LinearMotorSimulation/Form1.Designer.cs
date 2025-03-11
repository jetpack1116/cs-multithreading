namespace LinearMotorSimulation
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
            btnStart = new Button();
            btnStop = new Button();
            txtDistance = new TextBox();
            btnPause = new Button();
            btnContinue = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(23, 14);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 40);
            btnStart.TabIndex = 0;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(120, 14);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 40);
            btnStop.TabIndex = 1;
            btnStop.Text = "S&top";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(252, 14);
            txtDistance.Name = "txtDistance";
            txtDistance.ReadOnly = true;
            txtDistance.Size = new Size(100, 23);
            txtDistance.TabIndex = 2;
            txtDistance.Text = "0";
            // 
            // btnPause
            // 
            btnPause.Enabled = false;
            btnPause.Location = new Point(252, 68);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(75, 40);
            btnPause.TabIndex = 3;
            btnPause.Text = "&Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnContinue
            // 
            btnContinue.Enabled = false;
            btnContinue.Location = new Point(347, 68);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(75, 40);
            btnContinue.TabIndex = 4;
            btnContinue.Text = "&Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContinue);
            Controls.Add(btnPause);
            Controls.Add(txtDistance);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private TextBox txtDistance;
        private Button btnPause;
        private Button btnContinue;
    }
}
