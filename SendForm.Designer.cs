namespace ADR_Cursus
{
    partial class SendForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            NameText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DateText = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(20, 178);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 0;
            button1.Text = "Inleveren";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SendCursus;
            // 
            // NameText
            // 
            NameText.Anchor = AnchorStyles.None;
            NameText.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameText.Location = new Point(20, 54);
            NameText.Name = "NameText";
            NameText.Size = new Size(200, 35);
            NameText.TabIndex = 1;
            NameText.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 21);
            label1.Name = "label1";
            label1.Size = new Size(218, 33);
            label1.TabIndex = 2;
            label1.Text = "Naam";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 102);
            label2.Name = "label2";
            label2.Size = new Size(218, 33);
            label2.TabIndex = 3;
            label2.Text = "Geboorte datum";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateText
            // 
            DateText.Anchor = AnchorStyles.None;
            DateText.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateText.Format = DateTimePickerFormat.Short;
            DateText.Location = new Point(20, 138);
            DateText.Name = "DateText";
            DateText.RightToLeft = RightToLeft.No;
            DateText.Size = new Size(200, 23);
            DateText.TabIndex = 4;
            // 
            // SendForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 247);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(DateText);
            Controls.Add(button1);
            Controls.Add(NameText);
            Name = "SendForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "SendForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox NameText;
        private Label label1;
        private Label label2;
        private DateTimePicker DateText;
    }
}