using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Book1
    {
        // Fields
        /*public string Title;
        public string Author;*/
        public readonly string Title;
        public readonly string Author;

        public Book1(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string GetDisplayText()
        {
            return "The book " + Title + " is by " + Author + ".";
        }

    }
}
