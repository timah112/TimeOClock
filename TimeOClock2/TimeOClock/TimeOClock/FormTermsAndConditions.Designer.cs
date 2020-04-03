namespace TimeOClock
{
    partial class FormTermsAndConditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTermsAndConditions));
            this.termsTextBox = new System.Windows.Forms.RichTextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // termsTextBox
            // 
            this.termsTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.termsTextBox.Location = new System.Drawing.Point(10, 12);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.ReadOnly = true;
            this.termsTextBox.Size = new System.Drawing.Size(303, 232);
            this.termsTextBox.TabIndex = 0;
            this.termsTextBox.Text = resources.GetString("termsTextBox.Text");
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.LimeGreen;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.okButton.Location = new System.Drawing.Point(12, 260);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(301, 31);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Return";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // FormTermsAndConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 303);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.termsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormTermsAndConditions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terms & Conditions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox termsTextBox;
        private System.Windows.Forms.Button okButton;
    }
}