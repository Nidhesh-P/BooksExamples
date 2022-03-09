using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FictionBook: Book, ITaggable
    {
        public string Type { get; set; }

        public Dictionary<int,string> Tags { get; set; }

        public void AddTag(string tag)
        {
            if (Tags == null)
            {
                Tags = new Dictionary<int, string>();
            }
            if (!Tags.Any())
            {
                Tags.Add(1, tag);
            }
            else
            {
                Tags.Add(Tags.Last().Key + 1, tag);
            }
        }

        public List<string> GetTags()
        {
            return Tags.Select(x => x.Value).ToList();
        }

        public void RemoveTag(string tag)
        {
            Tags.Remove(Tags.Where(y => y.Value == tag).First().Key);
        }

        public new string GetDetails()
        {
            return $"{ID}) {Title} written by {Author} and is type {Type}.";
        }

        public string GetDescription()
        {
            string title = GetTitle();
            return "Description: EMpty" + title;
        }
    }
}
