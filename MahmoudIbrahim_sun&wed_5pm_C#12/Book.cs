using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmoudIbrahim_sun_wed_5pm_C_12
{

    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate,
        decimal Price)
        {
            this.ISBN = _ISBN;
            this.Title = _Title;
            this.Authors = _Authors;
            this.PublicationDate = _PublicationDate;
            this.Price = Price;
        }
        public override string ToString()
        {
            if (this != null)
            {
                return this.ISBN + " " + this.Title + " " + this.Authors + " " + this.PublicationDate + " " + this.Price;
            }

            return "";
        }
    }

    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }
        public static decimal GetPrice(Book book)
        {
            return book.Price;
        }
        public static string GetISBN(Book book)
        {
            return book.ISBN;
        }
        public static DateTime GetPublicationDate(Book book)
        {
            return book.PublicationDate;
        }
        public static string[] GetAuthors(Book book)
        {
            return book.Authors;
        }
    }
}