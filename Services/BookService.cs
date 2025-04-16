using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHNRYA_Beadando.Models;

namespace IHNRYA_Beadando.Services
{
    public static class BookService
    {
        public static List<Book> Books { get; set; } = new List<Book>();
        public static EventHandler BooksChanged;
        private static string filePath = "books.txt";

        // sample book representation in the file:
        // Title;Author;Year;ISBN;FileFormat
        // Title;Author;Year;ISBN
        public static void Init()
        {
            if (!File.Exists(filePath))
            {
                // if the file does not exist, we create it
                File.Create(filePath).Close();
            }
            // we are using 'using' to ensure that the file is disposed once we leave this Init() function even if an exception occurs
            // we are also not using 'using' with its own block, as it is the only block in this function so that would be redundant
            using var streamReader = new StreamReader(filePath);
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                if (line == null)
                    break; // just to be safe


                string[] parts = line.Split(';');
                if (parts.Length is >= 4 and < 6)
                {
                    string title = parts[0];
                    string author = parts[1];
                    int year = int.Parse(parts[2]);
                    string isbn = parts[3];
                    // this only exists if it's an eBook
                    string? fileFormat = parts.ElementAtOrDefault(4);

                    Book book;
                    if (fileFormat != null)
                        book = new EBook(title, author, year, isbn, fileFormat);
                    else
                        book = new Book(title, author, year, isbn);
                    Books.Add(book);
                }
            }


        }

        public static void Save()
        {
            using var streamWriter = new StreamWriter(filePath);
            foreach (var book in Books)
            {
                if (book is EBook eBook)
                    streamWriter.WriteLine($"{eBook.Title};{eBook.Author};{eBook.Year};{eBook.ISBN};{eBook.FileFormat}");
                else
                    streamWriter.WriteLine($"{book.Title};{book.Author};{book.Year};{book.ISBN}");
            }
            BooksChanged.Invoke(null, EventArgs.Empty);

        }
    }
}
