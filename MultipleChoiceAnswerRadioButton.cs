using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADR_Cursus
{
    public class MultipleChoiceAnswerRadioButton : RadioButton
    {
        private readonly MultipleChoiceAnswer answer;

        public bool IsCorrectAnswer => answer.IsCorrectAnswer;

        public MultipleChoiceAnswerRadioButton(MultipleChoiceAnswer answer)
        {
            this.answer = answer;
        }

    }
}
