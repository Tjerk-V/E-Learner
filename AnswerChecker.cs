using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADR_Cursus
{
    public static class AnswerChecker
    {
        public static void CheckLabelQuestions(List<LabelQuestion> questions)
        {
            foreach(LabelQuestion question in questions)
            {
                question.hasLabelImagesCorrect = CheckLabelImages(question);
                question.hasLabelNumberCorrect = CheckLabelNumber(question);
            }
        }

        private static bool CheckLabelNumber(LabelQuestion question)
        {
            return question.Labelnumber == question.QuestionData.LabelNumber.CorrectLabelNumber;
        }

        private static bool CheckLabelImages(LabelQuestion question)
        {
            IEnumerable<Image> correctAnswers = GetCorrectAnswers(question);
            IEnumerable<Image> selectedImages = GetSelectedImages(question);
            CheckIndividualImages(correctAnswers, question);
            return CheckSelectedImages(correctAnswers, selectedImages);           
        }

        private static void CheckIndividualImages(IEnumerable<Image> correctAnswers, LabelQuestion question)
        {
            foreach(LabelImagePictureBox image in question.PictureBoxes)
                image.isCorrectImage = correctAnswers.Contains(image.SelectedImage);
        }

        private static IEnumerable<Image> GetCorrectAnswers(LabelQuestion question)
        {
            return question.QuestionData.LabelImages
                .Where(i => i.Type == LabelType.ToBeFilled)
                .Select(i => LabelImages.GetImageFromName(i.CorrectImage))
                .ToList();
        }

        private static IEnumerable<Image> GetSelectedImages(LabelQuestion question)
        {
            return question.PictureBoxes
                .Where(i => i.labelImage != null && i.ShouldBeFilled)
                .Select(i => i.SelectedImage)
                .ToList();
        }

        static bool CheckSelectedImages(IEnumerable<Image> correctAnswers, IEnumerable<Image> selectedImages)
        {            
            return correctAnswers.All(i => selectedImages.Contains(i));
        }

    }
}
