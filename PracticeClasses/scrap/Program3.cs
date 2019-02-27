using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Program3
    {
        static void Main3(string[] args)
        {
            try
            {
                // Instantiate objects:
                Movie movie = new Movie("On the Waterfront", "Elia Kazan", new string[3] { "Marlon Brando", "Eva Marie Saint", "Karl Malden" });
                Book book = new Book("Brideshead Revisited", "Evelyn Waugh");
                Album album1 = new Album("Home", "The Corrs");
                //Album album2 = new Album(null, "The Corrs");
                //Album album3 = new Album("", "The Corrs");

                Console.WriteLine(movie.GetDisplayText());
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine();

                // Loan the album
                album1.Loan("Robert");
                Console.WriteLine(album1.GetDisplayText());

                album1.Return();
                Console.WriteLine(album1.GetDisplayText());

                album1.Loan();
                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine();

                // Loan the book
                book.Loan("Robert");
                Console.WriteLine(book.GetDisplayText());

                book.Return();
                Console.WriteLine(book.GetDisplayText());

                book.Loan();
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine();

                // Loan the movie
                movie.Loan("Robert");
                Console.WriteLine(movie.GetDisplayText());

                movie.Return();
                Console.WriteLine(movie.GetDisplayText());

                movie.Loan();
                Console.WriteLine(movie.GetDisplayText());
                Console.WriteLine();

                // Detect the media type:
                DetectMediaType(album1);
                //DetectMediaType(album2);
                //DetectMediaType(album3);
                DetectMediaType(book);
                DetectMediaType(movie);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        // Methods
        static void DetectMediaType(MediaType item)
        {
            // To test the exception, comment out one of the media types.
            if (item is Album)
            {
                Console.WriteLine(item.Title + " is an album.");
            }
            else if (item is Book)
            {
                Console.WriteLine(item.Title + " is a book.");
            }
            else if (item is Movie)
            {
                Console.WriteLine(item.Title + " is a movie.");
            }
            else
            {
                //throw new NullReferenceException("Unexpected media type encountered!");
                throw new Exception("Unexpected media type encountered!");
            }
        }
    }
}
