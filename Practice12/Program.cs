using Practice12.Services;

MemberService.Initialize();

char input = '*';
while (input != '0')
{
    // Options:
    Console.WriteLine("1 - Register Member\n" +
                      "2 - Show All Members\n" +
                      "3 - Update Member\n" +
                      "4 - Delete Member\n\n" +

                      "5 - Add Book\n" +
                      "6 - Show All Books\n" +
                      "7 - Update Book\n" +
                      "8 - Delete Book\n\n" +

                      "+ - Borrow Book\n\n" +
                      "- - Return Book\n\n" +

                      "0 - Exit\n");

    Console.Write("Input: ");
    input = Convert.ToChar(Console.ReadLine());
    Console.Write("\n\n");

    // Exit option:
    if (input == '0')
    {
        Console.WriteLine("Exitted Program!");
        break;
    }

    // MemberService options:
    else if (input == '1')
    {
        Console.WriteLine("Enter member ID: ");
        int ID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter FirstName: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter LastName: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter email: ");
        string email = Console.ReadLine();

        Console.WriteLine("Enter PersonalNumber: ");
        string personalNumber = Console.ReadLine();

        DateTime createdOn = DateTime.Now;

        MemberService.AddMember(ID, firstName, lastName, age, email, personalNumber, createdOn);
    }
    else if (input == '2')
    {
        MemberService.GetAllMembers();
        Console.WriteLine('\n');
    }
    else if (input == '3')
    {
        MemberService.UpdateMember();
    }
    else if (input == '4')
    {
        MemberService.DeleteMember();
    }

    // BookService options:
    else if (input == '5')
    {
        Console.WriteLine("Enter member ID: ");
        int ID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Title: ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter Author: ");
        string author = Console.ReadLine();

        Console.WriteLine("Enter Genre: ");
        string genre = Console.ReadLine();

        Console.WriteLine("Enter Published Year: ");
        int publishedYear = Convert.ToInt32(Console.ReadLine());

        BookService.AddBook(ID, title, author, genre, publishedYear);
    }
    else if (input == '6')
    {
        BookService.GetAllBooks();
        Console.WriteLine('\n');
    }
    else if (input == '7')
    {
        BookService.UpdateBook();
    }
    else if (input == '8')
    {
        BookService.DeleteBook();
    }
    else if (input == '+')
    {
        int memberID, bookID;

        Console.WriteLine("Enter member ID: ");
        memberID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter book ID: ");
        bookID = Convert.ToInt32(Console.ReadLine());

        LibraryService.BorrowBook(memberID, bookID);
    }
    else if (input == '-')
    {
        int memberID, bookID;

        Console.WriteLine("Enter member ID: ");
        memberID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter book ID: ");
        bookID = Convert.ToInt32(Console.ReadLine());

        LibraryService.ReturnBook(bookID);
    }
    else
    {
        Console.WriteLine("Invalid input, Try again!");
    }
}