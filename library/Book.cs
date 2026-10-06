using System;
using System.Collections.Generic;
using System.Text;

namespace library
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        public void DisplayInfo()
        {
            Console.WriteLine($"BookTitle: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"BookISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
