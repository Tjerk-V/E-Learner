using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADR_Cursus
{
    public partial class OpenQuestion : QuestionControl
    {
        public override bool HasAnswer => textBox1.Text.Replace(" ", "") != "";
        public string QuestionText
        {
            get => QuestionLabel.Text;
        }
        public string AnswerText
        {
            get => textBox1.Text;
        }

        public EventHandler AnswerChanged;
        public OpenQuestion(OpenQuestionData question)
        {
            InitializeComponent();
            QuestionLabel.Text = question.Question;
            textBox1.TextChanged += (sender, e) =>
            {
                AnswerChanged?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}
