namespace TimeOClock
{
    partial class FormIndex
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
            this.Register = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.SteelBlue;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Register.Location = new System.Drawing.Point(18, 295);
            this.Register.Margin = new System.Windows.Forms.Padding(21, 28, 21, 28);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(225, 40);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login.Location = new System.Drawing.Point(18, 172);
            this.Login.Margin = new System.Windows.Forms.Padding(21, 28, 21, 28);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(221, 36);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Don\'t have an account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "6-Digit Pin:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(91, 214);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Pin?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Sitka Small", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LabelTitle.Location = new System.Drawing.Point(16, -3);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(227, 48);
            this.LabelTitle.TabIndex = 6;
            this.LabelTitle.Text = "Nine-Thirty ";
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdLabel.Location = new System.Drawing.Point(90, 45);
            this.UserIdLabel.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(76, 24);
            this.UserIdLabel.TabIndex = 7;
            this.UserIdLabel.Text = "User ID:";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTextBox.Location = new System.Drawing.Point(18, 77);
            this.userIdTextBox.Margin = new System.Windows.Forms.Padding(21, 28, 21, 28);
            this.userIdTextBox.MaxLength = 100;
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(221, 23);
            this.userIdTextBox.TabIndex = 8;
            this.userIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(15, 245);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(40, 15);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Errors";
            // 
            // pinTextBox
            // 
            this.pinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinTextBox.Location = new System.Drawing.Point(18, 141);
            this.pinTextBox.Margin = new System.Windows.Forms.Padding(21, 28, 21, 28);
            this.pinTextBox.MaxLength = 6;
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(221, 23);
            this.pinTextBox.TabIndex = 3;
            this.pinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(253, 344);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Register);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(21, 28, 21, 28);
            this.Name = "FormIndex";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label UserIdLabel;
        public System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label errorLabel;
        public System.Windows.Forms.TextBox pinTextBox;
    }
}
  

    
