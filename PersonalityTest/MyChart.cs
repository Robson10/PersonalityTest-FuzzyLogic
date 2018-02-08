using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace PersonalityTest
{
    public class MyChart:Chart
    {
        public double CoG;
        public double CurrentXValue;
        public MyChart(string name,double coG, int currentXValue)
        {
            Name = name;
            CoG = coG;
            CurrentXValue = currentXValue;
            prepareChart();
        }

        private void prepareChart()
        {
            this.Titles.Add(this.Name);
            this.ChartAreas.Add(new ChartArea());
            this.Legends.Add(new Legend());
            this.ChartAreas[0].AxisX.Minimum = 0;
            this.ChartAreas[0].AxisX.Maximum = 100;
            this.ChartAreas[0].AxisY.Maximum = 1;
            this.ChartAreas[0].AxisY.Minimum = 0;
            var low = new Series()
            {
                Name = "Mało",
                Color = Color.Blue,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };
            var mid = new Series()
            {
                Name = "Średnio",
                Color = Color.Orange,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };
            var high = new Series()
            {
                Name = "Dużo",
                Color = Color.Red,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Line,
                BorderWidth = 2
            };
            var concat = new Series()
            {
                Name = "Wnioskowanie",
                Color = Color.Green,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Line,
                BorderWidth = 3
            };
            this.Series.Clear();
            this.Series.Add(low);
            this.Series.Add(mid);
            this.Series.Add(high);
            this.Series.Add(concat);
        }

        public void UpdateChart()
        {
            double t1 = GetYforCurrentXValue("Mało");
            double t2 = GetYforCurrentXValue("Średnio");
            double t3 = GetYforCurrentXValue("Dużo");
            Series["Mało"].Points.Clear();
            Series["Średnio"].Points.Clear();
            Series["Dużo"].Points.Clear();
            Series["Wnioskowanie"].Points.Clear();
            for (int i = -50; i < 151; i++)
            {
                if (i <= 0)
                {
                    Series["Mało"].Points.AddXY(i, Math.Min(((i + 50) * 2) / 100.0,t1 ));
                    Series["Średnio"].Points.AddXY(i, 0);
                    Series["Dużo"].Points.AddXY(i, 0);
                }
                else if ((i > 0) && (i <= 50))
                {
                    Series["Mało"].Points.AddXY(i, Math.Min((((50 - i) * 2) / 100.0), t1));
                    Series["Średnio"].Points.AddXY(i, Math.Min((i * 2 / 100.0), t2));
                    Series["Dużo"].Points.AddXY(i, 0);
                }
                else if ((i > 50) && (i <= 100))
                {
                    Series["Mało"].Points.AddXY(i, 0);
                    Series["Średnio"].Points.AddXY(i, Math.Min((((100 - i) * 2 / 100.0)), t2));
                    Series["Dużo"].Points.AddXY(i, Math.Min((((i - 50) * 2 / 100.0)), t3));
                }
                else if ((i > 100) && (i <= 150))
                {
                    Series["Mało"].Points.AddXY(i, 0);
                    Series["Średnio"].Points.AddXY(i, 0);
                    Series["Dużo"].Points.AddXY(i, Math.Min((((150 - i) * 2 / 100.0)), t3));
                }

                Series["Wnioskowanie"].Points.AddXY(i,
                    Math.Max(Math.Max(Series["Mało"].Points.Last().YValues[0], Series["Średnio"].Points.Last().YValues[0]),
                        Series["Dużo"].Points.Last().YValues[0]));
            }
            CoG = CenterOfGravity();
            Invalidate();
        }


        private double CenterOfGravity()
        {
            double up = 0;
            double down = 0;
            for (int i = 0; i < Series["Wnioskowanie"].Points.Count; i += 10)
            {
                double x = Series["Wnioskowanie"].Points[i].XValue;
                double y = Series["Wnioskowanie"].Points[i].YValues[0];
                up += x * y;
                down += y;
            }
            return up / down;
        }

        private double GetYforCurrentXValue(string SeriesName)
        {
            try
            {
                var result =Form1.ChartOfBlurring.Series[SeriesName].Points[(int) Math.Round(CurrentXValue + 50.0)].YValues[0];
                return result;
            }
            catch
            {
                return 1.0;
            }
        }

        public string TermsResultToString()
        {
            return Name + Environment.NewLine + Environment.NewLine +
                "Wartości termów dla x = " + (int)CurrentXValue + " to:" + Environment.NewLine +
                "Mało = " + GetYforCurrentXValue("Mało") + Environment.NewLine +
                "Średnio = " + GetYforCurrentXValue("Średnio") + Environment.NewLine +
                "Dużo = " + GetYforCurrentXValue("Dużo") + Environment.NewLine + Environment.NewLine +
                "Wynik metody środka ciezkosci to: " + String.Format("{0,5:##0.00}", CoG) + Environment.NewLine + Environment.NewLine
                ;
        }
    }
}
