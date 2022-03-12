using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Common
{
    public class InvoiceManager
    {     
        IInvoice commodity;
        public InvoiceManager(IInvoice commodity)
        {
            this.commodity=commodity;            
        }
        
        public void GenerateInvoice()
        {
            string filename = commodity.InvoiceTitle +".txt";
                
            FileInfo fInfo = new FileInfo(@"C:\\Test\\"+filename);
            using (StreamWriter file = fInfo.CreateText())
            {
                file.WriteAsync(commodity.GenerateInvoice());
            }            
        }


       // SendInvoice()
        //{
        //    GenerateInvoice();
        //    SendMail();
        //}
    }
}
