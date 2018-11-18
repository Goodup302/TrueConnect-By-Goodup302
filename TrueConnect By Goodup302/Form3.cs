using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueConnect_By_Goodup302
{
    public partial class Form3 : Form
    {

        ChartGestion chartGestion;
        public Form3()
        {
            InitializeComponent();
            chartGestion = new ChartGestion(chart);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            PingLoop ping = new PingLoop(inputAdresse.Text, int.Parse(inputTime.Text));
            int.Parse(inputLatency.Text);
            ping.defineQuery(int.Parse(inputBuffer.Text), int.Parse(inputLatency.Text));
            ping.run();


            chartGestion.initChart(0, ping.logPing);
        }
    }
}
