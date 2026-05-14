namespace UserLoginApp.Forms
{
    partial class SignUp
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
            signUpLable = new Label();
            textBoxForName = new TextBox();
            textBoxForEmail = new TextBox();
            textBoxForNumber = new TextBox();
            textBoxForUsername = new TextBox();
            textBoxForPassword = new TextBox();
            buttonForSignUp = new Button();
            optionMessageLable = new Label();
            logInOption = new Button();
            SuspendLayout();
            // 
            // signUpLable
            // 
            signUpLable.Font = new Font("Segoe UI", 20F);
            signUpLable.Location = new Point(262, 24);
            signUpLable.Name = "signUpLable";
            signUpLable.Size = new Size(255, 61);
            signUpLable.TabIndex = 0;
            signUpLable.Text = "Sign up";
            signUpLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxForName
            // 
            textBoxForName.Location = new Point(262, 104);
            textBoxForName.Name = "textBoxForName";
            textBoxForName.Size = new Size(255, 27);
            textBoxForName.TabIndex = 1;
            // 
            // textBoxForEmail
            // 
            textBoxForEmail.Location = new Point(262, 137);
            textBoxForEmail.Name = "textBoxForEmail";
            textBoxForEmail.Size = new Size(255, 27);
            textBoxForEmail.TabIndex = 2;
            // 
            // textBoxForNumber
            // 
            textBoxForNumber.Location = new Point(262, 170);
            textBoxForNumber.Name = "textBoxForNumber";
            textBoxForNumber.Size = new Size(255, 27);
            textBoxForNumber.TabIndex = 3;
            // 
            // textBoxForUsername
            // 
            textBoxForUsername.Location = new Point(262, 203);
            textBoxForUsername.Name = "textBoxForUsername";
            textBoxForUsername.Size = new Size(255, 27);
            textBoxForUsername.TabIndex = 4;
            // 
            // textBoxForPassword
            // 
            textBoxForPassword.Location = new Point(262, 236);
            textBoxForPassword.Name = "textBoxForPassword";
            textBoxForPassword.Size = new Size(255, 27);
            textBoxForPassword.TabIndex = 5;
            // 
            // buttonForSignUp
            // 
            buttonForSignUp.BackColor = SystemColors.MenuHighlight;
            buttonForSignUp.Font = new Font("Segoe UI", 15F);
            buttonForSignUp.ForeColor = SystemColors.Control;
            buttonForSignUp.Location = new Point(262, 289);
            buttonForSignUp.Name = "buttonForSignUp";
            buttonForSignUp.Size = new Size(255, 55);
            buttonForSignUp.TabIndex = 6;
            buttonForSignUp.Text = "Sign Up";
            buttonForSignUp.UseVisualStyleBackColor = false;
            buttonForSignUp.Click += buttonForSignUp_Click;
            // 
            // optionMessageLable
            // 
            optionMessageLable.Location = new Point(262, 363);
            optionMessageLable.Name = "optionMessageLable";
            optionMessageLable.Size = new Size(144, 25);
            optionMessageLable.TabIndex = 7;
            optionMessageLable.Text = "Already a member?";
            // 
            // logInOption
            // 
            logInOption.ForeColor = SystemColors.Highlight;
            logInOption.Location = new Point(412, 359);
            logInOption.Name = "logInOption";
            logInOption.Size = new Size(94, 29);
            logInOption.TabIndex = 8;
            logInOption.Text = "Login Here";
            logInOption.UseVisualStyleBackColor = true;
            logInOption.Click += logInOption_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logInOption);
            Controls.Add(optionMessageLable);
            Controls.Add(buttonForSignUp);
            Controls.Add(textBoxForPassword);
            Controls.Add(textBoxForUsername);
            Controls.Add(textBoxForNumber);
            Controls.Add(textBoxForEmail);
            Controls.Add(textBoxForName);
            Controls.Add(signUpLable);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signUpLable;
        private TextBox textBoxForName;
        private TextBox textBoxForEmail;
        private TextBox textBoxForNumber;
        private TextBox textBoxForUsername;
        private TextBox textBoxForPassword;
        private Button buttonForSignUp;
        private Label optionMessageLable;
        private Button logInOption;
    }
}