using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12.Models;

internal class Member
{
    public int Id;
    public string FirstName;
    public string LastName;
    public int Age;
    public string Email;
    public string PersonalNumber;
    public DateTime CreatedOn;

    public void PrintInfo()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Name: " + FirstName + LastName);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("PersonalNumber: " + PersonalNumber);
        Console.WriteLine("CreatedOn: " + CreatedOn.Date.ToShortDateString());
        Console.WriteLine("----------------------");
    }
}
