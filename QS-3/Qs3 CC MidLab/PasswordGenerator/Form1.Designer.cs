
namespace PasswordGenerator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.GeneratedPasswordLabel = new System.Windows.Forms.Label();
            this.RegistrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Reg Number:";
            // 
            // GeneratedPasswordLabel
            // 
            this.GeneratedPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratedPasswordLabel.AutoSize = true;
            this.GeneratedPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratedPasswordLabel.Location = new System.Drawing.Point(39, 205);
            this.GeneratedPasswordLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.GeneratedPasswordLabel.Name = "GeneratedPasswordLabel";
            this.GeneratedPasswordLabel.Padding = new System.Windows.Forms.Padding(2);
            this.GeneratedPasswordLabel.Size = new System.Drawing.Size(280, 28);
            this.GeneratedPasswordLabel.TabIndex = 1;
            this.GeneratedPasswordLabel.Text = "Your Password will appear here";
            // 
            // RegistrationNumberTextBox
            // 
            this.RegistrationNumberTextBox.Location = new System.Drawing.Point(43, 34);
            this.RegistrationNumberTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.RegistrationNumberTextBox.Name = "RegistrationNumberTextBox";
            this.RegistrationNumberTextBox.Size = new System.Drawing.Size(269, 20);
            this.RegistrationNumberTextBox.TabIndex = 2;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(116, 156);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(1);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(106, 39);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(43, 83);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(269, 20);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter First Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(43, 128);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(269, 20);
            this.LastNameTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Last Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(345, 260);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.RegistrationNumberTextBox);
            this.Controls.Add(this.GeneratedPasswordLabel);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GeneratedPasswordLabel;
        private System.Windows.Forms.TextBox RegistrationNumberTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label3;
    }
}

