using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrueConnect_By_Goodup302
{
    class ChartGestion
    {
        Chart chart;
        public ChartGestion(Chart chart)
        {
            this.chart = chart;
        }

        public void init(int index)
        {
            chart.ChartAreas[index].BorderWidth = 3;
            chart.ChartAreas[index].AxisX.Minimum = 0;
            chart.ChartAreas[index].AxisY.Minimum = -1;
            chart.Series[index].Points.Clear();
        }

        public void update(int index, int[] list)
        {
            chart.Series[index].Points.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                    if (list[i] > -1)
                    {
                        chart.Series[index].Points.AddXY(i, list[i]);
                    }
                    else
                    {
                        chart.Series[index].Points.AddXY(i, 0);
                    }

            }
            chart.ChartAreas[index].Axes.y = 3;

        }
        public void addError(int index, int[] list)
        {
            chart.Series[index].Points.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > -1)
                {
                    chart.Series[index].Points.AddXY(i, list[i]);
                }
                else
                {
                    chart.Series[index].Points.AddXY(i, 0);
                }

            }
        }
    }
}
