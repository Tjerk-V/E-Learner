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
    public partial class LabelQuestion : QuestionControl
    {
        Labels labels;
        public LabelQuestionData QuestionData;
        public EventHandler AnswerChanged;
        public bool hasLabelNumberCorrect;
        public bool hasLabelImagesCorrect;
        public bool LabelNumberShouldBeFilled { get => !LabelNumber.ReadOnly; }
        public bool LabelDescShouldBeFilled { get => !LabelDesc.ReadOnly; }
        public string Labelnumber { get => LabelNumber.Text; }
        public string Labeldesc { get => LabelDesc.Text; }      
        public List<LabelImage> LabelImages { get; private set; }
        public override bool HasAnswer =>
                PictureBoxes.Where(i => i.labelImage != null && i.ShouldBeFilled)
                            .All(i => i.Image != null)
             && LabelDesc.Text.Replace(" ", "") != ""
             && LabelNumber.Text.Replace(" ", "") != "";

        public IEnumerable<LabelImagePictureBox> PictureBoxes => new List<LabelImagePictureBox>()
        {
            image1,
            image2,
            image3,
            image4,
            image5,
        };


        public LabelQuestion(LabelQuestionData q)
        {
            InitializeComponent();
            AddData(q);
            QuestionData = q;
            LabelNumber.TextChanged += (sender, e) =>
            {
                AwnserChanged();
            };
            LabelDesc.TextChanged += (sender, e) =>
            {
                AwnserChanged();
            };
        }

        private void AddData(LabelQuestionData q)
        {
            AddLabelNumber(q.LabelNumber);
            AddLabelDescription(q.LabelDesc);
            AddLabelImages(q.LabelImages);
        }

        private void AddLabelImages(List<LabelImage> labelImages)
        {
            LabelImages = labelImages;
            if (labelImages.Count > 0)
                image1.SetLabelImage(labelImages[0]);
            if (labelImages.Count > 1)
                image2.SetLabelImage(labelImages[1]);
            if (labelImages.Count > 2)
                image3.SetLabelImage(labelImages[2]);
            if (labelImages.Count > 3)
                image4.SetLabelImage(labelImages[3]);
            if (labelImages.Count > 4)
                image5.SetLabelImage(labelImages[4]);
        }

        private void AddLabelDescription(string labelDesc)
        {
            if (labelDesc != null && labelDesc.Replace(" ", "") != "")
            {
                LabelDesc.Text = labelDesc;
                LabelDesc.ReadOnly = true;
            }
            else
                LabelDesc.BackColor = Color.LightYellow;
        }

        private void AddLabelNumber(LabelNumber labelNumber)
        {
            if (labelNumber.Type == LabelType.ToBeFilled)
            {
                LabelNumber.BackColor = Color.LightYellow;
            }
            else
            {
                LabelNumber.ReadOnly = true;
                LabelNumber.Text = labelNumber.CorrectLabelNumber;
            }
        }

        public void GetImage(object sender, EventArgs e)
        {
            labels = new();
            if (labels.ShowDialog(this) == DialogResult.OK)
            {
                LabelImagePictureBox pictureBox = (LabelImagePictureBox)sender;
                pictureBox.SetSelectedImage(labels.SelectedImage);
                AwnserChanged();
            }
        }



        void AwnserChanged()
        {
            AnswerChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
