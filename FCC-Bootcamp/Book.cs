using System;
using System.Text;
using System.Threading.Tasks;

namespace FCC_Bootcamp
{
    class Book
    {
        public string title;
        public string author;
        public int pageCount;
        
        // This is a special method that gets called when you create the class
        // a Constructor
        // I think this is like python's __init__
        public Book(string aTitle, string aAuthor, int aPages)
        {   
            this.title = aTitle;
            this.author = aAuthor;
            this.pageCount = aPages;
        }

        public string Title
        {
            get { return title; }
            set { title = value;}
        }
    }
}