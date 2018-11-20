using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueConnect_By_Goodup302
{
    public partial class Form3 : Form
    {

        private ChartGestion chartGestion;
        public delegate void showDelegate(object value);
        public delegate void endDelegate(object value);
        public delegate void updateProgressBarDelegate(int value);

        private PingLoop request;
        public Thread thread;

        public Form3()
        {
            InitializeComponent();
            chartGestion = new ChartGestion(chart);
            progressBar.Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text != "Stop")
            {
                request = new PingLoop(inputAdresse.Text, int.Parse(inputTime.Text));
                int.Parse(inputLatency.Text);
                request.defineQuery(int.Parse(inputBuffer.Text), int.Parse(inputLatency.Text));
                request.endRunEvent += onPingLoop_endRun;
                request.loadingUpEvent += onPingLoop_loadingUp;

                progressBar.Visible = true;
                progressBar.Value = 0;
                buttonStart.Text = "Stop";
                chartGestion.init(0);

                thread = new Thread(new ThreadStart(request.run));
                thread.Start();
            }
            else
            {
                request.stop();
                buttonStart.Text = "Stopping";
                buttonStart.Enabled = false;
            }
        }

        private void onPingLoop_endRun(object sender, EventArgs e)
        {
            Invoke((showDelegate)end, sender);
        }
        private void end(object sender)
        {
            PingLoop ping = (PingLoop)sender;
            progressBar.Visible = false;
            chartGestion.update(0, ping.logPing);
            buttonStart.Text = "Start";
            buttonStart.Enabled = true;
        }

        private void show(object sender)
        {
            PingLoop ping = (PingLoop)sender;
            chartGestion.update(0, ping.logPing);
        }

        private void onPingLoop_loadingUp(object sender, EventArgs e)
        {
            PingLoop ping = (PingLoop)sender;
            Invoke((endDelegate)show, sender);
            Invoke((updateProgressBarDelegate)updateProgressBar, ping.progressPercentage);
        }
        private void updateProgressBar(int value)
        {
            progressBar.Value = value;
        }

        private void closeImage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonForm1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
