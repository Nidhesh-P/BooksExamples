using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }        

        //Default constructor
        public Book() { }

        //overloaded constructor
        public Book(int id)
        {
            ID = id;
        }


        //overloaded constructor
        public Book(int id, string title)
        {
            ID = id;
            Title = title;
        }

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
    }
}
