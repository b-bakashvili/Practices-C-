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
    public partial class SignUp : Form
    {
        private UserService userService;
        public SignUp(UserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private void buttonForSignUp_Click(object sender, EventArgs e)
        {
            userService.RegisterUser(
                textBoxForName.Text,
                textBoxForEmail.Text,
                textBoxForNumber.Text,
                textBoxForUsername.Text,
                textBoxForPassword.Text
            );

            UserLoginApp.Forms.Login loginForm = new UserLoginApp.Forms.Login(userService);
            loginForm.Show();
            this.Hide();
        }

        private void logInOption_Click(object sender, EventArgs e)
        {
            UserLoginApp.Forms.Login loginForm = new UserLoginApp.Forms.Login(userService);
            loginForm.Show();
            this.Hide();
        }
    }
}
