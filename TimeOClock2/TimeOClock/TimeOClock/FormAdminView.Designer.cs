namespace TimeOClock
{
    partial class FormAdminView
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
            this.ModifyAdminInfoButton = new System.Windows.Forms.Button();
            this.EmployeeEmailGroupBox = new System.Windows.Forms.GroupBox();
            this.enterEmailButton = new System.Windows.Forms.Button();
            this.employeeEmailLabel = new System.Windows.Forms.Label();
            this.employeeEmailTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.HoursGroupBox = new System.Windows.Forms.GroupBox();
            this.clockOutTextBox = new System.Windows.Forms.TextBox();
            this.clockInTextBox = new System.Windows.Forms.TextBox();
            this.hoursWeekTextBox = new System.Windows.Forms.TextBox();
            this.hoursDayTextBox = new System.Windows.Forms.TextBox();
            this.ClockOutLabel = new System.Windows.Forms.Label();
            this.ClockInLabel = new System.Windows.Forms.Label();
            this.weekHoursLabel = new System.Windows.Forms.Label();
            this.dayHoursLabel = new System.Windows.Forms.Label();
            this.employeeCommentsTextBox = new System.Windows.Forms.RichTextBox();
            this.employeeCommentsLabel = new System.Windows.Forms.Label();
            this.vacationGroupBox = new System.Windows.Forms.GroupBox();
            this.VacationBalanceTextBox = new System.Windows.Forms.TextBox();
            this.vacationAccruedTextBox = new System.Windows.Forms.TextBox();
            this.vacationBalanceLabel = new System.Windows.Forms.Label();
            this.vacationAccruedLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.EmployeeEmailGroupBox.SuspendLayout();
            this.HoursGroupBox.SuspendLayout();
            this.vacationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifyAdminInfoButton
            // 
            this.ModifyAdminInfoButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ModifyAdminInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyAdminInfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ModifyAdminInfoButton.Location = new System.Drawing.Point(30, 348);
            this.ModifyAdminInfoButton.Name = "ModifyAdminInfoButton";
            this.ModifyAdminInfoButton.Size = new System.Drawing.Size(251, 32);
            this.ModifyAdminInfoButton.TabIndex = 0;
            this.ModifyAdminInfoButton.Text = "Modify Employee Info";
            this.ModifyAdminInfoButton.UseVisualStyleBackColor = false;
            this.ModifyAdminInfoButton.Click += new System.EventHandler(this.ModifyAdminInfoButton_Click);
            // 
            // EmployeeEmailGroupBox
            // 
            this.EmployeeEmailGroupBox.Controls.Add(this.enterEmailButton);
            this.EmployeeEmailGroupBox.Controls.Add(this.employeeEmailLabel);
            this.EmployeeEmailGroupBox.Controls.Add(this.employeeEmailTextBox);
            this.EmployeeEmailGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EmployeeEmailGroupBox.Name = "EmployeeEmailGroupBox";
            this.EmployeeEmailGroupBox.Size = new System.Drawing.Size(292, 134);
            this.EmployeeEmailGroupBox.TabIndex = 1;
            this.EmployeeEmailGroupBox.TabStop = false;
            this.EmployeeEmailGroupBox.Text = "Employee ";
            // 
            // enterEmailButton
            // 
            this.enterEmailButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.enterEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterEmailButton.ForeColor = System.Drawing.SystemColors.Control;
            this.enterEmailButton.Location = new System.Drawing.Point(18, 92);
            this.enterEmailButton.Name = "enterEmailButton";
            this.enterEmailButton.Size = new System.Drawing.Size(251, 27);
            this.enterEmailButton.TabIndex = 2;
            this.enterEmailButton.Text = "Enter";
            this.enterEmailButton.UseVisualStyleBackColor = false;
            this.enterEmailButton.Click += new System.EventHandler(this.enterEmailButton_Click);
            // 
            // employeeEmailLabel
            // 
            this.employeeEmailLabel.AutoSize = true;
            this.employeeEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeEmailLabel.Location = new System.Drawing.Point(15, 28);
            this.employeeEmailLabel.Name = "employeeEmailLabel";
            this.employeeEmailLabel.Size = new System.Drawing.Size(108, 17);
            this.employeeEmailLabel.TabIndex = 1;
            this.employeeEmailLabel.Text = "Employee Email";
            // 
            // employeeEmailTextBox
            // 
            this.employeeEmailTextBox.Location = new System.Drawing.Point(18, 56);
            this.employeeEmailTextBox.Name = "employeeEmailTextBox";
            this.employeeEmailTextBox.Size = new System.Drawing.Size(251, 20);
            this.employeeEmailTextBox.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.LimeGreen;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(30, 393);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(103, 29);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Return";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HoursGroupBox
            // 
            this.HoursGroupBox.Controls.Add(this.clockOutTextBox);
            this.HoursGroupBox.Controls.Add(this.clockInTextBox);
            this.HoursGroupBox.Controls.Add(this.hoursWeekTextBox);
            this.HoursGroupBox.Controls.Add(this.hoursDayTextBox);
            this.HoursGroupBox.Controls.Add(this.ClockOutLabel);
            this.HoursGroupBox.Controls.Add(this.ClockInLabel);
            this.HoursGroupBox.Controls.Add(this.weekHoursLabel);
            this.HoursGroupBox.Controls.Add(this.dayHoursLabel);
            this.HoursGroupBox.Location = new System.Drawing.Point(12, 152);
            this.HoursGroupBox.Name = "HoursGroupBox";
            this.HoursGroupBox.Size = new System.Drawing.Size(292, 190);
            this.HoursGroupBox.TabIndex = 3;
            this.HoursGroupBox.TabStop = false;
            this.HoursGroupBox.Text = "Hours Info";
            // 
            // clockOutTextBox
            // 
            this.clockOutTextBox.Location = new System.Drawing.Point(153, 141);
            this.clockOutTextBox.Name = "clockOutTextBox";
            this.clockOutTextBox.ReadOnly = true;
            this.clockOutTextBox.Size = new System.Drawing.Size(100, 20);
            this.clockOutTextBox.TabIndex = 7;
            // 
            // clockInTextBox
            // 
            this.clockInTextBox.Location = new System.Drawing.Point(153, 101);
            this.clockInTextBox.Name = "clockInTextBox";
            this.clockInTextBox.ReadOnly = true;
            this.clockInTextBox.Size = new System.Drawing.Size(100, 20);
            this.clockInTextBox.TabIndex = 6;
            // 
            // hoursWeekTextBox
            // 
            this.hoursWeekTextBox.Location = new System.Drawing.Point(153, 64);
            this.hoursWeekTextBox.Name = "hoursWeekTextBox";
            this.hoursWeekTextBox.ReadOnly = true;
            this.hoursWeekTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursWeekTextBox.TabIndex = 5;
            // 
            // hoursDayTextBox
            // 
            this.hoursDayTextBox.Location = new System.Drawing.Point(153, 23);
            this.hoursDayTextBox.Name = "hoursDayTextBox";
            this.hoursDayTextBox.ReadOnly = true;
            this.hoursDayTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursDayTextBox.TabIndex = 4;
            // 
            // ClockOutLabel
            // 
            this.ClockOutLabel.AutoSize = true;
            this.ClockOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockOutLabel.Location = new System.Drawing.Point(15, 141);
            this.ClockOutLabel.Name = "ClockOutLabel";
            this.ClockOutLabel.Size = new System.Drawing.Size(70, 17);
            this.ClockOutLabel.TabIndex = 3;
            this.ClockOutLabel.Text = "Clock-Out";
            // 
            // ClockInLabel
            // 
            this.ClockInLabel.AutoSize = true;
            this.ClockInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockInLabel.Location = new System.Drawing.Point(15, 101);
            this.ClockInLabel.Name = "ClockInLabel";
            this.ClockInLabel.Size = new System.Drawing.Size(58, 17);
            this.ClockInLabel.TabIndex = 2;
            this.ClockInLabel.Text = "Clock-In";
            // 
            // weekHoursLabel
            // 
            this.weekHoursLabel.AutoSize = true;
            this.weekHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekHoursLabel.Location = new System.Drawing.Point(15, 64);
            this.weekHoursLabel.Name = "weekHoursLabel";
            this.weekHoursLabel.Size = new System.Drawing.Size(96, 17);
            this.weekHoursLabel.TabIndex = 1;
            this.weekHoursLabel.Text = "Hours (Week)";
            // 
            // dayHoursLabel
            // 
            this.dayHoursLabel.AutoSize = true;
            this.dayHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayHoursLabel.Location = new System.Drawing.Point(15, 26);
            this.dayHoursLabel.Name = "dayHoursLabel";
            this.dayHoursLabel.Size = new System.Drawing.Size(85, 17);
            this.dayHoursLabel.TabIndex = 0;
            this.dayHoursLabel.Text = "Hours (Day)";
            // 
            // employeeCommentsTextBox
            // 
            this.employeeCommentsTextBox.Location = new System.Drawing.Point(319, 178);
            this.employeeCommentsTextBox.Name = "employeeCommentsTextBox";
            this.employeeCommentsTextBox.ReadOnly = true;
            this.employeeCommentsTextBox.Size = new System.Drawing.Size(298, 164);
            this.employeeCommentsTextBox.TabIndex = 4;
            this.employeeCommentsTextBox.Text = "";
            // 
            // employeeCommentsLabel
            // 
            this.employeeCommentsLabel.AutoSize = true;
            this.employeeCommentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCommentsLabel.Location = new System.Drawing.Point(316, 152);
            this.employeeCommentsLabel.Name = "employeeCommentsLabel";
            this.employeeCommentsLabel.Size = new System.Drawing.Size(225, 17);
            this.employeeCommentsLabel.TabIndex = 5;
            this.employeeCommentsLabel.Text = "Employee Comments or Concerns:";
            // 
            // vacationGroupBox
            // 
            this.vacationGroupBox.Controls.Add(this.VacationBalanceTextBox);
            this.vacationGroupBox.Controls.Add(this.vacationAccruedTextBox);
            this.vacationGroupBox.Controls.Add(this.vacationBalanceLabel);
            this.vacationGroupBox.Controls.Add(this.vacationAccruedLabel);
            this.vacationGroupBox.Location = new System.Drawing.Point(319, 12);
            this.vacationGroupBox.Name = "vacationGroupBox";
            this.vacationGroupBox.Size = new System.Drawing.Size(298, 134);
            this.vacationGroupBox.TabIndex = 6;
            this.vacationGroupBox.TabStop = false;
            this.vacationGroupBox.Text = "Vacation Info";
            // 
            // VacationBalanceTextBox
            // 
            this.VacationBalanceTextBox.Location = new System.Drawing.Point(174, 73);
            this.VacationBalanceTextBox.Name = "VacationBalanceTextBox";
            this.VacationBalanceTextBox.ReadOnly = true;
            this.VacationBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.VacationBalanceTextBox.TabIndex = 3;
            // 
            // vacationAccruedTextBox
            // 
            this.vacationAccruedTextBox.Location = new System.Drawing.Point(174, 27);
            this.vacationAccruedTextBox.Name = "vacationAccruedTextBox";
            this.vacationAccruedTextBox.ReadOnly = true;
            this.vacationAccruedTextBox.Size = new System.Drawing.Size(100, 20);
            this.vacationAccruedTextBox.TabIndex = 2;
            // 
            // vacationBalanceLabel
            // 
            this.vacationBalanceLabel.AutoSize = true;
            this.vacationBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacationBalanceLabel.Location = new System.Drawing.Point(20, 76);
            this.vacationBalanceLabel.Name = "vacationBalanceLabel";
            this.vacationBalanceLabel.Size = new System.Drawing.Size(118, 17);
            this.vacationBalanceLabel.TabIndex = 1;
            this.vacationBalanceLabel.Text = "Vacation Balance";
            // 
            // vacationAccruedLabel
            // 
            this.vacationAccruedLabel.AutoSize = true;
            this.vacationAccruedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacationAccruedLabel.Location = new System.Drawing.Point(20, 28);
            this.vacationAccruedLabel.Name = "vacationAccruedLabel";
            this.vacationAccruedLabel.Size = new System.Drawing.Size(119, 17);
            this.vacationAccruedLabel.TabIndex = 0;
            this.vacationAccruedLabel.Text = "Vacation Accrued";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel.Location = new System.Drawing.Point(139, 400);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(40, 17);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Error";
            // 
            // FormAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(629, 431);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.vacationGroupBox);
            this.Controls.Add(this.employeeCommentsLabel);
            this.Controls.Add(this.employeeCommentsTextBox);
            this.Controls.Add(this.HoursGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EmployeeEmailGroupBox);
            this.Controls.Add(this.ModifyAdminInfoButton);
            this.Name = "FormAdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin View";
            this.Load += new System.EventHandler(this.FormAdminView_Load);
            this.EmployeeEmailGroupBox.ResumeLayout(false);
            this.EmployeeEmailGroupBox.PerformLayout();
            this.HoursGroupBox.ResumeLayout(false);
            this.HoursGroupBox.PerformLayout();
            this.vacationGroupBox.ResumeLayout(false);
            this.vacationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyAdminInfoButton;
        private System.Windows.Forms.GroupBox EmployeeEmailGroupBox;
        private System.Windows.Forms.Button enterEmailButton;
        private System.Windows.Forms.Label employeeEmailLabel;
        private System.Windows.Forms.TextBox employeeEmailTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox HoursGroupBox;
        private System.Windows.Forms.Label dayHoursLabel;
        private System.Windows.Forms.Label weekHoursLabel;
        private System.Windows.Forms.Label ClockInLabel;
        private System.Windows.Forms.Label ClockOutLabel;
        private System.Windows.Forms.RichTextBox employeeCommentsTextBox;
        private System.Windows.Forms.Label employeeCommentsLabel;
        private System.Windows.Forms.GroupBox vacationGroupBox;
        private System.Windows.Forms.Label vacationBalanceLabel;
        private System.Windows.Forms.Label vacationAccruedLabel;
        private System.Windows.Forms.TextBox vacationAccruedTextBox;
        private System.Windows.Forms.TextBox VacationBalanceTextBox;
        private System.Windows.Forms.TextBox hoursDayTextBox;
        private System.Windows.Forms.TextBox hoursWeekTextBox;
        private System.Windows.Forms.TextBox clockInTextBox;
        private System.Windows.Forms.TextBox clockOutTextBox;
        private System.Windows.Forms.Label errorLabel;
    }
}