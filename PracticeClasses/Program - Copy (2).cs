using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Program2
    {
        static void Main2(string[] args)
        {
            // Instantiate objects:
            Movie movie = new Movie("On the Waterfront", "Elia Kazan", new string[3]{ "Marlon Brando", "Eva Marie Saint", "Karl Malden" });
            Book book = new Book("Brideshead Revisited", "Evelyn Waugh");
            Album album1 = new Album("Home", "The Corrs");
            Album album2 = new Album("Revolver", "The Beatles");
            Album album3 = new Album("Pet Sounds", "The Beach Boys");

            Console.WriteLine(movie.GetDisplayText());
            Console.WriteLine(book.GetDisplayText());
            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(album3.GetDisplayText());
            Console.WriteLine();

            album1.Loan("Robert");
            Console.WriteLine(album1.GetDisplayText());

            album1.Return();
            Console.WriteLine(album1.GetDisplayText());

            album1.Loan();
            Console.WriteLine(album1.GetDisplayText());

            Console.ReadLine();

        }
    }
}
