using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using PdfSharpCore.Drawing.Layout;

namespace ADR_Cursus
{
    public static class PDFMaker
    {
        static PdfDocument document;
        const int pageWidth = 600;
        const int pageHeight = 842;

        static PdfPage pdfPage;
        static XGraphics gfx;

        static XStringFormat format = new()
        {
            LineAlignment = XLineAlignment.Near,
            Alignment = XStringAlignment.Near,
        };
        static XTextFormatter tf;
        static XFont fontParagraph = new("Arial", 12, XFontStyle.Regular);
        static XFont fontParagraph2 = new("Arial", 24, XFontStyle.Bold);

        const int elementWidth2 = 280;

        const int labelElementWidth1 = 50;
        const int labelElementWidth2 = 200;
        const int labelElementWidth3 = 230;

        const int marginLeft = 20;
        const int labelMarginLeft = 60;
        const int labelMarginTop = 20;
        const int labelLineHeight = elementHeight4 + 1;
        const int xOffset1 = labelElementWidth1 + interLineX1;
        const int xOffset2 = xOffset1 + labelElementWidth2 + interLineX1;

        const int elementHeight1 = 30;
        const int elementHeight2 = 90;
        const int elementHeight3 = 20;
        const int elementHeight4 = 50;

        const int lineHeight = elementHeight2 + 1;
        const int interLineX1 = 1;


        static XSolidBrush rectStyle1 = new(XColors.White);
        static XSolidBrush rectStyle2 = new(XColors.Black);
        const int offSetX = elementWidth2 + 1;
        const int marginLeftHeader = marginLeft + 5;        

        const int marginLeft1 = 20;
        const int marginLeft2 = marginLeft1 + elementWidth2 + 1;


        const int marginLeftQuestion = marginLeft + 5;
        const int elementContentWidth2 = elementWidth2 - 5;
        const int marginLeftAnswer = marginLeftQuestion + elementWidth2 + 6;
        public static void CreatePDFdocument()
        {
            document = new();
        }

        public static void SaveAndSendPdfFile(string name, string date)
        {
            MemoryStream stream = new();
            document.Save(stream);            
            stream.Position = 0;
            Mailer.Send(stream, name, date);
            document.Close();
        }

        public static void CreateQuestionTable(List<QuestionControl> questions, List<int> pages, string name, string date)
        {
            int questionsIndex = 0;
            for (int p = 0; p < pages.Count; p++)
            {
                pdfPage = CreateNewPdfPage(pageWidth, pageHeight);
                gfx = XGraphics.FromPdfPage(pdfPage);
                tf = new(gfx);
                int marginTop = 20;
                if (p == 0)
                {
                    DrawCandidateInfo(marginTop, name, date);
                    marginTop = 80;
                }
                else
                {
                    marginTop = 20;
                }
                int questionsPerPage = pages[p];
                int marginTopHeader = marginTop + 2;
                
                DrawTableOutlines(marginTop, questionsPerPage);
                DrawHeaderRow(marginTop);
                DrawHeaderString(marginTopHeader);

                for (int i = 0; i < questionsPerPage; i++)
                {
                    int distY = 21 + lineHeight * i + marginTop;
                    int marginTopQuestion = distY + 2;
                    int marginTopAnswer = marginTopQuestion;
                    int questionNum = questionsIndex + 1;

                    DrawTableRow(distY);

                    QuestionControl question = questions[questionsIndex];
                    DrawQuestion(question, questionNum, marginTopQuestion, marginTopAnswer);
                    
                    questionsIndex++;
                }
            }
        }

        public static void CreateLabelTable(List<LabelQuestion> questions, List<int> pages)
        {
            int questionIndex = 0;
            for (int p = 0; p < pages.Count; p++)
            {
                pdfPage = CreateNewPdfPage(pageWidth, pageHeight);
                gfx = XGraphics.FromPdfPage(pdfPage);
                tf = new(gfx);

                int questionsPerPage = pages[p];

                DrawLabelTableOutlines(questionsPerPage);
                DrawLabelHeader();
                DrawLabelHeaderString();

                for (int i = 0; i < questionsPerPage; i++)
                {
                    int distY = 21 + labelLineHeight * i;

                    LabelQuestion question = questions[questionIndex];
                    DrawLabelRow(distY);
                    DrawLabelRowString(question, distY);
                    questionIndex++;
                }
            }
        }
        
        private static void DrawQuestion(QuestionControl question, int questionNum, int marginTopQuestion, int marginTopAnswer)
        {
            if(question is MultipleChoiceQuestion mq)
                DrawMultipleChoiceQuestion(mq, questionNum, marginTopQuestion, marginTopAnswer);
            else if (question is OpenQuestion oq)
                DrawOpenQuestion(oq, questionNum, marginTopQuestion, marginTopAnswer);                 
        }

