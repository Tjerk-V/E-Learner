namespace ADR_Cursus
{
    partial class OpenQuestion
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
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            QuestionLabel = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(0, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 2);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(0, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 15);
            panel2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(13, 58);
            textBox1.MaxLength = 250;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(576, 113);
            textBox1.TabIndex = 6;
            // 
            // QuestionLabel
            // 
            QuestionLabel.Dock = DockStyle.Top;
            QuestionLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestionLabel.Location = new Point(0, 0);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(608, 58);
            QuestionLabel.TabIndex = 1;
            QuestionLabel.Text = "Question";
            QuestionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OpenQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(QuestionLabel);
            Name = "OpenQuestion";
            Size = new Size(608, 194);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Label QuestionLabel;
    }
}
