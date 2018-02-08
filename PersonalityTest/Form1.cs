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
        public  static Chart ChartOfBlurring = new Chart();

        public static MyChart ChartOfMindConclusion = new MyChart("Umysł", 50, 50);

        public static MyChart ChartOfEnergyConclusion = new MyChart("Energia", 50, 50);

        public static MyChart ChartOfNatureConclusion = new MyChart("Natura", 50, 50);

        public static MyChart ChartOfTacticsConclusion = new MyChart("Taktyka", 50, 50);

        public static MyChart ChartOfIdentityConclusion = new MyChart("Identyfikacja", 50, 50);


        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            SetChartOfBluring(ChartOfBlurring);
            tabControl1.TabPages[1].Controls.Add(ChartOfMindConclusion);
            tabControl1.TabPages[1].Controls.Add(ChartOfEnergyConclusion);
            tabControl1.TabPages[1].Controls.Add(ChartOfNatureConclusion);
            tabControl1.TabPages[1].Controls.Add(ChartOfTacticsConclusion);
            tabControl1.TabPages[1].Controls.Add(ChartOfIdentityConclusion);


            tabControl1.TabPages[1].Resize += Form1_Resize1;
            tabControl1.TabPages[0].Resize += Form1_Resize;
            questionControl1.XValuesChanged += QuestionControl1_XValuesChanged;
        }

     

        private void QuestionControl1_XValuesChanged(object sender, EventArgs e)
        {
            UpdateCharts();
        }

        private void UpdateCharts()
        {
            label1.Text = "";
            ChartOfMindConclusion.UpdateChart();
            ChartOfEnergyConclusion.UpdateChart();
            ChartOfNatureConclusion.UpdateChart();
            ChartOfTacticsConclusion.UpdateChart();
            ChartOfIdentityConclusion.UpdateChart();
            label1.Text += ChartOfMindConclusion.TermsResultToString();
            label1.Text += ChartOfEnergyConclusion.TermsResultToString();
            label1.Text += ChartOfNatureConclusion.TermsResultToString();
            label1.Text += ChartOfTacticsConclusion.TermsResultToString();
            label1.Text += ChartOfIdentityConclusion.TermsResultToString();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            questionControl1.Location =
                new Point(tabControl1.TabPages[0].Width / 2 - questionControl1.Width / 2, tabControl1.TabPages[0].Height/2-questionControl1.Height/2);
        }

        private void Form1_Resize1(object sender, EventArgs e)
        {
            var lbWidth = 100;
            int off = 40;
            int h = tabControl1.TabPages[1].ClientSize.Height / 4 - off;
            int w = tabControl1.TabPages[1].Width/2 - lbWidth;

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

            label1.Location = new Point(tabControl1.TabPages[1].Width - lbWidth - 120, 0);
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

    }
}
