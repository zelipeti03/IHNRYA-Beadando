using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHNRYA_Beadando.Models
{
    public class EBook: Book
    {
        public string FileFormat { get; set; }
        public EBook(string title, string author, int year, string isbn, string fileFormat)
            : base(title, author, year, isbn)
        {
            FileFormat = fileFormat;
            
        }
       protected override string SearchString => $"{base.SearchString}|{FileFormat}";
    }
}
