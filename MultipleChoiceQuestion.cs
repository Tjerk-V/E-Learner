using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADR_Cursus
{
    public partial class MultipleChoiceQuestion : QuestionControl
    {
        public event EventHandler AnswerChanged;

        public string QuestionText
        {
            get => QuestionLabel.Text;
            set => QuestionLabel.Text = value;
        }
        public MultipleChoiceAnswerRadioButton SelectedAnswer;
        public List<string> Answers = new();

        public MultipleChoiceQuestion(MultipleChoiceQuestionData question)
        { 
            InitializeComponent();
            QuestionLabel.Text = question.Question;
            AddAnswers(question.Answers);
        }


        public override bool HasAnswer => SelectedAnswer != null;


        private void AddAnswers(List<MultipleChoiceAnswer> answers)
        {
            foreach (MultipleChoiceAnswer answer in answers)
            {
                Answers.Add(answer.Answer);
                MultipleChoiceAnswerRadioButton radioButton = CreateRadioButton(answer);
                answersPanel.Controls.Add(radioButton);
                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (radioButton.Checked)
                    {
                        SelectedAnswer = radioButton;

                        AnswerChanged?.Invoke(this, EventArgs.Empty);
                    }
                };
            }
        }

        private MultipleChoiceAnswerRadioButton CreateRadioButton(MultipleChoiceAnswer answer)
        {
            return new(answer)
            {
                Text = answer.Answer,
                AutoSize = true,
            };
        }
    }
}
