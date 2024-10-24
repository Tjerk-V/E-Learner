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
    public partial class Labels : Form
    {
        public Image SelectedImage;

        public Labels()
        {
            InitializeComponent();
        }

        void ReturnImage(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            SelectedImage = pictureBox.Image;
            
            DialogResult = DialogResult.OK;
            Close();
        }

        void ChangeBackColorOnMouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.LightGray;
        }
        void ChangeBackColorOnMouseExit(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.WhiteSmoke;
        }
    }
}
