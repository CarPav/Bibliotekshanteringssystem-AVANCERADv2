using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekshanteringssystem_AVANCERAD
{
    public class Book
    {
        public string Title { get; set; }
        public int ID { get; set; }
        public string Author { get; set; } // Denna skall länkas till författare
        public string Genre { get; set; }
        public int YearPublished { get; set; }
        public int ISBN { get; set; }
        public List<int> Reviews {  get; set; }

        // Konstruktor
        public Book (string title, int id, string author, string genre, int yearPublished, int isbn, List<int> reviews)
        {
            Title = title;
            ID = id;
            Author = author;
            Genre = genre;
            YearPublished = yearPublished;
            ISBN = isbn;
            Reviews = reviews;
        }
     
    }
}
