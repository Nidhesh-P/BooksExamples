using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ConsoleApp1
{
    public class CourseBook : Book, ITaggable, IInvoice
    {
        private List<string> tags;

        public string Subject { get; set; }

        public Guid InvoiceID { get; set; }
        public string InvoiceTitle { get; set; }

        public CourseBook(){ }

        public CourseBook(int id, string title, string author, string subject)
        {
            ID=id;
            Author=author;
            Title=title;
            Subject = subject;
            InvoiceID= new Guid();
            InvoiceTitle = $"Invoice_{Title}_Writer_{Author}_Subject_{Subject}";
        }

        public void AddTag(string tag)
        {
            if (ID ==2)
            {
                if (tags == null)
                {
                    tags = new List<string>();
                }

                if (String.Equals(tag, "Maths", StringComparison.InvariantCultureIgnoreCase))
                {
                    tags.Add("Mathematics");
                }
            }

           tags.Add(tag.ToUpper());
        }

        public string GenerateInvoice()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine(InvoiceTitle);
            sb.AppendLine("======================================");

            sb.AppendLine("Item________________________________Price");
            sb.AppendLine("Title________________________________Free for now (we didn't do the maths yet)");
            sb.AppendLine("======================================");
            
            return sb.ToString();
        }

        public List<string> GetTags()
        {
            return tags;
        }

        public void RemoveTag(string tag)
        {
            tags.Remove(tag);
        }
    }
}
