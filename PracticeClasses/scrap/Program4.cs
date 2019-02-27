using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Program4
    {
        static void Main4(string[] args)
        {
            try
            {
                //MediaType[] mediaType = new MediaType[5];
                //mediaType[0] = new Movie("On the Waterfront", "Elia Kazan", new string[3] { "Marlon Brando", "Eva Marie Saint", "Karl Malden" });
                //mediaType[1] = new Book("Brideshead Revisited", "Evelyn Waugh");
                //mediaType[2] = new Album("Home", "The Corrs");
                //mediaType[3] = new Album("Revolver", "The Beatles");
                //mediaType[4] = new Album("Pet Sounds", "The Beach Boys");

                //var mediaType = new MediaType[]
                MediaType[] mediaType =
                {
                    new Movie("On the Waterfront", "Elia Kazan",
                                new string[3] { "Marlon Brando", "Eva Marie Saint", "Karl Malden" }),
                    new Book("Brideshead Revisited", "Evelyn Waugh"),
                    new Album("Home", "The Corrs"),
                    new Album("Revolver", "The Beatles"),
                    new Album("Pet Sounds", "The Beach Boys")
                };

                // Detect the media type:
                foreach(MediaType media in mediaType)
                {
                    DetectMediaType(media);
                }

                // Display the media information
                foreach (MediaType media in mediaType)
                {
                    Display(media);
                }

                //// Loan the album
                //mediaType[0].Loan("Robert");
                //Console.WriteLine(mediaType[0].GetDisplayText());

                //album1.Return();
                //Console.WriteLine(album1.GetDisplayText());

                //album1.Loan();
                //Console.WriteLine(album1.GetDisplayText());
                //Console.WriteLine();

                //// Loan the book
                //book.Loan("Robert");
                //Console.WriteLine(book.GetDisplayText());

                //book.Return();
                //Console.WriteLine(book.GetDisplayText());

                //book.Loan();
                //Console.WriteLine(book.GetDisplayText());
                //Console.WriteLine();

                //// Loan the movie
                //movie.Loan("Robert");
                //Console.WriteLine(movie.GetDisplayText());

                //movie.Return();
                //Console.WriteLine(movie.GetDisplayText());

                //movie.Loan();
                //Console.WriteLine(movie.GetDisplayText());
                //Console.WriteLine();

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        // Methods
        static void Display(MediaType item)
        {
            // To test the exception, comment out one of the media types.
            if (item is Album)
            {
                Console.WriteLine(((Album)item).GetDisplayText());
            }
            else if (item is Book)
            {
                Console.WriteLine(((Book)item).GetDisplayText());
            }
            else if (item is Movie)
            {
                Console.WriteLine(((Movie)item).GetDisplayText());
            }
            else
            {
                throw new Exception("Unexpected media type encountered!");
            }
        }

        static void DetectMediaType(MediaType item)
        {
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
                throw new Exception("Unexpected media type encountered!");
            }
        }
    }
}
