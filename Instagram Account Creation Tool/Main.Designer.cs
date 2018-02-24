namespace Instagram_Account_Creation_Tool
{
    partial class Main
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
            this.createAccountButton = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userIdText = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(12, 268);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(242, 23);
            this.createAccountButton.TabIndex = 0;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(12, 28);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(235, 20);
            this.usernameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username to register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password to register";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(12, 71);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(235, 20);
            this.passwordText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email to register";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(12, 120);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(235, 20);
            this.emailText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "First Name to register (optional)";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(12, 168);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(235, 20);
            this.firstNameText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "User ID (shown on account creation)";
            // 
            // userIdText
            // 
            this.userIdText.Location = new System.Drawing.Point(12, 217);
            this.userIdText.Name = "userIdText";
            this.userIdText.ReadOnly = true;
            this.userIdText.Size = new System.Drawing.Size(235, 20);
            this.userIdText.TabIndex = 9;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(9, 240);
            this.errorLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 11;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.successLabel.Location = new System.Drawing.Point(9, 240);
            this.successLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(0, 13);
            this.successLabel.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 303);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.createAccountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Instagram Account Creation Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userIdText;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label successLabel;
    }
}

