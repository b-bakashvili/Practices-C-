using Practice12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12.Services;

internal static class LibraryService
{
    public static void BorrowBook(int memberID, int bookID)
    {
        Member foundMember = null;
        for (int i = 0; i < MemberService.members.Length; i++)
        {
            if (MemberService.members[i] != null && MemberService.members[i].Id == memberID)
            {
                foundMember = MemberService.members[i];
                break;
            }
        }
        if (foundMember == null)
        {
            Console.WriteLine("Member not found\n");
            return;
        }

        Book foundBook = null;
        for (int i = 0; i < BookService.books.Length; i++)
        {
            if (BookService.books[i] != null && BookService.books[i].Id == bookID)
            {
                foundBook = BookService.books[i];
                break;
            }
        }
        if (foundBook == null)
        {
            Console.WriteLine("Book not found\n");
            return;
        }

        if (foundBook.IsBorrowed)
        {
            Console.WriteLine("Book is already borrowed\n");
            return;
        }

        foundBook.IsBorrowed = true;
        foundBook.BorrowedByMemberId = memberID;

        Console.WriteLine("Book borrowed successfully\n");
    }

    public static void ReturnBook(int bookID)
    {
        Book foundBook = null;
        for (int i = 0; i < BookService.books.Length; i++)
        {
            if (BookService.books[i] != null && BookService.books[i].Id == bookID)
            {
                foundBook = BookService.books[i];
                break;
            }
        }
        if (foundBook == null)
        {
            Console.WriteLine("Book not found\n");
            return;
        }

        if (!foundBook.IsBorrowed)
        {
            Console.WriteLine("Book is not borrowed\n");
            return;
        }
        else
        {
            foundBook.IsBorrowed = false;
            foundBook.BorrowedByMemberId = null;
        }

        Console.WriteLine("Book returned successfully\n");
    }
}
