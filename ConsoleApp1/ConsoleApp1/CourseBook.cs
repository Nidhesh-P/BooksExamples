using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CourseBook : Book, ITaggable
    {
        public List<string> Tags { get; set; }

        public string Subject { get; set; }

        public void AddTag(string tag)
        {
            if (Tags == null)
            {
                Tags = new List<string>();
            }
            
            if (String.Equals(tag, "Maths", StringComparison.InvariantCultureIgnoreCase))
            {
                Tags.Add("Mathematics");
            }

           Tags.Add(tag.ToUpper());
        }

        public List<string> GetTags()
        {
            return Tags;
        }

        public void RemoveTag(string tag)
        {
            Tags.Remove(tag);
        }
    }
}
