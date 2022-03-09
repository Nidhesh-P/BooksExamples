using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1.DatabaseObjects
{
    class TagsManager
    {
        ITaggable tags;
        Book book;
        public TagsManager(ITaggable tagClass, Book book)
        {
            tags = tagClass;
            this.book = book;
        }

        public void SaveTags()
        {
            var allTags = tags.GetTags();

            FileInfo fInfo = new FileInfo(@"C:\\Test\\NewFIle.txt");
            using (StreamWriter file = fInfo.AppendText())
            {
                file.WriteLine(book.Title + " written by " + book.Author);
                file.WriteLine("Contains Tags: " +String.Join(",",allTags));
                file.WriteLine();
            }
        }
    }
}
