using System;
using System.Collections.Generic;
using System.Text;

namespace library
{
    class Book
    {
        string Title;
        string Author;
        string ISBN;

        //Example of a constructor that allows us to 'construct' a new Book object
        public Book(string booktitle, string bookauthor, string bookisbn)
        {
            this.Title = booktitle;
            this.Author = bookauthor;
            this.ISBN = bookisbn;
        }

        void DisplayInfo()
        {
            Console.WriteLine("Book Title: {Title}");
            Console.WriteLine("Book Author: {Author}");
            Console.WriteLine("Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }

}

