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
    public partial class SendForm : Form
    {
        List<Page> Pages;
        List<LabelQuestion> labelQuestions;
        List<QuestionControl> allMultipleChoiceAndOpenQuestions;
        public SendForm(List<Page> pages)
        {
            InitializeComponent();
            Pages = pages;
            
        }

        private void SendCursus(object sender, EventArgs e)
        {
            CollectQuestions();
            CheckAllAnswers();
            CreateAndSendPdfFile();
            DialogResult = DialogResult.Continue;
        }

        private void CollectQuestions()
        {
            labelQuestions = CollectLabelQuestions(Pages);
            allMultipleChoiceAndOpenQuestions = CollectAllMultipleChoiceAndOpenQuestions(Pages);
        }

        private void CreateAndSendPdfFile()
        {

            PDFMaker.CreatePDFdocument();
            int maxQuestionsPerPage = 8;
            List<int> pages = CalculateTotalQuestionsPerPage(allMultipleChoiceAndOpenQuestions.Count, maxQuestionsPerPage);
            PDFMaker.CreateQuestionTable(allMultipleChoiceAndOpenQuestions, pages, NameText.Text, DateText.Text);

            maxQuestionsPerPage = 15;
            pages = CalculateTotalQuestionsPerPage(labelQuestions.Count, maxQuestionsPerPage);
            PDFMaker.CreateLabelTable(labelQuestions, pages);
            PDFMaker.SaveAndSendPdfFile(NameText.Text, DateText.Text);
        }

        private void CheckAllAnswers()
        {
            AnswerChecker.CheckLabelQuestions(labelQuestions);
        }

        private List<int> CalculateTotalQuestionsPerPage(int totalQuestions, int maxQuestionsPerPage)
        {
            int numberOfWholePages = totalQuestions / maxQuestionsPerPage;
            int remainder = totalQuestions % maxQuestionsPerPage;

            List<int> pages = new();
            for (int i = 0; i < numberOfWholePages; i++)
            {
                pages.Add(maxQuestionsPerPage);
            }
            if (remainder > 0) pages.Add(remainder);

            return pages;
        }

        private List<QuestionControl> CollectAllMultipleChoiceAndOpenQuestions(List<Page> pages)
        {
            List<QuestionControl> questions = new();
            foreach (Page page in pages)
            {
                foreach (QuestionControl question in page.questions)
                {
                    if (question is MultipleChoiceQuestion || question is OpenQuestion)
                        questions.Add(question);
                }
            }
            return questions;
        }

        private List<LabelQuestion> CollectLabelQuestions(List<Page> pages)
        {
            List<LabelQuestion> labelQuestions = new();
            foreach (Page page in pages)
            {
                foreach (QuestionControl questionControl in page.questions)
                {
                    if (questionControl is LabelQuestion lq)
                        labelQuestions.Add(lq);
                }
            }
            return labelQuestions;
        }
    }
}