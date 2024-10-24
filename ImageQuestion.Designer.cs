namespace ADR_Cursus
{
    partial class ImageQuestion
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TopText = new Label();
            BottomText = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TopText
            // 
            TopText.Dock = DockStyle.Top;
            TopText.Font = new Font("Segoe UI", 12F);
            TopText.Location = new Point(0, 0);
            TopText.Name = "TopText";
            TopText.Size = new Size(968, 21);
            TopText.TabIndex = 1;
            TopText.Text = "label1";
            // 
            // BottomText
            // 
            BottomText.Dock = DockStyle.Top;
            BottomText.Font = new Font("Segoe UI", 12F);
            BottomText.Location = new Point(0, 21);
            BottomText.Name = "BottomText";
            BottomText.Size = new Size(968, 21);
            BottomText.TabIndex = 2;
            BottomText.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(968, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.SizeChanged += ChangePictureBoxSize;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(BottomText);
            panel1.Controls.Add(TopText);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 500);
            panel1.TabIndex = 1;
            // 
            // ImageQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ImageQuestion";
            Size = new Size(968, 500);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label TopText;
        private Label BottomText;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
