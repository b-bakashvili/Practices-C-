using UserLoginApp.Forms;
using UserLoginApp.Services;

namespace UserLoginApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            UserService userService = new UserService();
            Application.Run(new SignUp(userService));
        }
    }
}