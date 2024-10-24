namespace ADR_Cursus
{
    partial class ADRcursus
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Next = new Button();
            pageContainer = new Panel();
            SuspendLayout();
            // 
            // Next
            // 
            Next.Anchor = AnchorStyles.Bottom;
            Next.Enabled = false;
            Next.Location = new Point(495, 541);
            Next.Name = "Next";
            Next.Size = new Size(75, 23);
            Next.TabIndex = 5;
            Next.Text = ">";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // pageContainer
            // 
            pageContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pageContainer.Location = new Point(12, 12);
            pageContainer.Name = "pageContainer";
            pageContainer.Size = new Size(1036, 523);
            pageContainer.TabIndex = 6;
            // 
            // ADRcursus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 576);
            Controls.Add(pageContainer);
            Controls.Add(Next);
            Name = "ADRcursus";
            Text = "ADR Cursus";
            ResumeLayout(false);
        }

        #endregion
        private Button Next;
        private Panel pageContainer;
    }
}
