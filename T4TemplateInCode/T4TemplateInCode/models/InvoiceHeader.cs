using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateInCode
{

    public class InvoiceHeader
    {
        public InvoiceHeader()
        {
            Customer = new Customer();
            
        }

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public decimal Total => Lines.Sum(s => s.Total);
        public List<InvoiceLine> Lines { get; set; }
        public decimal TotalPaid { get; set; }

        public decimal Balance => Total - TotalPaid;

        public string ExtraMessage { get; internal set; }
    }
}
