using MiniProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MiniProject.Services;

namespace MiniProject.Models
{
    class Book : LibraryItem,IBorrowReturn
    {
        public Genre Genre { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(int id, string title, string author, int year, Genre genre, bool isBorrowed)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
            IsBorrowed = isBorrowed;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Author} | {Title} | {Genre}");
        }

        public void Borrow()
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                Console.WriteLine($"You have borrowed '{Title}'.");
                FileManager.Add(new List<Book> {this});
            }
            else
            {
                Console.WriteLine($"'{Title}' is already borrowed.");
            }
        }
        public void Return() 
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine($"You have successfully returned {Title}");
                FileManager.Add(new List<Book> { this });
            }
            else
            {
                Console.WriteLine($"'{Title}' is already returned.");
            }
        }


    }
}
