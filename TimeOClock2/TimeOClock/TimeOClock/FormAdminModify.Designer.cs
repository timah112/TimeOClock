namespace TimeOClock
{
    partial class FormAdminModify
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
            this.startingVacationBalanceLabel = new System.Windows.Forms.Label();
            this.EmployeeStartDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.denyRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VacationRequestTextBox = new System.Windows.Forms.TextBox();
            this.approveRadioButton = new System.Windows.Forms.RadioButton();
            this.generalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.startingVacationBalanceTextBox = new System.Windows.Forms.TextBox();
            this.employeeHireDateTextBox = new System.Windows.Forms.TextBox();
            this.submitEmployeeInfoTextBox = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.EnterVacationRequestButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.generalInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startingVacationBalanceLabel
            // 
            this.startingVacationBalanceLabel.AutoSize = true;
            this.startingVacationBalanceLabel.Location = new System.Drawing.Point(6, 68);
            this.startingVacationBalanceLabel.Name = "startingVacationBalanceLabel";
            this.startingVacationBalanceLabel.Size = new System.Drawing.Size(163, 13);
            this.startingVacationBalanceLabel.TabIndex = 1;
            this.startingVacationBalanceLabel.Text = "Starting Vacation Balance (Days)";
            // 
            // EmployeeStartDateLabel
            // 
            this.EmployeeStartDateLabel.AutoSize = true;
            this.EmployeeStartDateLabel.Location = new System.Drawing.Point(6, 28);
            this.EmployeeStartDateLabel.Name = "EmployeeStartDateLabel";
            this.EmployeeStartDateLabel.Size = new System.Drawing.Size(178, 13);
            this.EmployeeStartDateLabel.TabIndex = 2;
            this.EmployeeStartDateLabel.Text = "Employee Hire Date (YYYY-MM-DD)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vacation Request";
            // 
            // denyRadioButton
            // 
            this.denyRadioButton.AutoSize = true;
            this.denyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyRadioButton.ForeColor = System.Drawing.Color.Maroon;
            this.denyRadioButton.Location = new System.Drawing.Point(182, 85);
            this.denyRadioButton.Name = "denyRadioButton";
            this.denyRadioButton.Size = new System.Drawing.Size(59, 21);
            this.denyRadioButton.TabIndex = 4;
            this.denyRadioButton.TabStop = true;
            this.denyRadioButton.Text = "Deny";
            this.denyRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VacationRequestTextBox);
            this.groupBox1.Controls.Add(this.approveRadioButton);
            this.groupBox1.Controls.Add(this.denyRadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vacation";
            // 
            // VacationRequestTextBox
            // 
            this.VacationRequestTextBox.Location = new System.Drawing.Point(18, 59);
            this.VacationRequestTextBox.Name = "VacationRequestTextBox";
            this.VacationRequestTextBox.ReadOnly = true;
            this.VacationRequestTextBox.Size = new System.Drawing.Size(253, 20);
            this.VacationRequestTextBox.TabIndex = 9;
            // 
            // approveRadioButton
            // 
            this.approveRadioButton.AutoSize = true;
            this.approveRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveRadioButton.Location = new System.Drawing.Point(44, 85);
            this.approveRadioButton.Name = "approveRadioButton";
            this.approveRadioButton.Size = new System.Drawing.Size(79, 21);
            this.approveRadioButton.TabIndex = 6;
            this.approveRadioButton.TabStop = true;
            this.approveRadioButton.Text = "Approve";
            this.approveRadioButton.UseVisualStyleBackColor = true;
            // 
            // generalInfoGroupBox
            // 
            this.generalInfoGroupBox.Controls.Add(this.startingVacationBalanceTextBox);
            this.generalInfoGroupBox.Controls.Add(this.employeeHireDateTextBox);
            this.generalInfoGroupBox.Controls.Add(this.EmployeeStartDateLabel);
            this.generalInfoGroupBox.Controls.Add(this.startingVacationBalanceLabel);
            this.generalInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.generalInfoGroupBox.Name = "generalInfoGroupBox";
            this.generalInfoGroupBox.Size = new System.Drawing.Size(295, 100);
            this.generalInfoGroupBox.TabIndex = 6;
            this.generalInfoGroupBox.TabStop = false;
            this.generalInfoGroupBox.Text = "General Info:";
            // 
            // startingVacationBalanceTextBox
            // 
            this.startingVacationBalanceTextBox.Location = new System.Drawing.Point(190, 65);
            this.startingVacationBalanceTextBox.Name = "startingVacationBalanceTextBox";
            this.startingVacationBalanceTextBox.Size = new System.Drawing.Size(93, 20);
            this.startingVacationBalanceTextBox.TabIndex = 8;
            // 
            // employeeHireDateTextBox
            // 
            this.employeeHireDateTextBox.Location = new System.Drawing.Point(190, 25);
            this.employeeHireDateTextBox.Name = "employeeHireDateTextBox";
            this.employeeHireDateTextBox.Size = new System.Drawing.Size(93, 20);
            this.employeeHireDateTextBox.TabIndex = 7;
            // 
            // submitEmployeeInfoTextBox
            // 
            this.submitEmployeeInfoTextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.submitEmployeeInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitEmployeeInfoTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitEmployeeInfoTextBox.Location = new System.Drawing.Point(12, 118);
            this.submitEmployeeInfoTextBox.Name = "submitEmployeeInfoTextBox";
            this.submitEmployeeInfoTextBox.Size = new System.Drawing.Size(295, 30);
            this.submitEmployeeInfoTextBox.TabIndex = 7;
            this.submitEmployeeInfoTextBox.Text = "Submit Info";
            this.submitEmployeeInfoTextBox.UseVisualStyleBackColor = false;
            this.submitEmployeeInfoTextBox.Click += new System.EventHandler(this.submitEmployeeInfoTextBox_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LimeGreen;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(10, 336);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(133, 30);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // EnterVacationRequestButton
            // 
            this.EnterVacationRequestButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EnterVacationRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterVacationRequestButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterVacationRequestButton.Location = new System.Drawing.Point(10, 298);
            this.EnterVacationRequestButton.Name = "EnterVacationRequestButton";
            this.EnterVacationRequestButton.Size = new System.Drawing.Size(297, 32);
            this.EnterVacationRequestButton.TabIndex = 10;
            this.EnterVacationRequestButton.Text = "Enter";
            this.EnterVacationRequestButton.UseVisualStyleBackColor = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 164);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(34, 15);
            this.ErrorLabel.TabIndex = 11;
            this.ErrorLabel.Text = "Error";
            // 
            // FormAdminModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(319, 378);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.EnterVacationRequestButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitEmployeeInfoTextBox);
            this.Controls.Add(this.generalInfoGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdminModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Modify";
            this.Load += new System.EventHandler(this.FormAdminModify_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.generalInfoGroupBox.ResumeLayout(false);
            this.generalInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingVacationBalanceLabel;
        private System.Windows.Forms.Label EmployeeStartDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton denyRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton approveRadioButton;
        private System.Windows.Forms.GroupBox generalInfoGroupBox;
        private System.Windows.Forms.TextBox startingVacationBalanceTextBox;
        private System.Windows.Forms.TextBox employeeHireDateTextBox;
        private System.Windows.Forms.Button submitEmployeeInfoTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox VacationRequestTextBox;
        private System.Windows.Forms.Button EnterVacationRequestButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}