        private static void DrawLabelTableOutlines(int questionsPerPage)
        {
            gfx.DrawRectangle(rectStyle2, labelMarginLeft - 1, labelMarginTop - 1, xOffset2 + labelElementWidth3 + 2, elementHeight3 + (elementHeight4 * questionsPerPage) + (questionsPerPage + 2));
        }

        private static void DrawTableOutlines(int marginTop, int questionsPerPage)
        {
            gfx.DrawRectangle(rectStyle2, marginLeft - 1, marginTop - 1, elementWidth2 * 2 + interLineX1 + 2, elementHeight3 + elementHeight2 * questionsPerPage + (questionsPerPage + 2));
        }
        
        private static void DrawLabelRowString(LabelQuestion question, int distY)
        {
            XBrush labelNumberColor = XBrushes.Black;
            if(question.LabelNumberShouldBeFilled)
                labelNumberColor = (question.hasLabelNumberCorrect)? XBrushes.Green : XBrushes.Red;

            XBrush labelDescColor = (question.LabelNumberShouldBeFilled)? XBrushes.Blue: XBrushes.Black;

            DrawLabelNumber(distY, question, labelNumberColor);
            DrawLabelDescription(distY, question, labelDescColor);
            DrawLabelImages(distY, question);
        }
        
        private static void DrawImage(System.Drawing.Image image, int x, int y, int width, int height)
        {
            MemoryStream strm = new();
            image.Save(strm, System.Drawing.Imaging.ImageFormat.Png);
            strm.Position = 0;
            XImage xImage = XImage.FromStream(()=>strm);

            gfx.DrawImage(xImage, x, y, width, height);
            strm.Close();
        }
        
        private static void DrawLabelImages(int distY, LabelQuestion question)
        {
            int imagesDrawn = 0;
            foreach(LabelImagePictureBox image in question.PictureBoxes)
            {
                int dist_X = 45 * imagesDrawn;
                if(image.SelectedImage == null) continue;

                DrawImageBackGroundBox(dist_X + 7, distY + 5, image);
                DrawImage(image.SelectedImage, labelMarginLeft + xOffset2 + dist_X + 7, labelMarginTop + distY + 5, 40, 40);
                imagesDrawn++;
            }
        }

        private static void DrawImageBackGroundBox(int distX, int distY, LabelImagePictureBox image)
        {
            XSolidBrush image_rect_style = rectStyle1;
            if (image.ShouldBeFilled)
                image_rect_style = image.isCorrectImage? new(XColors.Green): new(XColors.Red);

            gfx.DrawRectangle(image_rect_style, labelMarginLeft + xOffset2 + distX, labelMarginTop + distY, 40, 40);
        }

        private static void DrawLabelDescription(int distY, LabelQuestion question, XBrush color)
        {
            tf.DrawString(
                question.Labeldesc,
                fontParagraph,
                color,
                new XRect(labelMarginLeft + xOffset1 + interLineX1 + 5, labelMarginTop + distY + 2, labelElementWidth2 - 4, elementHeight1 + 12),
                format);
        }

        private static void DrawLabelNumber(int distY, LabelQuestion question, XBrush color)
        {
            tf.DrawString(
                question.Labelnumber,
                fontParagraph2,
                color,
                new XRect(labelMarginLeft + 5, labelMarginTop + distY + 10, labelElementWidth1 - 4, elementHeight1),
                format);
        }

        private static void DrawLabelRow(int distY)
        {
            gfx.DrawRectangle(rectStyle1, labelMarginLeft, distY + labelMarginTop, labelElementWidth1, elementHeight4);
            gfx.DrawRectangle(rectStyle1, labelMarginLeft + xOffset1, distY + labelMarginTop, labelElementWidth2, elementHeight4);            
            gfx.DrawRectangle(rectStyle1, labelMarginLeft + xOffset2, distY + labelMarginTop, labelElementWidth3, elementHeight4);            
        }

        private static void DrawLabelHeaderString()
        {
            tf.DrawString("Klasse", fontParagraph, XBrushes.Black,
                            new XRect(labelMarginLeft + 5, labelMarginTop + 2, labelElementWidth1, elementHeight1), format);

            tf.DrawString("Omschrijving", fontParagraph, XBrushes.Black,
                            new XRect(labelMarginLeft + xOffset1 + interLineX1 + 5, labelMarginTop + 2, labelElementWidth2, elementHeight1), format);

            tf.DrawString("Gevaar etiketten", fontParagraph, XBrushes.Black,
                            new XRect(labelMarginLeft + xOffset2 + interLineX1 + 7, labelMarginTop + 2, labelElementWidth3, elementHeight1), format);
        }

