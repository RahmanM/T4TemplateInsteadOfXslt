using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateInCode
{
    public partial class InvoiceTemplate
    {
        public InvoiceTemplate(InvoiceHeader invoice)
        {
            Invoice = invoice;
        }

        public InvoiceHeader Invoice { get; set; }
    }
}
