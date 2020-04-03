namespace TimeOClock
{
    partial class FormDomain
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
            this.clockInButton = new System.Windows.Forms.Button();
            this.clockOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.requestPtoFromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Time = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.requestPtoToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ptoDetails = new System.Windows.Forms.LinkLabel();
            this.requestPTOLable = new System.Windows.Forms.Label();
            this.ptoButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.timeMonthTextBox = new System.Windows.Forms.TextBox();
            this.timeMonthLabel = new System.Windows.Forms.Label();
            this.timeDayLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.currentTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.labelCalendarReminder = new System.Windows.Forms.LinkLabel();
            this.commentsTextBox = new System.Windows.Forms.RichTextBox();
            this.concernLabel = new System.Windows.Forms.Label();
            this.concernsSubmitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.payGroupBox = new System.Windows.Forms.GroupBox();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.payLabel = new System.Windows.Forms.Label();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.ForgotToClockLabelLink = new System.Windows.Forms.LinkLabel();
            this.formDomanErrorLabel = new System.Windows.Forms.Label();
            this.adminSettingsButton = new System.Windows.Forms.Button();
            this.Time.SuspendLayout();
            this.timeGroupBox.SuspendLayout();
            this.currentTimeGroupBox.SuspendLayout();
            this.payGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockInButton
            // 
            this.clockInButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.clockInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInButton.Location = new System.Drawing.Point(12, 21);
            this.clockInButton.Margin = new System.Windows.Forms.Padding(2);
            this.clockInButton.Name = "clockInButton";
            this.clockInButton.Size = new System.Drawing.Size(177, 77);
            this.clockInButton.TabIndex = 0;
            this.clockInButton.Text = "Clock In";
            this.clockInButton.UseVisualStyleBackColor = false;
            this.clockInButton.Click += new System.EventHandler(this.clockInButton_Click);
            // 
            // clockOutButton
            // 
            this.clockOutButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.clockOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockOutButton.Location = new System.Drawing.Point(12, 102);
            this.clockOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.clockOutButton.Name = "clockOutButton";
            this.clockOutButton.Size = new System.Drawing.Size(177, 78);
            this.clockOutButton.TabIndex = 1;
            this.clockOutButton.Text = "Clock Out";
            this.clockOutButton.UseVisualStyleBackColor = false;
            this.clockOutButton.Click += new System.EventHandler(this.clockOutButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            // 
            // requestPtoFromTimePicker
            // 
            this.requestPtoFromTimePicker.Location = new System.Drawing.Point(4, 77);
            this.requestPtoFromTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.requestPtoFromTimePicker.Name = "requestPtoFromTimePicker";
            this.requestPtoFromTimePicker.Size = new System.Drawing.Size(222, 23);
            this.requestPtoFromTimePicker.TabIndex = 2;
            this.requestPtoFromTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Time
            // 
            this.Time.Controls.Add(this.label2);
            this.Time.Controls.Add(this.requestPtoToTimePicker);
            this.Time.Controls.Add(this.ptoDetails);
            this.Time.Controls.Add(this.requestPTOLable);
            this.Time.Controls.Add(this.requestPtoFromTimePicker);
            this.Time.Location = new System.Drawing.Point(11, 197);
            this.Time.Margin = new System.Windows.Forms.Padding(2);
            this.Time.Name = "Time";
            this.Time.Padding = new System.Windows.Forms.Padding(2);
            this.Time.Size = new System.Drawing.Size(243, 161);
            this.Time.TabIndex = 3;
            this.Time.TabStop = false;
            this.Time.Text = "Vacation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // requestPtoToTimePicker
            // 
            this.requestPtoToTimePicker.Location = new System.Drawing.Point(4, 130);
            this.requestPtoToTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.requestPtoToTimePicker.Name = "requestPtoToTimePicker";
            this.requestPtoToTimePicker.Size = new System.Drawing.Size(222, 23);
            this.requestPtoToTimePicker.TabIndex = 6;
            // 
            // ptoDetails
            // 
            this.ptoDetails.AutoSize = true;
            this.ptoDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptoDetails.Location = new System.Drawing.Point(6, 19);
            this.ptoDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ptoDetails.Name = "ptoDetails";
            this.ptoDetails.Size = new System.Drawing.Size(84, 17);
            this.ptoDetails.TabIndex = 5;
            this.ptoDetails.TabStop = true;
            this.ptoDetails.Text = "View Details";
            this.ptoDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ptoDetails_LinkClicked);
            // 
            // requestPTOLable
            // 
            this.requestPTOLable.AutoSize = true;
            this.requestPTOLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestPTOLable.Location = new System.Drawing.Point(1, 51);
            this.requestPTOLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.requestPTOLable.Name = "requestPTOLable";
            this.requestPTOLable.Size = new System.Drawing.Size(140, 17);
            this.requestPTOLable.TabIndex = 4;
            this.requestPTOLable.Text = "Request PTO (From)";
            // 
            // ptoButton
            // 
            this.ptoButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ptoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ptoButton.Location = new System.Drawing.Point(12, 360);
            this.ptoButton.Margin = new System.Windows.Forms.Padding(2);
            this.ptoButton.Name = "ptoButton";
            this.ptoButton.Size = new System.Drawing.Size(242, 35);
            this.ptoButton.TabIndex = 6;
            this.ptoButton.Text = "Submit";
            this.ptoButton.UseVisualStyleBackColor = false;
            this.ptoButton.Click += new System.EventHandler(this.ptoButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(87, 23);
            this.textBox1.TabIndex = 5;
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.Controls.Add(this.timeMonthTextBox);
            this.timeGroupBox.Controls.Add(this.timeMonthLabel);
            this.timeGroupBox.Controls.Add(this.timeDayLabel);
            this.timeGroupBox.Controls.Add(this.textBox2);
            this.timeGroupBox.Controls.Add(this.timeLabel);
            this.timeGroupBox.Controls.Add(this.textBox1);
            this.timeGroupBox.Location = new System.Drawing.Point(258, 197);
            this.timeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.timeGroupBox.Size = new System.Drawing.Size(198, 160);
            this.timeGroupBox.TabIndex = 7;
            this.timeGroupBox.TabStop = false;
            this.timeGroupBox.Text = "Time";
            // 
            // timeMonthTextBox
            // 
            this.timeMonthTextBox.Location = new System.Drawing.Point(108, 127);
            this.timeMonthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeMonthTextBox.Name = "timeMonthTextBox";
            this.timeMonthTextBox.ReadOnly = true;
            this.timeMonthTextBox.Size = new System.Drawing.Size(86, 23);
            this.timeMonthTextBox.TabIndex = 10;
            // 
            // timeMonthLabel
            // 
            this.timeMonthLabel.AutoSize = true;
            this.timeMonthLabel.Location = new System.Drawing.Point(6, 130);
            this.timeMonthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeMonthLabel.Name = "timeMonthLabel";
            this.timeMonthLabel.Size = new System.Drawing.Size(99, 17);
            this.timeMonthLabel.TabIndex = 9;
            this.timeMonthLabel.Text = "Hours (Month)";
            // 
            // timeDayLabel
            // 
            this.timeDayLabel.AutoSize = true;
            this.timeDayLabel.Location = new System.Drawing.Point(6, 38);
            this.timeDayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeDayLabel.Name = "timeDayLabel";
            this.timeDayLabel.Size = new System.Drawing.Size(85, 17);
            this.timeDayLabel.TabIndex = 8;
            this.timeDayLabel.Text = "Hours (Day)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(87, 23);
            this.textBox2.TabIndex = 7;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(6, 83);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(96, 17);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Hours (Week)";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.Location = new System.Drawing.Point(17, 54);
            this.currentTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(53, 24);
            this.currentTimeLabel.TabIndex = 8;
            this.currentTimeLabel.Text = "Time";
            this.currentTimeLabel.Click += new System.EventHandler(this.currentTimeLable_Click);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.Location = new System.Drawing.Point(17, 18);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(48, 24);
            this.currentDateLabel.TabIndex = 9;
            this.currentDateLabel.Text = "Date";
            this.currentDateLabel.Click += new System.EventHandler(this.currentDateLabel_Click);
            // 
            // currentTimeGroupBox
            // 
            this.currentTimeGroupBox.Controls.Add(this.labelCalendarReminder);
            this.currentTimeGroupBox.Controls.Add(this.currentTimeLabel);
            this.currentTimeGroupBox.Controls.Add(this.currentDateLabel);
            this.currentTimeGroupBox.Location = new System.Drawing.Point(206, 21);
            this.currentTimeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentTimeGroupBox.Name = "currentTimeGroupBox";
            this.currentTimeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.currentTimeGroupBox.Size = new System.Drawing.Size(339, 125);
            this.currentTimeGroupBox.TabIndex = 10;
            this.currentTimeGroupBox.TabStop = false;
            this.currentTimeGroupBox.Text = "Current Date and Time";
            // 
            // labelCalendarReminder
            // 
            this.labelCalendarReminder.AutoSize = true;
            this.labelCalendarReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalendarReminder.Location = new System.Drawing.Point(18, 90);
            this.labelCalendarReminder.Name = "labelCalendarReminder";
            this.labelCalendarReminder.Size = new System.Drawing.Size(164, 18);
            this.labelCalendarReminder.TabIndex = 10;
            this.labelCalendarReminder.TabStop = true;
            this.labelCalendarReminder.Text = "Add Calendar Reminder";
            this.labelCalendarReminder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelCalendarReminder_LinkClicked);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox.Location = new System.Drawing.Point(460, 207);
            this.commentsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(283, 151);
            this.commentsTextBox.TabIndex = 10;
            this.commentsTextBox.Text = "Dear Manager,";
            // 
            // concernLabel
            // 
            this.concernLabel.AutoSize = true;
            this.concernLabel.Location = new System.Drawing.Point(460, 188);
            this.concernLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.concernLabel.Name = "concernLabel";
            this.concernLabel.Size = new System.Drawing.Size(159, 17);
            this.concernLabel.TabIndex = 12;
            this.concernLabel.Text = "Comments or Concerns:";
            // 
            // concernsSubmitButton
            // 
            this.concernsSubmitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.concernsSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concernsSubmitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.concernsSubmitButton.Location = new System.Drawing.Point(609, 362);
            this.concernsSubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.concernsSubmitButton.Name = "concernsSubmitButton";
            this.concernsSubmitButton.Size = new System.Drawing.Size(134, 34);
            this.concernsSubmitButton.TabIndex = 13;
            this.concernsSubmitButton.Text = "Submit";
            this.concernsSubmitButton.UseVisualStyleBackColor = false;
            this.concernsSubmitButton.Click += new System.EventHandler(this.concernsSubmitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LimeGreen;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(12, 415);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 32);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // payGroupBox
            // 
            this.payGroupBox.Controls.Add(this.payTextBox);
            this.payGroupBox.Controls.Add(this.payLabel);
            this.payGroupBox.Location = new System.Drawing.Point(550, 21);
            this.payGroupBox.Name = "payGroupBox";
            this.payGroupBox.Size = new System.Drawing.Size(193, 94);
            this.payGroupBox.TabIndex = 15;
            this.payGroupBox.TabStop = false;
            this.payGroupBox.Text = "Salary";
            // 
            // payTextBox
            // 
            this.payTextBox.Location = new System.Drawing.Point(26, 54);
            this.payTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.ReadOnly = true;
            this.payTextBox.Size = new System.Drawing.Size(142, 23);
            this.payTextBox.TabIndex = 6;
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payLabel.Location = new System.Drawing.Point(74, 24);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(35, 20);
            this.payLabel.TabIndex = 0;
            this.payLabel.Text = "Pay";
            // 
            // clearTextButton
            // 
            this.clearTextButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.clearTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTextButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearTextButton.Location = new System.Drawing.Point(460, 362);
            this.clearTextButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.Size = new System.Drawing.Size(145, 34);
            this.clearTextButton.TabIndex = 16;
            this.clearTextButton.Text = "Clear";
            this.clearTextButton.UseVisualStyleBackColor = false;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // ForgotToClockLabelLink
            // 
            this.ForgotToClockLabelLink.AutoSize = true;
            this.ForgotToClockLabelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotToClockLabelLink.Location = new System.Drawing.Point(202, 148);
            this.ForgotToClockLabelLink.Name = "ForgotToClockLabelLink";
            this.ForgotToClockLabelLink.Size = new System.Drawing.Size(126, 20);
            this.ForgotToClockLabelLink.TabIndex = 18;
            this.ForgotToClockLabelLink.TabStop = true;
            this.ForgotToClockLabelLink.Text = "Forgot to Clock?";
            this.ForgotToClockLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotToClockLabelLink_LinkClicked);
            // 
            // formDomanErrorLabel
            // 
            this.formDomanErrorLabel.AutoSize = true;
            this.formDomanErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.formDomanErrorLabel.Location = new System.Drawing.Point(117, 423);
            this.formDomanErrorLabel.Name = "formDomanErrorLabel";
            this.formDomanErrorLabel.Size = new System.Drawing.Size(51, 17);
            this.formDomanErrorLabel.TabIndex = 19;
            this.formDomanErrorLabel.Text = "Errors:";
            // 
            // adminSettingsButton
            // 
            this.adminSettingsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.adminSettingsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminSettingsButton.Location = new System.Drawing.Point(550, 121);
            this.adminSettingsButton.Name = "adminSettingsButton";
            this.adminSettingsButton.Size = new System.Drawing.Size(193, 25);
            this.adminSettingsButton.TabIndex = 20;
            this.adminSettingsButton.Text = "Admin View";
            this.adminSettingsButton.UseVisualStyleBackColor = false;
            this.adminSettingsButton.Click += new System.EventHandler(this.adminSettingsButton_Click);
            // 
            // FormDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(755, 454);
            this.Controls.Add(this.adminSettingsButton);
            this.Controls.Add(this.formDomanErrorLabel);
            this.Controls.Add(this.ForgotToClockLabelLink);
            this.Controls.Add(this.clearTextButton);
            this.Controls.Add(this.payGroupBox);
            this.Controls.Add(this.ptoButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.concernsSubmitButton);
            this.Controls.Add(this.concernLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.currentTimeGroupBox);
            this.Controls.Add(this.timeGroupBox);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clockOutButton);
            this.Controls.Add(this.clockInButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormDomain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.FormDomain_Load);
            this.Time.ResumeLayout(false);
            this.Time.PerformLayout();
            this.timeGroupBox.ResumeLayout(false);
            this.timeGroupBox.PerformLayout();
            this.currentTimeGroupBox.ResumeLayout(false);
            this.currentTimeGroupBox.PerformLayout();
            this.payGroupBox.ResumeLayout(false);
            this.payGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button clockInButton;
        public System.Windows.Forms.Button clockOutButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker requestPtoFromTimePicker;
        private System.Windows.Forms.GroupBox Time;
        private System.Windows.Forms.Label requestPTOLable;
        public System.Windows.Forms.Button ptoButton;
        private System.Windows.Forms.LinkLabel ptoDetails;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox timeGroupBox;
        private System.Windows.Forms.Label timeDayLabel;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeMonthLabel;
        public System.Windows.Forms.TextBox timeMonthTextBox;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label currentDateLabel;
        public System.Windows.Forms.GroupBox currentTimeGroupBox;
        public System.Windows.Forms.RichTextBox commentsTextBox;
        private System.Windows.Forms.Label concernLabel;
        private System.Windows.Forms.Button concernsSubmitButton;
        public System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker requestPtoToTimePicker;
        private System.Windows.Forms.GroupBox payGroupBox;
        private System.Windows.Forms.Label payLabel;
        public System.Windows.Forms.TextBox payTextBox;
        public System.Windows.Forms.Button clearTextButton;
        private System.Windows.Forms.LinkLabel ForgotToClockLabelLink;
        private System.Windows.Forms.Label formDomanErrorLabel;
        private System.Windows.Forms.Button adminSettingsButton;
        private System.Windows.Forms.LinkLabel labelCalendarReminder;
    }
}