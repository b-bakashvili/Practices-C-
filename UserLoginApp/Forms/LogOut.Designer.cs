namespace UserLoginApp.Forms
{
    partial class LogOut
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
            messageLable = new Label();
            nameLable = new Label();
            emailLable = new Label();
            numberLable = new Label();
            usernameLable = new Label();
            passwordLable = new Label();
            buttonForLogOut = new Button();
            SuspendLayout();
            // 
            // messageLable
            // 
            messageLable.Font = new Font("Segoe UI", 20F);
            messageLable.Location = new Point(324, 23);
            messageLable.Name = "messageLable";
            messageLable.Size = new Size(174, 83);
            messageLable.TabIndex = 0;
            messageLable.Text = "User Info";
            messageLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameLable
            // 
            nameLable.Location = new Point(324, 116);
            nameLable.Name = "nameLable";
            nameLable.Size = new Size(174, 25);
            nameLable.TabIndex = 1;
            nameLable.Text = "Name:";
            nameLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLable
            // 
            emailLable.Location = new Point(324, 141);
            emailLable.Name = "emailLable";
            emailLable.Size = new Size(174, 22);
            emailLable.TabIndex = 2;
            emailLable.Text = "Email:";
            emailLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numberLable
            // 
            numberLable.Location = new Point(324, 163);
            numberLable.Name = "numberLable";
            numberLable.Size = new Size(174, 25);
            numberLable.TabIndex = 3;
            numberLable.Text = "Phone Number:";
            numberLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLable
            // 
            usernameLable.Location = new Point(324, 188);
            usernameLable.Name = "usernameLable";
            usernameLable.Size = new Size(174, 25);
            usernameLable.TabIndex = 4;
            usernameLable.Text = "Username:";
            usernameLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLable
            // 
            passwordLable.Location = new Point(324, 213);
            passwordLable.Name = "passwordLable";
            passwordLable.Size = new Size(174, 25);
            passwordLable.TabIndex = 5;
            passwordLable.Text = "Password:";
            passwordLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonForLogOut
            // 
            buttonForLogOut.BackColor = SystemColors.Highlight;
            buttonForLogOut.Font = new Font("Segoe UI", 15F);
            buttonForLogOut.ForeColor = SystemColors.Control;
            buttonForLogOut.Location = new Point(466, 296);
            buttonForLogOut.Name = "buttonForLogOut";
            buttonForLogOut.Size = new Size(200, 43);
            buttonForLogOut.TabIndex = 6;
            buttonForLogOut.Text = "Log Out";
            buttonForLogOut.UseVisualStyleBackColor = false;
            buttonForLogOut.Click += buttonForLogOut_Click;
            // 
            // LogOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonForLogOut);
            Controls.Add(passwordLable);
            Controls.Add(usernameLable);
            Controls.Add(numberLable);
            Controls.Add(emailLable);
            Controls.Add(nameLable);
            Controls.Add(messageLable);
            Name = "LogOut";
            Text = "LogOut";
            ResumeLayout(false);
        }

        #endregion

        private Label messageLable;
        private Label nameLable;
        private Label emailLable;
        private Label numberLable;
        private Label usernameLable;
        private Label passwordLable;
        private Button buttonForLogOut;
    }
}