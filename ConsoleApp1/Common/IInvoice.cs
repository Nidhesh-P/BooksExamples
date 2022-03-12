using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IInvoice
    {
        Guid InvoiceID { get; set; }
        string InvoiceTitle { get; set; }

        string GenerateInvoice();
    }
}
