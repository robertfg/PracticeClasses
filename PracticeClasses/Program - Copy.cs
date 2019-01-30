using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Program1
    {
        static void Main1(string[] args)
        {
            // Instantiate movie object and set values
            //var movie = new Movie();
            /*Movie movie = new Movie();
            movie.Title = "Casablanca";
            movie.Director = "Michael Curtiz";
            movie.Actors = new string[3]{"Humphrey Bogart", "Ingrid Bergman", "Claude Rains"};*/

            Movie movie = new Movie("On the Waterfront", "Elia Kazan", new string[3]{ "Marlon Brando", "Eva Marie Saint", "Karl Malden" });

            Console.WriteLine("Movie title: " + movie.Title);
            Console.WriteLine("Movie director: " + movie.Director);
            Console.Write("Movie actors: " + movie.Actors[0]);
            Console.Write(", " + movie.Actors[1]);
            Console.WriteLine(", " + movie.Actors[2]);

            // Instantiate book object and set values
            //var book = new Book();
            /*Book book = new Book();
            book.Title = "As I Lay Dying";
            book.Author= "William Faulkner";*/

            Book book = new Book("Brideshead Revisited", "Evelyn Waugh");

            Console.WriteLine("Book title: " + book.Title);
            Console.WriteLine("Book author: " + book.Author);

            // Instantiate album object and set values
            //var album = new Album();
            /*Album album = new Album();
            album.Title = "Revolver";
            album.Artist = "The Beatles";*/

            Album album = new Album("Home", "The Corrs");

            Console.WriteLine("Album title: " + album.Title);
            Console.WriteLine("Album artist: " + album.Artist);

            /*album.Title = "Who's Next?";
            album.Artist = "The Who";*/

            Console.WriteLine("Album title: " + album.Title);
            Console.WriteLine("Album artist: " + album.Artist);

            Console.ReadLine();

        }
    }
}
