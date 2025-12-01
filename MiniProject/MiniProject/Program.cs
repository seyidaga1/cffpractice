using MiniProject.Models;
using MiniProject.Services;

namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book_1 = new Book(1, "1984", "George Orwell", 1949, Genre.Drama, false);
            //Book book_2 = new Book(2, "To Kill a Mockingbird", "Harper Lee", 1960, Genre.Fiction, true);
            //Book book_3 = new Book(3, "The Great Gatsby", "F. Scott Fitzgerald", 1925, Genre.Romance, false);

            List<Book> books = FileManager.Show();
            // yeni kitabi liste elave edirem, bu listin oz methodu ile
            //books.Add(new Book(4, "The Catcher in the Rye", "J.D. Salinger", 1951, Genre.Mystery, false));
            books.ForEach(book =>
            {
                book.DisplayInfo();
            });

            // yenilenmis listi jsona elave edirem, bu add methodu filemanagerin oz methodudur
            FileManager.Add(books);
            //Console.WriteLine(FileManager.Show());

            books[0].Borrow();

        }
    }
}
