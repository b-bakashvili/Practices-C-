namespace UserLoginApp.Forms
{
    partial class Login
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
            loginLable = new Label();
            textBoxForName = new TextBox();
            textBoxForPassword = new TextBox();
            buttonForLogin = new Button();
            optionMessageLable = new Label();
            buttonForRegistration = new Button();
            SuspendLayout();
            // 
            // loginLable
            // 
            loginLable.Font = new Font("Segoe UI", 20F);
            loginLable.Location = new Point(294, 41);
            loginLable.Name = "loginLable";
            loginLable.Size = new Size(177, 69);
            loginLable.TabIndex = 0;
            loginLable.Text = "Login";
            loginLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxForName
            // 
            textBoxForName.Location = new Point(294, 131);
            textBoxForName.Name = "textBoxForName";
            textBoxForName.Size = new Size(177, 27);
            textBoxForName.TabIndex = 1;
            // 
            // textBoxForPassword
            // 
            textBoxForPassword.Location = new Point(294, 164);
            textBoxForPassword.Name = "textBoxForPassword";
            textBoxForPassword.Size = new Size(177, 27);
            textBoxForPassword.TabIndex = 2;
            // 
            // buttonForLogin
            // 
            buttonForLogin.BackColor = SystemColors.Highlight;
            buttonForLogin.Font = new Font("Segoe UI", 15F);
            buttonForLogin.ForeColor = SystemColors.Control;
            buttonForLogin.Location = new Point(266, 229);
            buttonForLogin.Name = "buttonForLogin";
            buttonForLogin.Size = new Size(235, 59);
            buttonForLogin.TabIndex = 3;
            buttonForLogin.Text = "Login";
            buttonForLogin.UseVisualStyleBackColor = false;
            buttonForLogin.Click += buttonForLogin_Click;
            // 
            // optionMessageLable
            // 
            optionMessageLable.AutoSize = true;
            optionMessageLable.Location = new Point(266, 312);
            optionMessageLable.Name = "optionMessageLable";
            optionMessageLable.Size = new Size(113, 20);
            optionMessageLable.TabIndex = 4;
            optionMessageLable.Text = "Not a member?";
            // 
            // buttonForRegistration
            // 
            buttonForRegistration.ForeColor = SystemColors.Highlight;
            buttonForRegistration.Location = new Point(385, 308);
            buttonForRegistration.Name = "buttonForRegistration";
            buttonForRegistration.Size = new Size(119, 29);
            buttonForRegistration.TabIndex = 5;
            buttonForRegistration.Text = "Register Now";
            buttonForRegistration.UseVisualStyleBackColor = true;
            buttonForRegistration.Click += buttonForRegistration_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonForRegistration);
            Controls.Add(optionMessageLable);
            Controls.Add(buttonForLogin);
            Controls.Add(textBoxForPassword);
            Controls.Add(textBoxForName);
            Controls.Add(loginLable);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLable;
        private TextBox textBoxForName;
        private TextBox textBoxForPassword;
        private Button buttonForLogin;
        private Label optionMessageLable;
        private Button buttonForRegistration;
    }
}