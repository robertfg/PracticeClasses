using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Book : MediaType
    {
        // Fields
        public readonly string Author;

        // Call constructor
        public Book(string title, string author)
            : base(title)
        {
            Author = author;
        }

        public string GetDisplayText()
        {
            string text = "Album " + Title + " is by " + Author;
            return OnLoan
                ? !string.IsNullOrEmpty(Loanee)
                    ? text += " and is on loan to " + Loanee + "."
                    : text += " and is on loan."
                : text += ".";
        }
    }
}
