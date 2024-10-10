// Övning 1: Bibliotekssystem
/*Beskrivning: Skapa ett program som hanterar en enkel databas av böcker. Användaren ska kunna lägga till nya böcker, ta bort böcker och visa alla böcker som finns i biblioteket.

Instruktioner:

Skapa en klass Bok som har egenskaperna: Titel, Författare och ISBN.
Skapa en klass Bibliotek som hanterar en lista av böcker.
Programmet ska ha en meny där användaren kan:
Lägga till en bok genom att mata in titel, författare och ISBN.
Ta bort en bok baserat på ISBN.
Visa alla böcker i biblioteket.*/

using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        bool isRunning = true;
        Library library = new Library();        

        System.Console.WriteLine("Välkommen till programmet för hantering av biblioteksböcker");

        while (isRunning)
        {
            System.Console.WriteLine("*************************");
            System.Console.WriteLine("Gör ett av följande val: ");
            System.Console.WriteLine("*************************");

            System.Console.WriteLine("1. Lägg till en bok ");
            System.Console.WriteLine("2. Ta bort en bok ");
            System.Console.WriteLine("3. Visa samtliga böcker i biblioteket ");
            System.Console.WriteLine("4. Avsluta programmet ");
            System.Console.WriteLine();
            int input;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                System.Console.WriteLine("Ogiltigt val. Försök igen!");
            }

            switch(input)
            {
                case 1:
                    library.AddBook();
                    break;
                
                case 2:
                    System.Console.WriteLine("Skriv in ISBN-nummer på den bok du vill ta bort");
                    if (int.TryParse(Console.ReadLine(), out int isbn))
                    {
                        library.RemoveBook(isbn); 
                    }
                    else
                    {
                        System.Console.WriteLine("Du har angett ett felaktigt isbn-nr");                        
                    }  
                    break;              

                case 3:
                    library.PrintBooks();                   
                    break;
                
                case 4:
                    isRunning = false;
                    System.Console.WriteLine("Tack för idag!");                   
                    break;

                default:
                    System.Console.WriteLine("Ogiltigt val. Försök igen!");
                    break;

            }

        }

    }

}

public class Book
{
    public string Title {get; set;}
    public string Author {get; set;}
    public int NumISBN {get; set;}

    public Book (string title, string author, int numIsbn)
    {
        Title = title;
        Author = author;
        NumISBN = numIsbn;
    }

    public void ShowInfo()
    {
        System.Console.WriteLine($"Titel: {Title} Författare: {Author} ISBN: {NumISBN}");
    }
}

public class Library
{
    List<Book>books = new List<Book>();

    public void AddBook()
    {
        System.Console.Write("Skriv in författare: ");
        string author = Console.ReadLine();
        System.Console.Write("Skriv in titel: ");
        string title = Console.ReadLine();
        System.Console.Write("Skriv in bokens ISBN-nummer: ");
        int numIsbn = int.Parse(Console.ReadLine());

        Book book = new Book(title, author, numIsbn);
        books.Add(book);
        System.Console.WriteLine($"Boken {title} har nu lagts till i biblioteket.");      
      
    }

    public void RemoveBook(int numIsbn)
    {
       
        Book bookToRemove = books.FirstOrDefault(b => b.NumISBN == numIsbn);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            System.Console.WriteLine($"Boken med ISBN-nr {numIsbn} har tagits bort från biblioteket. ");
        }
        else
        {
            System.Console.WriteLine($"Ingen bok med ISBN {numIsbn} hittades. ");
        }     
    }    
    
    public void PrintBooks()
    {
        foreach(Book book in books)
        {
            book.ShowInfo();
        }
    }
}