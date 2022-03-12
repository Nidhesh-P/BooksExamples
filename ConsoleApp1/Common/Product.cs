using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ConsoleApp1.ComplexTypes
{
    public class Product:IInvoice
    {
        public Product()
        { }

        public Product(int id, string name, string type)
        {
            ID = id;
            Name = name;
            Type = type;
            InvoiceID = new Guid();
            InvoiceTitle = $"Invoice_Product_{Name}_Type_{Type}";
        }
        

        public List<string> Tags { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Guid InvoiceID { get; set ; }
        public string InvoiceTitle { get ; set ; }

        public void AddTag(string tag)
        {
            Tags.Add(tag);
        }

        public string GenerateInvoice()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(InvoiceTitle);
            sb.AppendLine("======================================");

            sb.AppendLine("Item________________________________Price");
            sb.AppendLine($"{ID})Title________________________________Product is free for now");
            sb.AppendLine($"Leave your feedback at www.google.com");
            sb.AppendLine("======================================");

            return sb.ToString();
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
