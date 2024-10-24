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
    public partial class Page : UserControl
    {
        public List<QuestionControl> questions = new();

        public event EventHandler AnswerChanged;

        public Page(IEnumerable<QuestionData> questionDatas)
        {
            InitializeComponent();
            foreach(QuestionData questionData in questionDatas)
            {
                if (questionData is MultipleChoiceQuestionData md)
                {
                    AddQuestion(md);
                }
                else if(questionData is OpenQuestionData od)
                {
                    AddQuestion(od);
                }
                else if(questionData is LabelQuestionData ld)
                {
                    AddQuestion(ld);
                }else if(questionData is ImageQuestionData id)
                {
                    AddQuestion(id);
                }
            }
        }

        private void AddQuestion(ImageQuestionData id)
        {
            ImageQuestion question = new(id)
            {
                Dock = DockStyle.Top,
                //AutoSize = true,
            };
            Controls.Add(question);
            question.BringToFront();
        }

        private void AddQuestion(MultipleChoiceQuestionData q)
        {
            MultipleChoiceQuestion question = new(q)
            {
                Dock = DockStyle.Top,
                AutoSize = true,
            };
            question.AnswerChanged += (sender, e) =>
            {
                HasAnswerChanged();
            };
            questions.Add(question);
            Controls.Add(question);
            question.BringToFront();

        }

        private void AddQuestion(OpenQuestionData q)
        {
            OpenQuestion question = new(q)
            {
                Dock = DockStyle.Top,
                AutoSize = true,
            };
            question.AnswerChanged += (sender, e) =>
            {
                HasAnswerChanged();
            };
            questions.Add(question);
            Controls.Add(question);
            question.BringToFront();

        }

        private void AddQuestion(LabelQuestionData q)
        {
            LabelQuestion question = new(q)
            {
                Dock = DockStyle.Top,
                AutoSize = true,
            };
            question.AnswerChanged += (sender, e) =>
            {
                HasAnswerChanged();
            };
            questions.Add(question);
            Controls.Add(question);
            question.BringToFront();

        }
        public bool AreAllQuestionsAnswered
        {
            get
            {
                return questions.All(i => i.HasAnswer);
            }
        }

        void HasAnswerChanged()
        {
            AnswerChanged?.Invoke(this, new EventArgs());
        }
    }
}
