using ADR_Cursus.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADR_Cursus
{
    public class LabelImagePictureBox : PictureBox
    {
        public LabelImage labelImage;
        private Image selectedImage;
        public bool isCorrectImage;

        public bool ShouldBeFilled => labelImage.Type == LabelType.ToBeFilled;
        public Image SelectedImage => selectedImage;

        public void SetLabelImage(LabelImage labelImage)
        {
            this.labelImage = labelImage;
            if (labelImage.Type == LabelType.PreFilled)
            {
                SetSelectedImage(LabelImages.GetImageFromName(labelImage.CorrectImage));
            }
            else if (labelImage.Type == LabelType.ToBeFilled)
            {
                BackColor = Color.LightYellow;
                Cursor = Cursors.Hand;
                Enabled = true;
            }
        }

        public void SetSelectedImage(Image image)
        {
            selectedImage = image;
            Image = image;
        }
    }
}
