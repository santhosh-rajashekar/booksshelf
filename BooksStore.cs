using BooksManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BooksShelf
{
    public class BooksStore
    {
        List<Book> books;

        public BooksStore()
        {
            books = new List<Book>();
        }

        public List<Book> LoadBooksFromCvs(string filename)
        {
            // read csv and prepare the list of Books object
            var booksData = File.ReadAllLines(filename);

            for (int i = 1; i < booksData.Length; i++)
            {
                var bookInfo = booksData[i].Split(';');
                var book = new Book()
                {
                    Title = bookInfo[0],
                    Author = bookInfo[1],
                    Year = bookInfo[2],
                    Price = bookInfo[3],
                    InStock = bookInfo[4] == "yes" ? true : false,
                    Binding = bookInfo[5],
                    Description = bookInfo[6],
                };
                books.Add(book);
            }

            return books;
        }

        public List<Book> getBooksOnlyInStock()
        {
            return books.Where(book => book.InStock == true).ToList();
        }
        
        public string getDescription(string title)
        {
            return books.Where(book => book.Title == title).FirstOrDefault().Description;
        }
    }
           
}
