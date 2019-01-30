using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Album
    {
        // Fields
        /*public string Title;
        public string Artist;*/
        public readonly string Title;
        public readonly string Artist;

        // It is not necessary to initialize these, but I did anyway.
        /*public string Loanee = null;
        public bool OnLoan = false;*/

        // Set implicitly:
        public string Loanee;
        public bool OnLoan;

        public Album(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        public string GetDisplayText()
        {
            /*return  OnLoan
                ?   "The album " + Title + " is by " + Artist + ", on loan to " + Loanee
                :   "The album " + Title + " is by " + Artist + ".";*/

            string text = "The album " + Title + " is by " + Artist;

            if ( OnLoan )
            {
                //if ( Loanee != null  &&  Loanee != "" )
                if ( !string.IsNullOrEmpty(Loanee) )
                {
                    text += ", on loan to " + Loanee;
                }
                else
                {
                    text += " is on loan.";
                }
            }
            else
            {
                text += ".";
            }

            return text;
        }

        // Method overload
        public void Loan()
        {
            OnLoan = true;
        }

        public void Loan(string loanee)
        {
            Loanee = loanee;
            // Instead of setting OnLoan again, just call Loan()
            //OnLoan = true;
            Loan();
        }

        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }
    }
}
