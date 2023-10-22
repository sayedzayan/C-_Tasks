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
            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Publish Year: ");
                        int publishYear = int.Parse(Console.ReadLine());

                        library.AddBook(id, title, author, publishYear);
                        break;

                    case 2:
                        library.DisplayBooks();
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

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishYear { get; set; }

    public Book(int id, string title, string author, int publishYear)
    {
        Id = id;
        Title = title;
        Author = author;
        PublishYear = publishYear;
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(int id, string title, string author, int publishYear)
    {
        Book newBook = new Book(id, title, author, publishYear);
        books.Add(newBook);
        Console.WriteLine("Book added successfully!");
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books in the library:");
        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Publish Year: {book.PublishYear}");
        }
    }
}
