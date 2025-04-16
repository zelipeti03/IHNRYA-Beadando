using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHNRYA_Beadando.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public Book(string title, string author, int year, string isbn)
        {
            Title = title;
            Author = author;
            Year = year;
            ISBN = isbn;
        }

        protected virtual string SearchString => $"{Title}|{Author}|{Year}|{ISBN}";

        public bool MatchesSearch(string searchString)
        {
            return SearchString.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase);
        }
        public override string ToString() => Title;
    }
}
