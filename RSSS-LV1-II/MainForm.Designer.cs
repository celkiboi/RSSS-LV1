namespace RSSS_LV1_II
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
            HoursDownButton = new Button();
            MinutesDownButton = new Button();
            HoursUpButton = new Button();
            MinutesUpButton = new Button();
            HourLabel = new Label();
            MinuteLabel = new Label();
            SetAlarmButton = new Button();
            AlarmInfoLabel = new Label();
            SuspendLayout();
            // 
            // HoursDownButton
            // 
            HoursDownButton.Location = new Point(266, 174);
            HoursDownButton.Name = "HoursDownButton";
            HoursDownButton.Size = new Size(75, 23);
            HoursDownButton.TabIndex = 0;
            HoursDownButton.Text = "down";
            HoursDownButton.UseVisualStyleBackColor = true;
            HoursDownButton.Click += HoursDownButton_Click;
            // 
            // MinutesDownButton
            // 
            MinutesDownButton.Location = new Point(426, 174);
            MinutesDownButton.Name = "MinutesDownButton";
            MinutesDownButton.Size = new Size(75, 23);
            MinutesDownButton.TabIndex = 1;
            MinutesDownButton.Text = "down";
            MinutesDownButton.UseVisualStyleBackColor = true;
            MinutesDownButton.Click += MinutesDownButton_Click;
            // 
            // HoursUpButton
            // 
            HoursUpButton.Location = new Point(266, 250);
            HoursUpButton.Name = "HoursUpButton";
            HoursUpButton.Size = new Size(75, 23);
            HoursUpButton.TabIndex = 2;
            HoursUpButton.Text = "up";
            HoursUpButton.UseVisualStyleBackColor = true;
            HoursUpButton.Click += HoursUpButton_Click;
            // 
            // MinutesUpButton
            // 
            MinutesUpButton.Location = new Point(426, 250);
            MinutesUpButton.Name = "MinutesUpButton";
            MinutesUpButton.Size = new Size(75, 23);
            MinutesUpButton.TabIndex = 3;
            MinutesUpButton.Text = "up";
            MinutesUpButton.UseVisualStyleBackColor = true;
            MinutesUpButton.Click += MinutesUpButton_Click;
            // 
            // HourLabel
            // 
            HourLabel.AutoSize = true;
            HourLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HourLabel.Location = new Point(291, 214);
            HourLabel.Name = "HourLabel";
            HourLabel.Size = new Size(28, 21);
            HourLabel.TabIndex = 4;
            HourLabel.Text = "00";
            // 
            // MinuteLabel
            // 
            MinuteLabel.AutoSize = true;
            MinuteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinuteLabel.Location = new Point(451, 214);
            MinuteLabel.Name = "MinuteLabel";
            MinuteLabel.Size = new Size(28, 21);
            MinuteLabel.TabIndex = 5;
            MinuteLabel.Text = "00";
            // 
            // SetAlarmButton
            // 
            SetAlarmButton.Location = new Point(328, 311);
            SetAlarmButton.Name = "SetAlarmButton";
            SetAlarmButton.Size = new Size(116, 23);
            SetAlarmButton.TabIndex = 6;
            SetAlarmButton.Text = "Set Alarm";
            SetAlarmButton.UseVisualStyleBackColor = true;
            SetAlarmButton.Click += SetAlarmButton_Click;
            // 
            // AlarmInfoLabel
            // 
            AlarmInfoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AlarmInfoLabel.AutoSize = true;
            AlarmInfoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlarmInfoLabel.Location = new Point(315, 107);
            AlarmInfoLabel.Name = "AlarmInfoLabel";
            AlarmInfoLabel.Size = new Size(146, 25);
            AlarmInfoLabel.TabIndex = 7;
            AlarmInfoLabel.Text = "Set a new alarm";
            AlarmInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AlarmInfoLabel);
            Controls.Add(SetAlarmButton);
            Controls.Add(MinuteLabel);
            Controls.Add(HourLabel);
            Controls.Add(MinutesUpButton);
            Controls.Add(HoursUpButton);
            Controls.Add(MinutesDownButton);
            Controls.Add(HoursDownButton);
            Name = "MainForm";
            Text = "Alarm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HoursDownButton;
        private Button MinutesDownButton;
        private Button HoursUpButton;
        private Button MinutesUpButton;
        private Label HourLabel;
        private Label MinuteLabel;
        private Button SetAlarmButton;
        private Label AlarmInfoLabel;
    }
}
