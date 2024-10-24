namespace ADR_Cursus
{
    partial class LabelQuestion
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
            LabelDesc = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LabelNumber = new TextBox();
            image1 = new LabelImagePictureBox();
            image2 = new LabelImagePictureBox();
            image3 = new LabelImagePictureBox();
            image4 = new LabelImagePictureBox();
            image5 = new LabelImagePictureBox();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image5).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // LabelDesc
            // 
            LabelDesc.BackColor = SystemColors.HighlightText;
            LabelDesc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDesc.Location = new Point(66, 3);
            LabelDesc.MaxLength = 50;
            LabelDesc.Multiline = true;
            LabelDesc.Name = "LabelDesc";
            LabelDesc.PlaceholderText = "Beschrijving";
            LabelDesc.Size = new Size(258, 57);
            LabelDesc.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 15);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 2);
            panel1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(LabelNumber);
            flowLayoutPanel1.Controls.Add(LabelDesc);
            flowLayoutPanel1.Controls.Add(image1);
            flowLayoutPanel1.Controls.Add(image2);
            flowLayoutPanel1.Controls.Add(image3);
            flowLayoutPanel1.Controls.Add(image4);
            flowLayoutPanel1.Controls.Add(image5);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 54);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(643, 78);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // LabelNumber
            // 
            LabelNumber.BackColor = SystemColors.HighlightText;
            LabelNumber.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            LabelNumber.Location = new Point(3, 3);
            LabelNumber.MaxLength = 3;
            LabelNumber.Name = "LabelNumber";
            LabelNumber.PlaceholderText = "0.0";
            LabelNumber.Size = new Size(57, 57);
            LabelNumber.TabIndex = 18;
            LabelNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // image1
            // 
            image1.BackColor = SystemColors.Window;
            image1.BorderStyle = BorderStyle.FixedSingle;
            image1.Enabled = false;
            image1.Location = new Point(330, 3);
            image1.Name = "image1";
            image1.Size = new Size(57, 57);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 12;
            image1.TabStop = false;
            image1.Click += GetImage;
            // 
            // image2
            // 
            image2.BackColor = SystemColors.Window;
            image2.BorderStyle = BorderStyle.FixedSingle;
            image2.Enabled = false;
            image2.Location = new Point(393, 3);
            image2.Name = "image2";
            image2.Size = new Size(57, 57);
            image2.SizeMode = PictureBoxSizeMode.Zoom;
            image2.TabIndex = 13;
            image2.TabStop = false;
            image2.Click += GetImage;
            // 
            // image3
            // 
            image3.BackColor = SystemColors.Window;
            image3.BorderStyle = BorderStyle.FixedSingle;
            image3.Enabled = false;
            image3.Location = new Point(456, 3);
            image3.Name = "image3";
            image3.Size = new Size(57, 57);
            image3.SizeMode = PictureBoxSizeMode.Zoom;
            image3.TabIndex = 14;
            image3.TabStop = false;
            image3.Click += GetImage;
            // 
            // image4
            // 
            image4.BackColor = SystemColors.Window;
            image4.BorderStyle = BorderStyle.FixedSingle;
            image4.Enabled = false;
            image4.Location = new Point(519, 3);
            image4.Name = "image4";
            image4.Size = new Size(57, 57);
            image4.SizeMode = PictureBoxSizeMode.Zoom;
            image4.TabIndex = 15;
            image4.TabStop = false;
            image4.Click += GetImage;
            // 
            // image5
            // 
            image5.BackColor = SystemColors.Window;
            image5.BorderStyle = BorderStyle.FixedSingle;
            image5.Enabled = false;
            image5.Location = new Point(582, 3);
            image5.Name = "image5";
            image5.Size = new Size(57, 57);
            image5.SizeMode = PictureBoxSizeMode.Zoom;
            image5.TabIndex = 16;
            image5.TabStop = false;
            image5.Click += GetImage;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Location = new Point(0, 13);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 15;
            label4.Text = "*Vul alle gele velden in";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(643, 26);
            panel3.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(330, 2);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 2;
            label3.Text = "Etiketten";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 2);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 1;
            label2.Text = "Naam van de klasse";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Klasse";
            // 
            // LabelQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "LabelQuestion";
            Size = new Size(643, 149);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ((System.ComponentModel.ISupportInitialize)image2).EndInit();
            ((System.ComponentModel.ISupportInitialize)image3).EndInit();
            ((System.ComponentModel.ISupportInitialize)image4).EndInit();
            ((System.ComponentModel.ISupportInitialize)image5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox LabelDesc;
        private Panel panel2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private LabelImagePictureBox image1;
        private LabelImagePictureBox image5;
        private LabelImagePictureBox image2;
        private LabelImagePictureBox image3;
        private LabelImagePictureBox image4;
        private TextBox LabelNumber;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
