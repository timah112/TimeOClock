namespace TimeOClock
{
    partial class FormForgotPin
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
            this.forgotPinButton = new System.Windows.Forms.Button();
            this.cellPhoneTextBox = new System.Windows.Forms.TextBox();
            this.dobTextBox = new System.Windows.Forms.DateTimePicker();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.forgotPinErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forgotPinButton
            // 
            this.forgotPinButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.forgotPinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPinButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.forgotPinButton.Location = new System.Drawing.Point(110, 167);
            this.forgotPinButton.Name = "forgotPinButton";
            this.forgotPinButton.Size = new System.Drawing.Size(83, 27);
            this.forgotPinButton.TabIndex = 0;
            this.forgotPinButton.Text = "Submit";
            this.forgotPinButton.UseVisualStyleBackColor = false;
            this.forgotPinButton.Click += new System.EventHandler(this.forgotPinButton_Click);
            // 
            // cellPhoneTextBox
            // 
            this.cellPhoneTextBox.Location = new System.Drawing.Point(12, 39);
            this.cellPhoneTextBox.Name = "cellPhoneTextBox";
            this.cellPhoneTextBox.Size = new System.Drawing.Size(181, 20);
            this.cellPhoneTextBox.TabIndex = 1;
            // 
            // dobTextBox
            // 
            this.dobTextBox.Location = new System.Drawing.Point(12, 100);
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(181, 20);
            this.dobTextBox.TabIndex = 2;
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.Location = new System.Drawing.Point(12, 23);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(58, 13);
            this.cellPhoneLabel.TabIndex = 3;
            this.cellPhoneLabel.Text = "Cell Phone";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(9, 84);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(66, 13);
            this.dobLabel.TabIndex = 4;
            this.dobLabel.Text = "Date of Birth";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LimeGreen;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(12, 167);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(92, 27);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forgotPinErrorLabel
            // 
            this.forgotPinErrorLabel.AutoSize = true;
            this.forgotPinErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.forgotPinErrorLabel.Location = new System.Drawing.Point(0, 136);
            this.forgotPinErrorLabel.Name = "forgotPinErrorLabel";
            this.forgotPinErrorLabel.Size = new System.Drawing.Size(34, 13);
            this.forgotPinErrorLabel.TabIndex = 6;
            this.forgotPinErrorLabel.Text = "Errors";
            // 
            // FormForgotPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(213, 206);
            this.Controls.Add(this.forgotPinErrorLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.cellPhoneLabel);
            this.Controls.Add(this.dobTextBox);
            this.Controls.Add(this.cellPhoneTextBox);
            this.Controls.Add(this.forgotPinButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormForgotPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Pin";
            this.Load += new System.EventHandler(this.FormForgotPin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forgotPinButton;
        public System.Windows.Forms.TextBox cellPhoneTextBox;
        public System.Windows.Forms.DateTimePicker dobTextBox;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.Label dobLabel;
        public System.Windows.Forms.Button backButton;
        public System.Windows.Forms.Label forgotPinErrorLabel;
    }
}