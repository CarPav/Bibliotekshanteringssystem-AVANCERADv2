using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekshanteringssystem_AVANCERAD
{
    public class Author
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Country { get; set; } 

        // Konstruktor
        public Author(string name, int id, string country)
        {
            Name = name;
            ID = id;
            Country = country;
        }
    }
}
