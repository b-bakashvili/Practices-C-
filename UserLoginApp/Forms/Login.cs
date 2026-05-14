using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLoginApp.Services;
using UserLoginApp.Models;

namespace UserLoginApp.Forms
{
    public partial class Login : Form
    {
        private UserService userService;
        public Login(UserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private void buttonForLogin_Click(object sender, EventArgs e)
        {
            User user = userService.AuthenticateUser(
                textBoxForName.Text,
                textBoxForPassword.Text
            );

            if (user != null)
            {
                UserLoginApp.Forms.LogOut userInfoForm = new UserLoginApp.Forms.LogOut(userService, user);
                userInfoForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void buttonForRegistration_Click(object sender, EventArgs e)
        {
            UserLoginApp.Forms.SignUp regForm = new UserLoginApp.Forms.SignUp(userService);
            regForm.Show();
            this.Hide();
        }
    }
}
