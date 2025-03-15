namespace RSSS_LV1
{
    partial class MainForm
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
            nextButton = new Button();
            criticalValueTextBox = new TextBox();
            criticalValueLabel = new Label();
            selectFileButton = new Button();
            selectedFileLabel = new Label();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.None;
            nextButton.Location = new Point(479, 280);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 0;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += NextButton_Click;
            // 
            // criticalValueTextBox
            // 
            criticalValueTextBox.Font = new Font("Segoe UI", 12F);
            criticalValueTextBox.Location = new Point(250, 232);
            criticalValueTextBox.Name = "criticalValueTextBox";
            criticalValueTextBox.Size = new Size(304, 29);
            criticalValueTextBox.TabIndex = 1;
            // 
            // criticalValueLabel
            // 
            criticalValueLabel.AutoSize = true;
            criticalValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            criticalValueLabel.Location = new Point(250, 208);
            criticalValueLabel.Name = "criticalValueLabel";
            criticalValueLabel.Size = new Size(162, 21);
            criticalValueLabel.TabIndex = 3;
            criticalValueLabel.Text = "Enter the critical value";
            // 
            // selectFileButton
            // 
            selectFileButton.Anchor = AnchorStyles.None;
            selectFileButton.Location = new Point(250, 280);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(75, 23);
            selectFileButton.TabIndex = 4;
            selectFileButton.Text = "Select File";
            selectFileButton.UseVisualStyleBackColor = true;
            selectFileButton.Click += SelectFileButton_Click;
            // 
            // selectedFileLabel
            // 
            selectedFileLabel.AutoSize = true;
            selectedFileLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            selectedFileLabel.Location = new Point(250, 317);
            selectedFileLabel.Name = "selectedFileLabel";
            selectedFileLabel.Size = new Size(101, 17);
            selectedFileLabel.TabIndex = 5;
            selectedFileLabel.Text = "No file selected...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectedFileLabel);
            Controls.Add(selectFileButton);
            Controls.Add(criticalValueLabel);
            Controls.Add(criticalValueTextBox);
            Controls.Add(nextButton);
            Name = "MainForm";
            Text = "RSSS - LV1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private TextBox criticalValueTextBox;
        private Label criticalValueLabel;
        private Button selectFileButton;
        private Label selectedFileLabel;
    }
}
