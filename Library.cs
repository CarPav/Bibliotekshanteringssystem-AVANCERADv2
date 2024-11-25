using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bibliotekshanteringssystem_AVANCERAD
{
    public class Library
    {
        string dataJSONfilPath = "LibraryData.json";
        public List<Book> allBooks = new List<Book>();
        public List<Author> allAuthors = new List<Author>();

        public Library()
        {
            // READ DATA FROM JSON
            string allDataFromJson = File.ReadAllText(dataJSONfilPath);

            // CREATE A DB Database
            DataBase ImportedDB = JsonSerializer.Deserialize<DataBase>(allDataFromJson)!;

            // Sätter värdena till Library
            allBooks = ImportedDB!.allBooksFromDB;
            allAuthors = ImportedDB!.allAuthorsFromDB;
        }

        public void AddNewBook(List<Book> allBooks)
        {
            Console.Write("Bokens titel: ");
            string addTitle = Console.ReadLine()!;

            Console.Write("Bokens ID: ");
            int addID = Convert.ToInt32(Console.ReadLine()!)!;

            Console.Write("Bokens författare: ");
            string addAuthor = Console.ReadLine()!;

            Console.Write("Bokens Genre: ");
            string addGenre = Console.ReadLine()!;

            Console.Write("Bokens publiceringsår: ");
            int addYear = Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Bokens ISBN-nr: ");
            int addISBN = Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Ge boken ett betyg mellan 1-5: ");
            int addReview = Convert.ToInt32(Console.ReadLine()!);

            Book bookToAdd = new Book(addTitle, addID, addAuthor, addGenre, addYear, addISBN, [addReview]);
            bool isbnAlreadyExcists = allBooks.Any(book => book.ISBN == bookToAdd.ISBN);

            if (isbnAlreadyExcists)
            {
                Console.WriteLine("Denna boken finns redan i Biblioteket!");
            }
            else
            {
                allBooks.Add(bookToAdd);
                Console.WriteLine($"Din bok med titeln {bookToAdd.Title} har lagts till i Biblioteket");
            }
        }
        public void AddNewAuthor()
        {
            //allAuthors.Add(new Author());
        }
        public void UpdateBook()
        {

        }
        public void UpdateAuthor()
        {

        }
        public void RemoveBook()
        {

        }
        public void RemoveAuthor()
        {

        }
        public void ShowAllBooksAndAuthors()
        {
            Console.WriteLine("Vilken lista vill du visa?");
            Console.WriteLine("1. Alla böcker?");
            Console.WriteLine("2. Alla författare");

            string userOptionShow = Console.ReadLine()!;
            switch (userOptionShow)
            {
                case "1":

                    Console.WriteLine("Nedan visas alla böcker som finns i biblioteket");

                    foreach (var book in allBooks)
                    {
                        Console.WriteLine("\nBOK");
                        Console.WriteLine($"\nTitel: {book.Title}");
                        Console.WriteLine($"ID: {book.ID}");
                        Console.WriteLine($"Författare: {book.Author}");
                        Console.WriteLine($"Publiceringsår: {book.YearPublished}");
                        Console.WriteLine($"ISBN: {book.ISBN}");
                        Console.WriteLine($"Betyg: {book.Reviews}");
                    }
                    break;
                case "2":

                    Console.WriteLine("Nedan visas alla författare som finns i biblioteket");

                    foreach (var author in allAuthors)
                    {
                        Console.WriteLine("\nFÖRFATTARE");
                        Console.WriteLine($"\nNamn: {author.Name}");
                        Console.WriteLine($"ID: {author.ID}");
                        Console.WriteLine($"Nationalitet: {author.Country}");
                    }
                    break;
                default:
                    Console.WriteLine("Ogiltligt val, försök igen");
                    break;
            }
            Console.ReadKey();
        }
        public void SearchAndFilter()
        {

        }
        public void SaveAndExit()
        {
            Console.WriteLine("Tack för du använde Minibibblan, välkommen åter!");
            DataBase updatedDB = new DataBase();
            updatedDB.allAuthorsFromDB = allAuthors;
            updatedDB.allBooksFromDB = allBooks;
            string updateJson = JsonSerializer.Serialize(updatedDB, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataJSONfilPath, updateJson);
        }
    }
}
