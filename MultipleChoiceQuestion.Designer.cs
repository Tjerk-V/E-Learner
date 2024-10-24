namespace ADR_Cursus
{
    partial class MultipleChoiceQuestion
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
            QuestionLabel = new Label();
            answersPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // QuestionLabel
            // 
            QuestionLabel.Dock = DockStyle.Top;
            QuestionLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestionLabel.Location = new Point(0, 0);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(608, 58);
            QuestionLabel.TabIndex = 0;
            QuestionLabel.Text = "Question";
            QuestionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // answersPanel
            // 
            answersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            answersPanel.Location = new Point(0, 58);
            answersPanel.Name = "answersPanel";
            answersPanel.Size = new Size(608, 158);
            answersPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 2);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 15);
            panel2.TabIndex = 3;
            // 
            // MultipleChoiceQuestion
            // 
            Controls.Add(answersPanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(QuestionLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MultipleChoiceQuestion";
            Size = new Size(608, 237);
            ResumeLayout(false);
        }

        #endregion

        private Label QuestionLabel;
        private FlowLayoutPanel answersPanel;
        private Panel panel1;
        private Panel panel2;
    }
}
