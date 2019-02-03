using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Movie : MediaType
    {
        // Fields
        public readonly string Director;
        public readonly string[] Actors;

        // Call constructor
        public Movie(string title, string director, string[] actors)
            : base(title)
        {
            Director = director;
            Actors = actors;
        }

        public string GetDisplayText()
        {
            string text = "The movie " + Title + " was directed by "
                + Director + ", stars "
                + Actors[0] + ", "
                + Actors[1] + ", "
                + Actors[2];

            return OnLoan
                ? !string.IsNullOrEmpty(Loanee)
                    ? text += ", and is on loan to " + Loanee + "."
                    : text += ", and is on loan."
                : text += ".";
        }
    }
}
