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
    public partial class LogOut : Form
    {
        private UserService userService;
        public LogOut(UserService userService, User user)
        {
            InitializeComponent();
            this.userService = userService;

            nameLable.Text = "Name: " + user.name;
            emailLable.Text = "Email: " + user.email;
            numberLable.Text = "Phone Number: " + user.phoneNumber;
            usernameLable.Text = "Username: " + user.username;
            passwordLable.Text = "Password: " + user.password;
        }

        private void buttonForLogOut_Click(object sender, EventArgs e)
        {
            UserLoginApp.Forms.SignUp regForm = new UserLoginApp.Forms.SignUp(userService);
            regForm.Show();
            this.Hide();
        }
    }
}
