
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ADR_Cursus
{
    
    public abstract class QuestionData
    {
    }

    public class MultipleChoiceQuestionData : QuestionData
    {
        public string Question;
        public List<MultipleChoiceAnswer> Answers;
        //public MultipleChoiceAnswer CorrectAnswer;
    }

    public class MultipleChoiceAnswer
    {
        public string Answer;
        public bool IsCorrectAnswer;
    }

    
    public class OpenQuestionData : QuestionData
    {
        public string Question;
    }
    public class ImageQuestionData : QuestionData
    {
        public string TopText;
        public string BottomText;
        public string Filename;
        public int MaxSize;
    }

    public class LabelQuestionData : QuestionData
    {
        public LabelNumber LabelNumber;
        public string LabelDesc;
        public List<LabelImage> LabelImages;
    }
    public class LabelNumber
    {
        public string CorrectLabelNumber;
        public LabelType Type;
    }

    public class LabelImage
    {
        public string CorrectImage;
        public LabelType Type;
    }

    public enum LabelType
    {
        PreFilled,
        ToBeFilled
    }
}
