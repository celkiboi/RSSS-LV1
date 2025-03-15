namespace RSSS_LV1
{
    partial class ResultForm
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
            AllResultsTextBox = new TextBox();
            CriticalValueResultsTextBox = new TextBox();
            AllResultsLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // AllResultsTextBox
            // 
            AllResultsTextBox.Location = new Point(54, 80);
            AllResultsTextBox.Multiline = true;
            AllResultsTextBox.Name = "AllResultsTextBox";
            AllResultsTextBox.ReadOnly = true;
            AllResultsTextBox.ScrollBars = ScrollBars.Vertical;
            AllResultsTextBox.Size = new Size(315, 282);
            AllResultsTextBox.TabIndex = 0;
            // 
            // CriticalValueResultsTextBox
            // 
            CriticalValueResultsTextBox.Location = new Point(435, 80);
            CriticalValueResultsTextBox.Multiline = true;
            CriticalValueResultsTextBox.Name = "CriticalValueResultsTextBox";
            CriticalValueResultsTextBox.ReadOnly = true;
            CriticalValueResultsTextBox.ScrollBars = ScrollBars.Vertical;
            CriticalValueResultsTextBox.Size = new Size(315, 282);
            CriticalValueResultsTextBox.TabIndex = 1;
            // 
            // AllResultsLabel
            // 
            AllResultsLabel.AutoSize = true;
            AllResultsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllResultsLabel.Location = new Point(54, 56);
            AllResultsLabel.Name = "AllResultsLabel";
            AllResultsLabel.Size = new Size(78, 21);
            AllResultsLabel.TabIndex = 2;
            AllResultsLabel.Text = "All results";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(435, 56);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 3;
            label1.Text = "Results >= critical value";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(AllResultsLabel);
            Controls.Add(CriticalValueResultsTextBox);
            Controls.Add(AllResultsTextBox);
            Name = "ResultForm";
            Text = "ResultForm";
            FormClosing += ResultForm_Closing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AllResultsTextBox;
        private TextBox CriticalValueResultsTextBox;
        private Label AllResultsLabel;
        private Label label1;
    }
}