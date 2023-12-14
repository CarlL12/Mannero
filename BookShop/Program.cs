using BookShop.Classes;
using BookShop.Interfaces;

namespace BookShop
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            List<IBook> books = new List<IBook>();
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("#### MENY ###");
                Console.WriteLine("1. Lägg till bok i lista");
                Console.WriteLine("2. Visa alla böcker");
                Console.WriteLine("3. Visa specifik bok");
                Console.Write("Skriv ditt val: ");

                int option = int.Parse(Console.ReadLine()!);
                Console.Clear();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Vad för bok vill du lägga till?:");
                        Console.WriteLine("1. AudioBook");
                        Console.WriteLine("2. Book");
                        Console.WriteLine("3. LoanBook");

                        int BookOption = int.Parse(Console.ReadLine()!);

                        switch (BookOption)
                        {
                            case 1:
                                {
                                    string type = "Audiobook";
                                    Console.Write("Skriv titel på bok: ");
                                    string title = Console.ReadLine()!;
                                    Console.Write("Skriv författare för boken: ");
                                    string author = Console.ReadLine()!;
                                    Console.Write("Skriv ISBN-nummer: ");
                                    string isbn = Console.ReadLine()!;
                                    Console.Write("Skriv längd på ljudbok: ");
                                    int duration = int.Parse(Console.ReadLine()!);
                                    AudioBook newBook1 = new AudioBook(type, author, title, isbn, duration);
                                    books.Add(newBook1);
                                    break;
                                }

                            case 2:
                                {
                                    string type = "Book";
                                    Console.Write("Skriv titel på bok: ");
                                    string title = Console.ReadLine()!;
                                    Console.Write("Skriv författare för boken: ");
                                    string author = Console.ReadLine()!;
                                    Console.Write("Skriv ISBN-nummer: ");
                                    string isbn = Console.ReadLine()!;
                                    Book newBook2 = new Book(type, author, title, isbn);
                                    books.Add(newBook2);
                                    break;
                                }

                            case 3:
                                {
                                    string type = "LoanBook";
                                    Console.Write("Skriv titel på bok: ");
                                    string title = Console.ReadLine()!;
                                    Console.Write("Skriv författare för boken: ");
                                    string author = Console.ReadLine()!;
                                    Console.Write("Skriv ISBN-nummer: ");
                                    string isbn = Console.ReadLine()!;
                                    Console.Write("Skriv hur många dagar kvar av lånetid: ");
                                    int loan = int.Parse(Console.ReadLine()!);
                                    LoanBook newBook3 = new LoanBook(type, author, title, isbn, loan);
                                    books.Add(newBook3);
                                    break;
                                }
                        }

                        break;
                    case 2:
                        Console.Clear();
                        if (books.Count == 0)
                        {
                            Console.WriteLine("Listan är tom");
                        }
                        else 
                        {
                            foreach (var book in books)
                            {
                               switch (book)
                                {
                                    case AudioBook audiobook:
                                        Console.WriteLine($"Book type: {audiobook.type},Titel: {audiobook.title}, Author: {audiobook.author}, ISBN-Number: {audiobook.isbn}, Duration: {audiobook.duration}");
                                        break;
                                    case Book ordbook:
                                        Console.WriteLine($"Book type: {ordbook.type},Titel: {ordbook.title}, Author: {ordbook.author}, ISBN-Number: {ordbook.isbn}");
                                        break;
                                    case LoanBook loanbook:
                                        Console.WriteLine($"Book type: {loanbook.type},Titel: {loanbook.title}, Author: {loanbook.author}, ISBN-Number: {loanbook.isbn}, LoanTime: {loanbook.DueDate}");
                                        break;
                                }
                                    
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Ange ISBN-nummer för att hitta specifik bok:");
                        string number  = Console.ReadLine()!;
                        IBook foundBook = books.Find(book => book.isbn == number);
                        switch (foundBook)
                        {
                            case AudioBook audiobook:
                                Console.WriteLine($"Book type: {audiobook.type},Titel: {audiobook.title}, Author: {audiobook.author}, ISBN-Number: {audiobook.isbn}, Duration: {audiobook.duration}");
                                break;
                            case Book ordbook:
                                Console.WriteLine($"Book type: {ordbook.type},Titel: {ordbook.title}, Author: {ordbook.author}, ISBN-Number: {ordbook.isbn}");
                                break;
                            case LoanBook loanbook:
                                Console.WriteLine($"Book type: {loanbook.type},Titel: {loanbook.title}, Author: {loanbook.author}, ISBN-Number: {loanbook.isbn}, LoanTime: {loanbook.DueDate}");
                                break;
                        }
                        break;

                }
                Console.ReadKey();
            }

            
       
        }

    }


}
