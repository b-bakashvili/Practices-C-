using Practice12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12.Services;

internal static class MemberService
{
    // Fields:
    public static Member[] members = new Member[100];

    // Methods:
    public static void Initialize()
    {
        Member initialMember = new Member
        {
            Id = 1,
            FirstName = "Giorgi",
            LastName = "Beridze",
            Age = 45,
            Email = "giorgi.beridze@email.com",
            PersonalNumber = "1234567890",
            CreatedOn = DateTime.Now
        };

        members[0] = initialMember;
    }

    public static void AddMember(int ID, string firstName, string lastName, int age, string email, string personalNumber, DateTime createdOn)
    {
        int index = -1;
        for (int i = 0; i < members.Length; i++)
        {
            if (members[i] == null)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Member list is full. Cannot add more members.");
            return;
        }

        Member newMember = new Member
        {
            Id = ID,
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            Email = email,
            PersonalNumber = personalNumber,
            CreatedOn = createdOn
        };

        members[index] = newMember;

        Console.WriteLine("Member added successfully!");
    }

    public static void GetAllMembers()
    {
        for (int i = 0; i < members.Length; i++)
        {
            if (members[i] != null)
            {
                members[i].PrintInfo();
            }
        }
    }

    public static void UpdateMember()
    {
        Console.WriteLine("Members: ");
        GetAllMembers();

        Console.WriteLine("Enter ID of the member to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Member memberToUpdate = null;
        for (int i = 0; i < members.Length; i++)
        {
            if (members[i] != null && members[i].Id == id)
            {
                memberToUpdate = members[i];
                break;
            }
        }

        if (memberToUpdate == null)
        {
            Console.WriteLine("Member not found with ID: " + id);
            return;
        }

        bool updating = true;
        while (updating)
        {
            Console.WriteLine("\nSelect the field to update");
            Console.WriteLine("1. First name");
            Console.WriteLine("2. Last name");
            Console.WriteLine("3. Age");
            Console.WriteLine("4. Email");
            Console.WriteLine("5. Personal Number");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter updated First Name: ");
                    memberToUpdate.FirstName = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Enter updated Last Name: ");
                    memberToUpdate.LastName = Console.ReadLine();
                    break;
                case "3":
                    Console.Write("Enter updated Age: ");
                    memberToUpdate.Age = Convert.ToInt32(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter updated Email: ");
                    memberToUpdate.Email = Console.ReadLine();
                    break;
                case "5":
                    Console.Write("Enter updated Personal Number: ");
                    memberToUpdate.PersonalNumber = Console.ReadLine();
                    break;
                case "0":
                    updating = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
        Console.WriteLine("Member updated successfully!");
    }

    public static void DeleteMember()
    {
        Console.WriteLine("Members: ");
        GetAllMembers();

        Console.Write("Enter ID of the member to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < members.Length; i++)
        {
            if (members[i] != null && members[i].Id == id)
            {
                members[i] = null;
                Console.WriteLine("Member deleted successfully");
                return;
            }
        }
        Console.WriteLine("Member not found with ID: " + id);
    }
}
