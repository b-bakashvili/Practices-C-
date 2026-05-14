using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UserLoginApp.Models;

namespace UserLoginApp.Services;

public class UserService
{
    private List<User> users = new List<User>();

    public User AuthenticateUser(string userName, string password)
    {
        foreach(User user in users)
        {
            if(userName == user.username && password == user.password)
            {
                return user;
            }
        }
        return null; // value will be null if it is not found
    }
    public void RegisterUser(string name, string email, string phoneNumber, string userName, string password)
    {
        User newUser = new User(name, email, phoneNumber, userName, password);
        users.Add(newUser);
    }
}
