using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Movie1
    {
        // Fields
        /*public string Title;
        public string Director;
        public string[] Actors;*/
        public readonly string Title;
        public readonly string Director;
        public readonly string[] Actors;

        public Movie1(string title, string director, string[] actors)
        {
            Title = title;
            Director = director;
            Actors = actors;
        }

        public string GetDisplayText()
        {
            return "The movie " + Title + " was directed by "
                + Director + " and stars "
                + Actors[0] + ", "
                + Actors[1] + ", "
                + Actors[2] + ".";
        }

    }
}
