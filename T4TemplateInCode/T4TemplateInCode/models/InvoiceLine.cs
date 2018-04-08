using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateInCode
{

    public class InvoiceLine
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public decimal Total => Quantity * Amount;
    }
}
