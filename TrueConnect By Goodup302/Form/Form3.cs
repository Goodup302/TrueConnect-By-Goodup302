﻿using System;
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
        public delegate void updateProgressBarDelegate(int value);
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
                PingLoop ping = new PingLoop(inputAdresse.Text, int.Parse(inputTime.Text));
                int.Parse(inputLatency.Text);
                ping.defineQuery(int.Parse(inputBuffer.Text), int.Parse(inputLatency.Text));
                ping.endRunEvent += onPingLoop_endRun;
                ping.loadingUpEvent += onPingLoop_loadingUp;

                progressBar.Visible = true;
                progressBar.Value = 0;
                buttonStart.Text = "Stop";

                thread = new Thread(new ThreadStart(ping.run));
                thread.Start();
            }
            else
            {
                buttonStart.Text = "Start";
            }
        }

        private void onPingLoop_endRun(object sender, EventArgs e)
        {
            Invoke((showDelegate)show, sender);
        }
        private void show(object sender)
        {
            PingLoop ping = (PingLoop)sender;
            progressBar.Visible = false;
            chartGestion.initChart(0, ping.logPing);
            buttonStart.Text = "Start";
            buttonStart.Enabled = true;
        }

        private void onPingLoop_loadingUp(object sender, EventArgs e)
        {
            PingLoop ping = (PingLoop)sender;
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
