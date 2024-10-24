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
    public partial class ImageQuestion : UserControl
    {
        Bitmap bmp;
        public ImageQuestion(ImageQuestionData id)
        {
            InitializeComponent();
            bmp = new(Image.FromFile(id.Filename));
            pictureBox1.Image = bmp;
            pictureBox1.MaximumSize = new Size(id.MaxSize, id.MaxSize);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.SendToBack();
            TopText.SendToBack();
            TopText.Text = id.TopText;
            BottomText.Text = id.BottomText;

        }

        private void ChangePictureBoxSize(object sender, EventArgs e)
        {

            float scaleFactor = (float)pictureBox1.Width / (float)bmp.Width;
            float newHeight = (float)bmp.Height * scaleFactor;
            pictureBox1.Height = (int)(newHeight * 0.75f);
            Height = pictureBox1.Height + 20;
            panel1.Height = Height;
        }
    }
}
