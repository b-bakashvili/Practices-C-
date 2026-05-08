using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12.Models;

internal class Book
{
    public int Id;
    public string Title;
    public string Author;
    public string Genre;
    public int PublishedYear;
    public bool IsBorrowed;
    public int? BorrowedByMemberId;
    //public bool IsBorrowed { get; set; }
    //public int? BorrowedByMemberId { get; set; }

    public void printInfo()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Genre: " + Genre);
        Console.WriteLine("Published Year: " + PublishedYear);
    }
}
