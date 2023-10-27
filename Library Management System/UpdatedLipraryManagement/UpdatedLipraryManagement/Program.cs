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
            Console.WriteLine("2 - Display Books");
            Console.WriteLine("3 - Search by Title");
            Console.WriteLine("4 - Search by ID");
            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add Book Options:");
                        Console.WriteLine("1 - Add Reference Book");
                        Console.WriteLine("2 - Add Fiction Book");
                        Console.Write("Enter your choice: \n" );
                        int addBookChoice;
                        if (int.TryParse(Console.ReadLine(), out addBookChoice))
                        {
                            switch (addBookChoice)
                            {
                                case 1:
                                case 2:
                                    Console.Write("Enter Book ID: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.Write("Enter Title: ");
                                    string title = Console.ReadLine();
                                    Console.Write("Enter Author: ");
                                    string author = Console.ReadLine();
                                    Console.Write("Enter Publish Year: ");
                                    int publishYear = int.Parse(Console.ReadLine());

                                    if (addBookChoice == 1)
                                    {
                                        Console.Write("Enter Reference Code: ");
                                        int referenceCode = int.Parse(Console.ReadLine());

                                        ReferenceBook referenceBook = new ReferenceBook(id, title, author, publishYear, referenceCode);
                                        library.AddBook(referenceBook);
                                    }
                                    else if (addBookChoice == 2)
                                    {
                                        Console.Write("Enter Genre: ");
                                        string genre = Console.ReadLine();
                                        FictionBook fictionBook = new FictionBook(id, title, author, publishYear, genre);
                                        library.AddBook(fictionBook);
                                    }
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

                    case 2:
                        library.DisplayBooks();
                        break;

                    case 3:
                        Console.Write("Enter Title to Search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchByTitle(searchTitle);
                        break;

                    case 4:
                        Console.Write("Enter ID to Search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        library.SearchById(searchId);
                        break;

                    case 0:
                        Console.WriteLine("Goodbye!");
                        return; // Exit the program
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
        } while (true);
    }
}

enum BookType
{
    Reference,
    Fiction
}

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishYear { get; set; }
    public BookType BookType { get; set; }

    public Book(int id, string title, string author, int publishYear, BookType bookType)
    {
        Id = id;
        Title = title;
        Author = author;
        PublishYear = publishYear;
        BookType = bookType;
    }
}

class ReferenceBook : Book
{
    public int ReferenceCode { get; set; }

    public ReferenceBook(int id, string title, string author, int publishYear, int referenceCode)
        : base(id, title, author, publishYear, BookType.Reference)
    {
        ReferenceCode = referenceCode;
    }
}

class FictionBook : Book
{
    public string Genre { get; set; }

    public FictionBook(int id, string title, string author, int publishYear, string genre)
        : base(id, title, author, publishYear, BookType.Fiction)
    {
        Genre = genre;
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully! \n" );
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books in the library:  \n");
        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Publish Year: {book.PublishYear}");
            if (book is ReferenceBook reference)
            {
                Console.WriteLine($"Book Type: Reference");
                Console.WriteLine($"Reference Code: {reference.ReferenceCode}");
            }
            else if (book is FictionBook fiction)
            {
                Console.WriteLine($"Book Type: Fiction");
                Console.WriteLine($"Genre: {fiction.Genre}");
            }
        }
    }

    public void SearchByTitle(string title)
    {
        Console.WriteLine("Books found by title: \n");
        foreach (var book in books)
        {
            if (string.Equals(book.Title, title, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(book);
            }
        }
    }

    public void SearchById(int id)
    {
        Console.WriteLine("Books found by ID: \n");
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                DisplayBook(book);
            }
        }
    }

    private void DisplayBook(Book book)
    {
        Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Publish Year: {book.PublishYear}");
        if (book is ReferenceBook reference)
        {
            Console.WriteLine($"Book Type: Reference");
            Console.WriteLine($"Reference Code: {reference.ReferenceCode}");
        }
        else if (book is FictionBook fiction)
        {
            Console.WriteLine($"Book Type: Fiction");
            Console.WriteLine($"Genre: {fiction.Genre}");
        }
    }
}
