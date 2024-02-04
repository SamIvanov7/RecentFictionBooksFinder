using System;
using System.Collections.Generic;

namespace SolarPowerEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>
            {
                new Book("Shantaram", "David Henry", 2012, "Fiction"),
                new Book("Some-Book-Title 2", "Author of Book 2", 2008, "Non-Fiction"),
                new Book("Ich will nicht", "Grey Bmw Wolf", 2015, "Deutsche Comedy"),
                new Book("Some-Book-Title 3", "Author of Book 3", 2008, "Fiction"),
            };

            var recentFictionBooks = BookCollection.FindRecentFictionBooks(books);

            Console.WriteLine("Fiction books published after 2010:");
            foreach (var book in recentFictionBooks)
            {
                Console.WriteLine($"{book.Title} by {book.Author} ({book.YearOfPublication})");
            }
        }
    }
}
