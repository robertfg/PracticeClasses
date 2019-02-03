using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Album : MediaType
    {
        // Fields
        public readonly string Artist;

        // Call constructor
        public Album(string title, string artist)
            : base(title)
        {
            Artist = artist;
        }

        public string GetDisplayText()
        {
            string text = "Album " + Title + " is by " + Artist;
            return OnLoan
                ? !string.IsNullOrEmpty(Loanee)
                    ? text += " and is on loan to " + Loanee + "."
                    : text += " and is on loan."
                :   text += ".";
        }
    }
}
