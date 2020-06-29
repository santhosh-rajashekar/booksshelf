using System;
using System.Collections.Generic;
using System.Text;

namespace BooksManager
{
    public enum Binding
    {
        Paperback,
        Hardcover,
        Coalwood,
        Unknown
    };

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public string Year { get; set; }
        public Boolean InStock { get; set; }
        public string Binding { get; set; }
        public string Description { get; set; }
    }


}