        private static void DrawLabelHeader()
        {
            gfx.DrawRectangle(rectStyle1, labelMarginLeft, labelMarginTop, labelElementWidth1, elementHeight3);
            gfx.DrawRectangle(rectStyle1, labelMarginLeft + xOffset1, labelMarginTop, labelElementWidth2, elementHeight3);
            gfx.DrawRectangle(rectStyle1, labelMarginLeft + xOffset2, labelMarginTop, labelElementWidth3, elementHeight3);
        }

        private static void DrawOpenQuestion(OpenQuestion oq, int questionNum, int marginTopQuestion, int marginTopAnswer)
        {
            string question = oq.QuestionText;
            DrawQuestionString(questionNum, question, marginTopQuestion);

            List<string> answers = [oq.AnswerText];
            DrawAnswers(answers, marginTopAnswer);            
        }

        private static void DrawMultipleChoiceQuestion(MultipleChoiceQuestion mq, int questionNum, int marginTopQuestion, int marginTopAnswer)
        {
            string question = mq.QuestionText;
            DrawQuestionString(questionNum, question, marginTopQuestion);
            
            List<string> answers = mq.Answers;
            DrawAnswers(answers, marginTopAnswer, mq.SelectedAnswer);           
        }

        private static void DrawCandidateInfo(int marginTop, string name, string date)
        {
            XFont headFont = new("Arial", 20, XFontStyle.Bold);
            string kandidaat = "Kandidaat: " + name;
            tf.DrawString(kandidaat, headFont, XBrushes.Black,
                        new XRect(marginLeft + 5, marginTop + 2, pdfPage.Width, elementHeight1), format);

            string geboortedatum = "Geboortedatum: " + date;
            tf.DrawString(geboortedatum, headFont, XBrushes.Black,
                        new XRect(marginLeft + 5, marginTop + 24, pdfPage.Width, elementHeight1), format);           
        }

        private static void DrawHeaderString(int marginTopHeader)
        {
            tf.DrawString("Vragen", fontParagraph, XBrushes.Black,
                            new XRect(marginLeftHeader, marginTopHeader, elementWidth2, elementHeight1), format);
                
            tf.DrawString("Antwoorden", fontParagraph, XBrushes.Black,
                            new XRect(marginLeftHeader + offSetX, marginTopHeader, elementWidth2, elementHeight1), format);
        }

        private static void DrawHeaderRow(int marginTop)
        {
            gfx.DrawRectangle(rectStyle1, marginLeft, marginTop, elementWidth2, elementHeight3);
            gfx.DrawRectangle(rectStyle1, marginLeft + offSetX, marginTop, elementWidth2, elementHeight3);
        }

        private static void DrawAnswers(List<string> answers, int marginTopAnswer, MultipleChoiceAnswerRadioButton selectedAnswer)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                string answer = answers[i];
                XBrush color = XBrushes.Black;
                if(answer == selectedAnswer.Text)
                    color = (selectedAnswer.IsCorrectAnswer) ? XBrushes.Green : XBrushes.Red;
                DrawAnswerString(answer, marginTopAnswer + (i * 27), color);
            }
        }

        private static void DrawAnswers(List<string> answers, int marginTopAnswer)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                string answer = answers[i];
                DrawAnswerString(answer, marginTopAnswer + (i * 27), XBrushes.Blue);
            }
        }

        private static void DrawAnswerString(string answer, int marginTopAnswer, XBrush color)
        {
            tf.DrawString(
                answer,
                fontParagraph,
                color,
                new XRect(marginLeftAnswer, marginTopAnswer, elementContentWidth2, elementHeight1),
                format);            
        }

        private static void DrawQuestionString(int questionNum, string question, int marginTopQuestion)
        {
            tf.DrawString(
                questionNum + ") " + question,
                fontParagraph,
                XBrushes.Black,
                new XRect(marginLeftQuestion, marginTopQuestion, elementContentWidth2, elementHeight1),
                format);
        }

        private static void DrawTableRow(int distY)
        {
            gfx.DrawRectangle(rectStyle1, marginLeft, distY, elementWidth2, elementHeight2);
            gfx.DrawRectangle(rectStyle1, marginLeft2, distY, elementWidth2, elementHeight2);
        }

        private static PdfPage CreateNewPdfPage(int width, int height)
        {
            PdfPage pdfPage = document.AddPage();
            pdfPage.Height = height;
            pdfPage.Width = width;
            return pdfPage;
        }
    }
}