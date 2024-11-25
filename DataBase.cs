using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bibliotekshanteringssystem_AVANCERAD
{
    public class DataBase
    {
        [JsonPropertyName("books")]
        public List<Book> allBooksFromDB { get; set; }

        [JsonPropertyName("authors")]
        public List<Author> allAuthorsFromDB { get; set; }
    }
}
