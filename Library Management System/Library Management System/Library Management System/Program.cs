

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Library Management System");
        Library library = new Library();

        do
        {
            Console.WriteLine("1 - Add Book");
            Console.WriteLine("3 - Display Books");
            Console.WriteLine("4 - Search by Title");
            Console.WriteLine("5 - Search by ID");
            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: \n");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add Book Options:");
                        Console.WriteLine("1 - Add Reference Book");
                        Console.WriteLine("2 - Add Fiction Book");
                        Console.Write("Enter your choice: ");
                        int addBookChoice;
                        if (int.TryParse(Console.ReadLine(), out addBookChoice))
                        {
                            switch (addBookChoice)
                            {
                                case 1:
                                    AddReferenceBook(library);
                                    break;

                                case 2:
                                    AddFictionBook(library);
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        }

                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case 3:
                        library.DisplayBooks();
                        break;

                    case 4:
                        Console.Write("Enter Title to Search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchByTitle(searchTitle);
                        break;

                    case 5:
                        Console.Write("Enter ID to Search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        library.SearchById(searchId);
                        break;

                    case 0:
                        Console.WriteLine("Goodbye!");
                        return; // Exit the program

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (true);
    }

    static void AddReferenceBook(Library library)
    {
        Console.Write("Enter Reference Book ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Author: ");
        string author = Console.ReadLine();
        Console.Write("Enter Publish Year: ");
        int publishYear = int.Parse(Console.ReadLine());
        Console.Write("Enter Reference Code: ");
        string referenceCode = Console.ReadLine();

        ReferenceBook referenceBook = new ReferenceBook(id, title, author, publishYear, referenceCode);
        library.AddBook(referenceBook);
    }

    static void AddFictionBook(Library library)
    {
        Console.Write("Enter Fiction Book ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Author: ");
        string author = Console.ReadLine();
        Console.Write("Enter Publish Year: ");
        int publishYear = int.Parse(Console.ReadLine());

        Fiction fiction = new Fiction(id, title, author, publishYear);
        library.AddBook(fiction);
    }
}

enum BookType
{
    Reference,
    Fiction

}

class AddBook
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishYear { get; set; }
}

class ReferenceBook : AddBook
{
    public string ReferenceCode { get; set; }

    public ReferenceBook(int id, string title, string author, int publishYear, string referenceCode)
    {
        Id = id;
        Title = title;
        Author = author;
        PublishYear = publishYear;
        ReferenceCode = referenceCode;
    }
}

class Fiction : AddBook
{
    public Fiction(int id, string title, string author, int publishYear)
    {
        Id = id;
        Title = title;
        Author = author;
        PublishYear = publishYear;
    }
}

class Library
{
    private List<AddBook> books = new List<AddBook>();

    public void AddBook(AddBook book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully! \n ");
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books in the library: /n");

        foreach (var book in books)
        {


            if (book is ReferenceBook reference)
            {
                Console.WriteLine($"ID: {reference.Id}, Title: {reference.Title}, Author: {reference.Author}, Publish Year: {reference.PublishYear}");
                Console.WriteLine($"Reference Code: {reference.ReferenceCode}");

            }
            else if (book is Fiction fiction)
            {
                Console.WriteLine($"ID: {fiction.Id}, Title: {fiction.Title}, Author: {fiction.Author}, Publish Year: {fiction.PublishYear}");
                Console.WriteLine($"Book Type: Fiction \n");
            }

        }

    }


    public void SearchByTitle(string title)
    {
        bool found = false;

        Console.WriteLine("Books found by title:  \n");
        foreach (var book in books)
        {
            if (book.Title != null && book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                if (book is ReferenceBook reference)
                {
                    Console.WriteLine($"ID: {reference.Id}, Title: {reference.Title}, Author: {reference.Author}, Publish Year: {reference.PublishYear}");
                    Console.WriteLine($"Reference Code: {reference.ReferenceCode}");
                }
                else if (book is Fiction fiction)
                {
                    Console.WriteLine($"ID: {fiction.Id}, Title: {fiction.Title}, Author: {fiction.Author}, Publish Year: {fiction.PublishYear}");
                    Console.WriteLine($"Book Type: Fiction  \n");
                }

            }


        }

        if (!found)
        {
            Console.WriteLine("No books found with this title.");
        }
    }



    public void SearchById(int id)
    {
        Console.WriteLine("Book found by ID:");

        foreach (var book in books)
        {
            if (book.Id == id)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Publish Year: {book.PublishYear}");

                if (book is ReferenceBook reference)
                {
                    Console.WriteLine($"Reference Code: {reference.ReferenceCode}");
                }
                else if (book is Fiction fiction)
                {
                    Console.WriteLine($"Book Type: Fiction");
                }

                return;
            }
        }

        Console.WriteLine("No book found with this ID.");
    }



}

