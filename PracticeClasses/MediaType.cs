using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class MediaType
    {
        public string Title;
        public string Loanee;
        public bool OnLoan;

        // TODO: Test 
        // Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        public MediaType(string title)
        {
            if ( string.IsNullOrEmpty(title) )
            {
                //throw new NullReferenceException("A media type must have a title!");
                throw new Exception("A media type must have a title!");
            }
            Title = title;
        }

        // UNDONE: Test
        // Method overload
        public void Loan()
        {
            OnLoan = true;
        }

        // HACK: help
        public void Loan(string loanee)
        {
            Loanee = loanee;
            Loan();
        }

        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }
    }
}
