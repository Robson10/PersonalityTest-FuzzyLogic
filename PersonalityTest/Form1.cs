using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PersonalityTest
{
    public partial class Form1 : Form
    {
        public static QuestionsList QuestionsList = new QuestionsList();
        private Chart ChartOfBlurring = new Chart();
        private Chart ChartOfMindConclusion = new Chart()
        {
            Name="Umysł"
        };
        private Chart ChartOfEnergyConclusion = new Chart()
        {
            Name="Energia"
        };
        private Chart ChartOfNatureConclusion = new Chart()
        {
            Name="Natura"
        };
        private Chart ChartOfTacticsConclusion = new Chart()
        {
            Name = "Taktyka"
        };
        private Chart ChartOfIdentityConclusion = new Chart()
        {
            Name = "Identyfikacja"
        };

        public static double MindXValue = 50;
        public static double EnergyXValue = 50;
        public static double NatureXValue = 50;
        public static double TacticsXValue = 50;
        public static double IdentityXValue = 50;
        public static double MindCoG = 50;
        public static double EnergyCoG = 50;
        public static double NatureCoG = 50;
        public static double TacticsCoG = 50;
        public static double IdentityCoG = 50;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            SetChartOfBluring(ChartOfBlurring);
            tabControl1.TabPages[1].Resize += Form1_Resize1;
            tabControl1.TabPages[0].Resize += Form1_Resize;
            SetPersonalityCharts();
            questionControl1.XValuesChanged += QuestionControl1_XValuesChanged;
        }

        private void QuestionControl1_XValuesChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            UpdateCharts
                 (
                 ChartOfMindConclusion,
                 ChartOfBlurring.Series[0].Points[(int)Math.Round(MindXValue + 50)].YValues[0], //+50 ponieważ wykres rysowany jest od -50 do 150 aby mozna było uzyskać wartości skrajne
                 ChartOfBlurring.Series[1].Points[(int)Math.Round(MindXValue + 50)].YValues[0],
                 ChartOfBlurring.Series[2].Points[(int)Math.Round(MindXValue + 50)].YValues[0],
                 (int)Math.Round(MindXValue), ref MindCoG
                 );
            UpdateCharts
                (
                ChartOfEnergyConclusion,
                ChartOfBlurring.Series[0].Points[(int)Math.Round(EnergyXValue + 50)].YValues[0],
                ChartOfBlurring.Series[1].Points[(int)Math.Round(EnergyXValue + 50)].YValues[0],
                ChartOfBlurring.Series[2].Points[(int)Math.Round(EnergyXValue + 50)].YValues[0],
                (int)Math.Round(EnergyXValue),ref EnergyCoG
                );
            UpdateCharts
                (
                ChartOfNatureConclusion,
                ChartOfBlurring.Series[0].Points[(int)Math.Round(NatureXValue + 50)].YValues[0],
                ChartOfBlurring.Series[1].Points[(int)Math.Round(NatureXValue + 50)].YValues[0],
                ChartOfBlurring.Series[2].Points[(int)Math.Round(NatureXValue + 50)].YValues[0],
                (int)Math.Round(NatureXValue), ref NatureCoG
                );
            UpdateCharts
                (
                ChartOfTacticsConclusion,
                ChartOfBlurring.Series[0].Points[(int)Math.Round(TacticsXValue + 50)].YValues[0],
                ChartOfBlurring.Series[1].Points[(int)Math.Round(TacticsXValue + 50)].YValues[0],
                ChartOfBlurring.Series[2].Points[(int)Math.Round(TacticsXValue + 50)].YValues[0],
                (int)Math.Round(TacticsXValue), ref TacticsCoG
                );
            UpdateCharts
                (
                ChartOfIdentityConclusion,
                ChartOfBlurring.Series[0].Points[(int)Math.Round(IdentityXValue + 50)].YValues[0],
                ChartOfBlurring.Series[1].Points[(int)Math.Round(IdentityXValue + 50)].YValues[0],
                ChartOfBlurring.Series[2].Points[(int)Math.Round(IdentityXValue + 50)].YValues[0],
                (int)Math.Round(IdentityXValue),ref IdentityCoG
                );
        }

        private void UpdateCharts(Chart chart, double PersonalityYvalue1, double PersonalityYvalue2, double PersonalityYvalue3, int x, ref double CoG)
        {
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
            chart.Series.Clear();
            chart.Series.Add(low);
            chart.Series.Add(mid);
            chart.Series.Add(high);
            chart.Series.Add(concat);



            for (int i = -50; i < 151; i++)
            {
                if (i <= 0)
                {
                    low.Points.AddXY(i, Math.Min(((i + 50) * 2) / 100.0, PersonalityYvalue1));
                    mid.Points.AddXY(i, 0);
                    high.Points.AddXY(i, 0);
                }
                else if ((i > 0) && (i <= 50))
                {
                    low.Points.AddXY(i, Math.Min((((50 - i) * 2) / 100.0), PersonalityYvalue1));
                    mid.Points.AddXY(i, Math.Min((i * 2 / 100.0), PersonalityYvalue2));
                    high.Points.AddXY(i, 0);
                }
                else if ((i > 50) && (i <= 100))
                {
                    low.Points.AddXY(i, 0);
                    mid.Points.AddXY(i, Math.Min((((100 - i) * 2 / 100.0)), PersonalityYvalue2));
                    high.Points.AddXY(i, Math.Min((((i - 50) * 2 / 100.0)), PersonalityYvalue3));
                }
                else if ((i > 100) && (i <= 150))
                {
                    low.Points.AddXY(i, 0);
                    mid.Points.AddXY(i, 0);
                    high.Points.AddXY(i, Math.Min((((150 - i) * 2 / 100.0)), PersonalityYvalue3));
                }

                concat.Points.AddXY(i,
                    Math.Max(Math.Max(low.Points.Last().YValues[0], mid.Points.Last().YValues[0]),
                        high.Points.Last().YValues[0]));
            }
            chart.Invalidate();
            CoG = CenterOfGravity(chart);
            label1.Text +=
                            chart.Name + Environment.NewLine + Environment.NewLine +
                            "Wartości termów dla x = " + x + " to:" + Environment.NewLine +
                            "Mało = " + PersonalityYvalue1 + Environment.NewLine +
                            "Średnio = " + PersonalityYvalue2 + Environment.NewLine +
                            "Dużo = " + PersonalityYvalue3 + Environment.NewLine + Environment.NewLine +
                            "Wynik metody środka ciezkosci to: " + String.Format("{0,5:##0.00}", CoG) + Environment.NewLine + Environment.NewLine
                            ;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            questionControl1.Location =
                new Point(tabControl1.TabPages[0].Width / 2 - questionControl1.Width / 2, tabControl1.TabPages[0].Height/2-questionControl1.Height/2);
        }

        private void SetPersonalityCharts()
        {
            SetChartOfPersonalityConclusion
                (
                ChartOfMindConclusion, 
                ChartOfBlurring.Series[0].Points[(int)Math.Round(MindXValue + 50)].YValues[0], //+50 ponieważ wykres rysowany jest od -50 do 150 aby mozna było uzyskać wartości skrajne
                ChartOfBlurring.Series[1].Points[(int)Math.Round(MindXValue + 50)].YValues[0], 
                ChartOfBlurring.Series[2].Points[(int)Math.Round(MindXValue + 50)].YValues[0],
                (int)Math.Round(MindXValue)
                );
            SetChartOfPersonalityConclusion
                (
                ChartOfEnergyConclusion, 
                ChartOfBlurring.Series[0].Points[(int)Math.Round(EnergyXValue + 50)].YValues[0], 
                ChartOfBlurring.Series[1].Points[(int)Math.Round(EnergyXValue + 50)].YValues[0], 
                ChartOfBlurring.Series[2].Points[(int)Math.Round(EnergyXValue + 50)].YValues[0],
                (int)Math.Round(EnergyXValue)
                );
            SetChartOfPersonalityConclusion
                (
                ChartOfNatureConclusion, 
                ChartOfBlurring.Series[0].Points[(int)Math.Round(NatureXValue + 50)].YValues[0], 
                ChartOfBlurring.Series[1].Points[(int)Math.Round(NatureXValue + 50)].YValues[0], 
                ChartOfBlurring.Series[2].Points[(int)Math.Round(NatureXValue + 50)].YValues[0],
                (int)Math.Round(NatureXValue)
                );
            SetChartOfPersonalityConclusion
                (
                ChartOfTacticsConclusion, 
                ChartOfBlurring.Series[0].Points[(int)Math.Round(TacticsXValue + 50)].YValues[0],
                ChartOfBlurring.Series[1].Points[(int)Math.Round(TacticsXValue + 50)].YValues[0], 
                ChartOfBlurring.Series[2].Points[(int)Math.Round(TacticsXValue + 50)].YValues[0],
                (int)Math.Round(TacticsXValue)
                );
            SetChartOfPersonalityConclusion
                (
                ChartOfIdentityConclusion, 
                ChartOfBlurring.Series[0].Points[(int)Math.Round(IdentityXValue + 50)].YValues[0], 
                ChartOfBlurring.Series[1].Points[(int)Math.Round(IdentityXValue + 50)].YValues[0], 
                ChartOfBlurring.Series[2].Points[(int)Math.Round(IdentityXValue + 50)].YValues[0],
                (int)Math.Round(IdentityXValue)
                );
        }

        private void Form1_Resize1(object sender, EventArgs e)
        {
            int off = 40;
            int h = tabControl1.TabPages[1].ClientSize.Height / 4 - off;
            int w = tabControl1.TabPages[1].Width/2 - label1.Width - 50;

            ChartOfBlurring.Size = new Size(w, h);
            ChartOfBlurring.Location = new Point(0, off);

            ChartOfMindConclusion.Size = new Size(w, h);
            ChartOfMindConclusion.Location = new Point(ChartOfBlurring.Location.X + w, off);

            ChartOfEnergyConclusion.Size = new Size(w, h);
            ChartOfEnergyConclusion.Location = new Point(0, ChartOfMindConclusion.Location.Y + ChartOfMindConclusion.Height + off);

            ChartOfNatureConclusion.Size = new Size(w, h);
            ChartOfNatureConclusion.Location = new Point(0, ChartOfEnergyConclusion.Location.Y + ChartOfEnergyConclusion.Height + off);

            ChartOfTacticsConclusion.Size = new Size(w, h);
            ChartOfTacticsConclusion.Location = new Point(ChartOfNatureConclusion.Location.X+w, ChartOfMindConclusion.Location.Y + ChartOfEnergyConclusion.Height + off);

            ChartOfIdentityConclusion.Size = new Size(w, h);
            ChartOfIdentityConclusion.Location = new Point(ChartOfNatureConclusion.Location.X + w, ChartOfEnergyConclusion.Location.Y + ChartOfEnergyConclusion.Height + off);

            label1.Location = new Point(tabControl1.TabPages[1].Width - label1.Width - 10, 0);
        }

        private void SetChartOfPersonalityConclusion(Chart chart, double PersonalityYvalue1, double PersonalityYvalue2, double PersonalityYvalue3,int x)//PersonalityYValue to wartości gdzie wykres ma max wartości dla min, śred, max
        {
            #region Design
            chart.Titles.Add(chart.Name);
            chart.ChartAreas.Add(new ChartArea());
            chart.Legends.Add(new Legend());
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 100;
            chart.ChartAreas[0].AxisY.Maximum = 1;
            chart.ChartAreas[0].AxisY.Minimum = 0;
            tabControl1.TabPages[1].Controls.Add(chart);
            var low = new Series()
            {
                Name = "Mało",
                Color = Color.Blue,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = SeriesChartType.Line,
                BorderWidth=2
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
            chart.Series.Clear();
            chart.Series.Add(low);
            chart.Series.Add(mid);
            chart.Series.Add(high);
            chart.Series.Add(concat);

            #endregion

            for (int i = -50; i < 151; i++)
            {
                if (i <= 0)
                {
                    low.Points.AddXY(i, Math.Min(((i + 50) * 2) / 100.0,PersonalityYvalue1));
                    mid.Points.AddXY(i, 0);
                    high.Points.AddXY(i, 0);
                }
                else if ((i > 0) && (i <= 50))
                {
                    low.Points.AddXY(i, Math.Min((((50 - i) * 2) / 100.0), PersonalityYvalue1));
                    mid.Points.AddXY(i, Math.Min((i * 2 / 100.0), PersonalityYvalue2));
                    high.Points.AddXY(i, 0);
                }
                else if ((i > 50) && (i <= 100))
                {
                    low.Points.AddXY(i, 0);
                    mid.Points.AddXY(i, Math.Min((((100 - i) * 2 / 100.0)), PersonalityYvalue2));
                    high.Points.AddXY(i, Math.Min((((i - 50) * 2 / 100.0)), PersonalityYvalue3));
                }
                else if ((i > 100) && (i <= 150))
                {
                    low.Points.AddXY(i, 0);
                    mid.Points.AddXY(i, 0);
                    high.Points.AddXY(i, Math.Min((((150 - i) * 2 / 100.0)), PersonalityYvalue3));
                }

                concat.Points.AddXY(i,
                    Math.Max(Math.Max(low.Points.Last().YValues[0], mid.Points.Last().YValues[0]),
                        high.Points.Last().YValues[0]));
            }
            chart.Invalidate();
            var COG=CenterOfGravity(chart);
            label1.Text+=
                            chart.Name + Environment.NewLine + Environment.NewLine +
                            "Wartości termów dla x = " +x + " to:" + Environment.NewLine +
                            "Mało = " + PersonalityYvalue1 + Environment.NewLine +
                            "Średnio = " + PersonalityYvalue2 + Environment.NewLine +
                            "Dużo = " + PersonalityYvalue3 + Environment.NewLine + Environment.NewLine +
                            "Wynik metody środka ciezkosci to: " +String.Format("{0,5:##0.00}", COG) + Environment.NewLine + Environment.NewLine
                            ;
            label1.Location = new Point(Width-label1.Width, 0);

        }

        private void SetChartOfBluring(Chart chart)
        {
            #region Design
            chart.ChartAreas.Add(new ChartArea());
            chart.Legends.Add(new Legend());
            chart.Size = new Size(600, 200);
            tabControl1.TabPages[1].Controls.Add(chart);
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 100;
            var low = new Series()
            {
                Name="Mało",
                Color=Color.Blue,
                IsVisibleInLegend=true,
                IsXValueIndexed=false,
                ChartType=SeriesChartType.Line,
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
            chart.Series.Clear();
            chart.Series.Add(low);
            chart.Series.Add(mid);
            chart.Series.Add(high);
            #endregion
            for (int i = -50; i < 151; i++)
            {
                if (i <= 0)
                {
                    low.Points.AddXY(i, ((i + 50) * 2) / 100.0);
                    mid.Points.AddXY(i, 0);
                    high.Points.AddXY(i, 0);
                }
                else if ((i > 0) && (i <= 50))
                {
                    low.Points.AddXY(i, ((50 - i) * 2) / 100.0);
                    mid.Points.AddXY(i, i*2/100.0);
                    high.Points.AddXY(i, 0);
                }
                else if ((i > 50)&&(i<=100))
                {
                    low.Points.AddXY(i, 0);
                    mid.Points.AddXY(i, ((100-i) * 2 / 100.0));
                    high.Points.AddXY(i, ( (i-50)*2 / 100.0));
                }
                else if ((i > 100) && (i <= 150))
                {
                    low.Points.AddXY(i, 0);
                    mid.Points.AddXY(i, 0);
                    high.Points.AddXY(i, ((150 - i) * 2 / 100.0));
                }
            }
            chart.Invalidate();
        }

        private double CenterOfGravity(Chart chart)
        {
            double up= 0;
            double down = 0;
            for (int i = 0 ;i < chart.Series[3].Points.Count; i+=10)
            {
                double x = chart.Series[3].Points[i].XValue;
                double y = chart.Series[3].Points[i].YValues[0];
                up += x* y;
                down += y;
            }
            return up / down;
            
        }
    }
}
