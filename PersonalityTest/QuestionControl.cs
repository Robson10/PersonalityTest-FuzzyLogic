using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalityTest
{
    public partial class QuestionControl : UserControl
    {
        private int i = 0;
        public QuestionControl()
        {
            InitializeComponent();
            i = -1;
            NextQuestion();
        }

        private int selectedRadio {
            get { return Form1.QuestionsList[i].selected; }
            set { Form1.QuestionsList[i].selected = value; }
        }
        private void NextQuestion()
        {
            if (i < Form1.QuestionsList.Count-1)
            {
                i++;
                tbQuestion.Text = Form1.QuestionsList[i].Text;
                switch (selectedRadio)
                {
                    case (0):
                        radioNotAgree.Checked = true;
                        break;
                    case (1):
                        radioPropablyNot.Checked = true;
                        break;
                    case (2):
                        radioNotKnown.Checked = true;
                        break;
                    case (3):
                        radioPropablyYes.Checked = true;
                        break;
                    case (4):
                        radioAgree.Checked = true;
                        break;
                    default:
                        radioNotKnown.Checked = true;
                        break;
                }
                btNext.Text = "Dalej";
            }
            else if (i < Form1.QuestionsList.Count)
            {
                btNext.Text = "Wyniki";
            }
        }
        private void PrevioustQuestion()
        {
            if (i > 0)
            {
                i--;
                btNext.Text = "Dalej";
                tbQuestion.Text = Form1.QuestionsList[i].Text;
                switch (selectedRadio)
                {
                    case (0):
                        radioNotAgree.Checked = true;
                        break;
                    case (1):
                        radioPropablyNot.Checked = true;
                        break;
                    case (2):
                        radioNotKnown.Checked = true;
                        break;
                    case (3):
                        radioPropablyYes.Checked = true;
                        break;
                    case (4):
                        radioAgree.Checked = true;
                        break;
                    default:
                        radioNotKnown.Checked = true;
                        break;
                }
            }
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            if (selectedRadio!=-1)
                AddWeights(Form1.QuestionsList[i].Answers[selectedRadio]);
            if ((sender as Button).Text.Equals("Wyniki"))
            {
                //wyświetl wyniki w nowym oknie
                ResultForm resultForm = new ResultForm();
                if (resultForm.ShowDialog() == DialogResult.Cancel)
                {
                    btBack.Visible = false;
                    (sender as Button).Text = "Ponownie";
                }

            }
            else if ((sender as Button).Text.Equals("Ponownie"))
            {
                btBack.Visible = true;
                Form1.QuestionsList = new QuestionsList();

                Form1.ChartOfTacticsConclusion.CurrentXValue =50;
                Form1.ChartOfEnergyConclusion.CurrentXValue=50;
                Form1.ChartOfIdentityConclusion.CurrentXValue =50;
                Form1.ChartOfMindConclusion.CurrentXValue =50;
                Form1.ChartOfNatureConclusion.CurrentXValue =50;
                i = -1;
                NextQuestion();
            }

            else
                NextQuestion();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            PrevioustQuestion();
            if (selectedRadio != -1)
                SubstractWeights(Form1.QuestionsList[i].Answers[selectedRadio]);
        }
        protected virtual void OnXValuesChanged()
        {
            XValuesChanged?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler XValuesChanged;
        private void AddWeights(Answer answer)
        {
            Form1.ChartOfTacticsConclusion.CurrentXValue += answer.TacticsWeight;
            Form1.ChartOfEnergyConclusion.CurrentXValue += answer.EnergyWeight;
            Form1.ChartOfIdentityConclusion.CurrentXValue += answer.IdentityWeight;
            Form1.ChartOfMindConclusion.CurrentXValue += answer.MindWeight;
            Form1.ChartOfNatureConclusion.CurrentXValue += answer.NatureWeight;
            OnXValuesChanged();
        }
        private void SubstractWeights(Answer answer)
        {
            Form1.ChartOfTacticsConclusion.CurrentXValue -= answer.TacticsWeight;
            Form1.ChartOfEnergyConclusion.CurrentXValue -= answer.EnergyWeight;
            Form1.ChartOfIdentityConclusion.CurrentXValue -= answer.IdentityWeight;
            Form1.ChartOfMindConclusion.CurrentXValue -= answer.MindWeight;
            Form1.ChartOfNatureConclusion.CurrentXValue -= answer.NatureWeight;
            OnXValuesChanged();
        }

        private void radioNotKnown_CheckedChanged_1(object sender, EventArgs e)
        {
            selectedRadio = 2;
        }

        private void radioNotAgree_CheckedChanged_1(object sender, EventArgs e)
        {
            selectedRadio = 0;
        }

        private void radioPropablyNot_CheckedChanged_1(object sender, EventArgs e)
        {
            selectedRadio = 1;
        }

        private void radioPropablyYes_CheckedChanged_1(object sender, EventArgs e)
        {
            selectedRadio = 3;
        }

        private void radioAgree_CheckedChanged_1(object sender, EventArgs e)
        {
            selectedRadio = 4;
        }
    }
}
