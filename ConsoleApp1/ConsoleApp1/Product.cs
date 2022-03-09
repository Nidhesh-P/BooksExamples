using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ComplexTypes
{
    class Product: ITaggable
    {
        public Product()
        { }

        public Product(int id, string name, string type)
        {
            ID = id;
            Name = name;
            Type = type;
        }
        

        public List<string> Tags { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public void AddTag(string tag)
        {
            Tags.Add(tag);
        }

        public string GetProductDescription()
        {
            return "The type of the product is: " + Type + ". ID: " + ID + " And the name of the product is: " + Name.Substring(4);
        }

        public List<string> GetTags()
        {
            return Tags;
        }

        public void RemoveTag(string tag)
        {
           
        }
    }
}
