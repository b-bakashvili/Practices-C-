using Practice12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12.Services;

internal static class BookService
{
    // fields
    public static Book[] books = new Book[100];

    public static Book[] initialBooks = new Book[10]
    {
        new Book { Id = 1, Title = "Clean Code", Author = "Robert Martin", Genre = "Programming", PublishedYear = 2008 },
        new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Genre = "Programming", PublishedYear = 1999 },
        new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma", Genre = "Programming", PublishedYear = 1994 },
        new Book { Id = 4, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", PublishedYear = 1937 },
        new Book { Id = 5, Title = "1984", Author = "George Orwell", Genre = "Dystopian", PublishedYear = 1949 },
        new Book { Id = 6, Title = "Atomic Habits", Author = "James Clear", Genre = "Self Development", PublishedYear = 2018 },
        new Book { Id = 7, Title = "Deep Work", Author = "Cal Newport", Genre = "Productivity", PublishedYear = 2016 },
        new Book { Id = 8, Title = "Rich Dad Poor Dad", Author = "Robert Kiyosaki", Genre = "Finance", PublishedYear = 1997 },
        new Book { Id = 9, Title = "The Alchemist", Author = "Paulo Coelho", Genre = "Novel", PublishedYear = 1988 },
        new Book { Id = 10, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic", PublishedYear = 1960 }
    };

    // static constructor
    static BookService()
    {
        for (int i = 0; i < 10; i++)
        {
            books[i] = initialBooks[i];
        }
    }

    public static void AddBook(int ID, string title, string author, string genre, int publishedYear)
    {
        int index = -1;
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == null)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Library is full. Cannot add more Books.");
            return;
        }

        Book newBook = new Book
        {
            Id = ID,
            Title = title,
            Author = author,
            Genre = genre,
            PublishedYear = publishedYear
        };

        books[index] = newBook;

        Console.WriteLine("Book added successfully");
    }

    public static void GetAllBooks()
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null)
            {
                books[i].printInfo();
            }
        }
    }

    public static void UpdateBook()
    {
        Console.WriteLine("Books: ");
        GetAllBooks();

        Console.WriteLine("Enter ID of the book to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Book bookToUpdate = null;
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null && books[i].Id == id)
            {
                bookToUpdate = books[i];
                break;
            }
        }

        if (bookToUpdate == null)
        {
            Console.WriteLine("Book not found with ID: " + id);
            return;
        }

        bool updating = true;

        while (updating)
        {
            //public int Id;
            //public string Title;
            //public string Author;
            //public string Genre;
            //public int PublishedYear;
            Console.WriteLine("\nSelect the field to update");
            Console.WriteLine("1. Title");
            Console.WriteLine("2. Author");
            Console.WriteLine("3. Genre");
            Console.WriteLine("4. PublishedYear");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter updated Title: ");
                    bookToUpdate.Title = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Enter updated Author: ");
                    bookToUpdate.Author = Console.ReadLine();
                    break;
                case "3":
                    Console.Write("Enter updated Genre: ");
                    bookToUpdate.Genre = Console.ReadLine();
                    break;
                case "4":
                    Console.Write("Enter updated PublishedYear: ");
                    bookToUpdate.PublishedYear = Convert.ToInt32(Console.ReadLine());
                    break;
                case "0":
                    updating = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
        Console.WriteLine("Book updated successfully!");
    }

    public static void DeleteBook()
    {
        Console.WriteLine("Books: ");
        GetAllBooks();

        Console.WriteLine("Enter ID of the book to delete");
        int id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null && books[i].Id == id)
            {
                books[i] = null;
                Console.WriteLine("Book deleted successfully");
                return;
            }
        }
        Console.WriteLine("Book not found with ID: " + id);
    }
}
