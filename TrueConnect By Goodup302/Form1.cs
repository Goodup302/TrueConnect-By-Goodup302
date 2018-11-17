using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrueConnect_By_Goodup302
{
    public partial class Form1 : Form
    {
        private int currentSelectedLog;
        private double error;

        public Form1()
        {
            InitializeComponent();

            Form2 f2 = new Form2();
            f2.Show();


            chart1.ChartAreas.Add("Base");
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = -1;

            // Set Chart Area position
            //chart1.ChartAreas[0].Position.Auto = false;
            //chart1.ChartAreas[0].Position.X = 10;
            //chart1.ChartAreas[0].Position.Y = 10;
            //chart1.ChartAreas[0].Position.Width = 80;
            //chart1.ChartAreas[0].Position.Height = 80;

            // Set the plotting area position. Coordinates of a plotting 
            // area are relative to a chart area position.
            //chart1.ChartAreas[0].InnerPlotPosition.Auto = false;
            //chart1.ChartAreas[0].InnerPlotPosition.X = 10;
            //chart1.ChartAreas[0].InnerPlotPosition.Y = 10;
            //chart1.ChartAreas[0].InnerPlotPosition.Width = 80;
            //chart1.ChartAreas[0].InnerPlotPosition.Height = 80;


            Timer time = new Timer();
            time.Interval = 5000;
            time.Tick += Time_Tick;



            chart1.Series.Add("Gigue");
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].Color = Color.Black;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series.Add("Average");
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].Color = Color.DarkGoldenrod;
            chart1.Series[1].BorderWidth = 3;
            chart1.Series.Add("Error");
            chart1.Series[2].ChartType = SeriesChartType.Point;
            chart1.Series[2].Color = Color.Red;
            chart1.Series[2].MarkerSize = 11;
            chart1.Series[2].MarkerStyle = MarkerStyle.Cross;

            chart1.Series.Add("Minimum");
            chart1.Series[3].ChartType = SeriesChartType.Line;
            chart1.Series[3].Color = Color.DarkOrange;
            chart1.Series[3].BorderWidth = 2;
            chart1.Series.Add("Maximum");
            chart1.Series[4].ChartType = SeriesChartType.Line;
            chart1.Series[4].Color = Color.Green;
            chart1.Series[4].BorderWidth = 2;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("hellow");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPing.Items.Clear();
            double loopSize = double.Parse(TextBoxLoopTime.Text);
            int maxMs = int.Parse(TextBoxMaxMs.Text);
            int bufferSize = int.Parse(bufferText.Text);
            double msBuffer = 0;
            error = 0;
            int i;
            string messageList = null;
            int[] logPing = new int[(int)loopSize];
            int[] logPingSuccess = new int[(int)loopSize];
            int[] logPingError = new int[(int)loopSize];

            int succesPing = 0;

            int resultMinMs = maxMs;
            int resultMaxMs = 0;

            chart1.Series[2].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = loopSize - 1;
            for (i = 0; i < loopSize; i++)
            {
                PingReply result = NetworkConnection.PingHost(TextBoxIp.Text, bufferSize, maxMs);
                if (result != null && result.Status == IPStatus.Success && result.RoundtripTime <= maxMs)
                {
                    msBuffer += result.RoundtripTime;
                    messageList = "[" + i + "]    " + result.RoundtripTime + "ms  -  " + result.Status;
                    logPing[i] = (int)result.RoundtripTime;
                    succesPing++;

                    if (resultMaxMs < result.RoundtripTime)
                    {
                        resultMaxMs = (int)result.RoundtripTime;
                    }
                    if (resultMinMs > result.RoundtripTime)
                    {
                        resultMinMs = (int)result.RoundtripTime;
                    }
                }
                else
                {
                    logPing[i] = -1;
                    error++;
                    messageList = "[" + i + "]    Error  -  " + result.Status;
                    chart1.Series[2].Points.AddXY(i, 0);
                }
                listPing.Items.Add(messageList);
                progressBar.Value = (int)(i / loopSize * 100);
            }
            progressBar.Value = 100;

            ConnectionLabel.Text = Math.Round((msBuffer / succesPing), 2) + " ms en moyenne | " + Math.Round((error / loopSize), 2) * 100 + " % d'erreur " + error +" - Max ms: "+ resultMaxMs + " - Min ms: " + resultMinMs;

            chart1.Series[0].Points.Clear();
            initChar(logPing);
            setAverageChar((msBuffer / succesPing), loopSize);
            setMinimumChar(resultMinMs, loopSize);
            setMaximumChar(resultMaxMs, loopSize);

            trackBar.Maximum = succesPing - 1;

        }

        public void initChar(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > -1)
                {
                    chart1.Series[0].Points.AddXY(i, list[i]);
                }
            }
        }
        public void setAverageChar(double average, double size)
        {
            chart1.Series[1].Points.Clear();
            chart1.Series[1].Points.AddXY(0, average);
            chart1.Series[1].Points.AddXY(size - 1, average);
        }

        public void setMinimumChar(double minimum, double size)
        {
            chart1.Series[3].Points.Clear();
            chart1.Series[3].Points.AddXY(0, minimum);
            chart1.Series[3].Points.AddXY(size - 1, minimum);
        }
        public void setMaximumChar(double maximum, double size)
        {
            chart1.Series[4].Points.Clear();
            chart1.Series[4].Points.AddXY(0, maximum);
            chart1.Series[4].Points.AddXY(size - 1, maximum);
        }

        public void selectPoint(int index)
        {
            chart1.Series[0].Points[index].MarkerColor = Color.Red;
            chart1.Series[0].Points[index].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].Points[index].MarkerSize = 15;
        }
        public void deselectPoint(int index)
        {
            chart1.Series[0].Points[index].MarkerStyle = MarkerStyle.None;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (currentSelectedLog > -1)
            {
                deselectPoint(currentSelectedLog);
            }
            int index = trackBar.Value;
            selectPoint(index);
            currentSelectedLog = index;
        }
    }
}
