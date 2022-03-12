using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }        

        //Default constructor
        public Book():this(0) { }

        //overloaded constructor
        public Book(int id):this(id,string.Empty)
        { }

        //overloaded constructor
        public Book(int id, string title):this(id, title, String.Empty)
        {}

        //overloaded constructor
        public Book(int id, string title, string author)
        {
            ID = id;
            Title = title;
            Author = author;
        }

        public string GetDetails()
        {
            return $"{ID}) {Title} written by {Author}.";
        }

        public string GetTitle()
        {
            return "The Title is " + Title;
        }
    }
}
