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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            FillChart(ChartResult);
        }

        private void FillChart(Chart chart)
        {
            chart.Titles.Add("Wyniki");
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add(new ChartArea());
            chart.Legends.Clear();
            chart.Legends.Add(new Legend());
            chart.ChartAreas[0].AxisX.Interval=1;
            chart.ChartAreas[0].AxisY.Maximum = 100;
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.Series.Clear();
            var chartType = SeriesChartType.StackedBar;
            var Mind = new Series()
            {
                Name = "Umysł",
                Color = Color.LightBlue,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = chartType,
                IsValueShownAsLabel = true,
                BorderWidth = 2,
            };
            chart.Series.Add(Mind);
            Mind.Points.AddXY("Introwertyk", Math.Round(Form1.ChartOfMindConclusion.CoG));
            Mind.Points.AddXY("Ekstrawertyk", Math.Round(100 - Form1.ChartOfMindConclusion.CoG));

            var Energy = new Series()
            {
                Name = "Energia",
                Color = Color.Orange,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = chartType,
                IsValueShownAsLabel = true,
                BorderWidth = 10
            };
            chart.Series.Add(Energy);
            Energy.Points.AddXY("Realistyczny", Math.Round(Form1.ChartOfEnergyConclusion.CoG));
            Energy.Points.AddXY("Intuicyjny", Math.Round(100 - Form1.ChartOfEnergyConclusion.CoG));

            var Nature = new Series()
            {
                Name = "Natura",
                Color = Color.LightGreen,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = chartType,
                IsValueShownAsLabel = true,
                BorderWidth = 2
            };
            chart.Series.Add(Nature);
            Nature.Points.AddXY("Zasady", Math.Round(Form1.ChartOfNatureConclusion.CoG));
            Nature.Points.AddXY("Logika", Math.Round(100 - Form1.ChartOfNatureConclusion.CoG));

            var Tactics = new Series()
            {
                Name = "Taktyka",
                Color = Color.IndianRed,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = chartType,
                IsValueShownAsLabel = true,
                BorderWidth = 2
            };
            chart.Series.Add(Tactics);
            Tactics.Points.AddXY("Spontaniczny", Math.Round(Form1.ChartOfTacticsConclusion.CoG));
            Tactics.Points.AddXY("Planujący", Math.Round(100 - Form1.ChartOfTacticsConclusion.CoG));

            var Indentity = new Series()
            {
                Name = "Identyfikacja",
                Color = Color.MediumPurple,
                IsVisibleInLegend = true,
                IsXValueIndexed = false,
                ChartType = chartType,
                IsValueShownAsLabel = true,
                BorderWidth = 2
            };
            chart.Series.Add(Indentity);
            Indentity.Points.AddXY("Czujny", Math.Round(Form1.ChartOfIdentityConclusion.CoG));
            Indentity.Points.AddXY("Asertywny", Math.Round(100 - Form1.ChartOfIdentityConclusion.CoG));
            chart.AlignDataPointsByAxisLabel();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
