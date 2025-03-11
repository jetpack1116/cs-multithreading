using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace LinearMotorSimulation
{
    public partial class Form1 : Form
    {
        private int distance = 0;
        private bool isPaused = false;

        private CancellationTokenSource cts;
        private Task motorTask;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (motorTask == null || motorTask.IsCompleted)
            {
                distance = 0;
                txtDistance.Text = distance.ToString();

                cts = new CancellationTokenSource();
                motorTask = Task.Run(() => MoveMotor(cts.Token), cts.Token);

                btnStart.Enabled = false;
                btnPause.Enabled = true;
                btnStop.Enabled = true;
            }
        }

        private void MoveMotor(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (!isPaused)
                {
                    distance++;
                    txtDistance.Invoke(() => txtDistance.Text = distance.ToString());
                    Thread.Sleep(100);
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            isPaused = true;
            btnPause.Enabled = false;
            btnContinue.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            isPaused = false;
            btnPause.Enabled = true;
            btnContinue.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            distance = 0;
            txtDistance.Text = "0";

            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnContinue.Enabled = false;
            btnStop.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
                cts.Dispose();
            }
            Console.WriteLine("Application is closing...");
        }
    }
}
