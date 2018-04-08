using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateInCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>()
            {
                new Customer(){Address = "27 watson Drive", Name = "Rahman"},
                new Customer(){Address = "27 watson Drive", Name = "Maria"},
                new Customer(){Address = "27 watson Drive", Name = "Hosha"},
                new Customer(){Address = "27 watson Drive", Name = "Roya"}
            };

            // Sample HTML generation
            var sample = new Sample(customers);
            var result = sample.TransformText();
            Console.WriteLine(result);

            // Sample text generation
            Console.WriteLine("Text template --->");
            var textTemplate = new TextTemplate(customers);
            result = textTemplate.TransformText();
            Console.WriteLine(result);

            // Invoice
            var invoice = new InvoiceHeader()
            {
                   Customer = new Customer()
                   {
                       Name = "Rahman Mahmoodi",
                       Address = "27 Pitt Street Sydney 2000",
                       CustomerType = CustomerType.Vip,
                       Id = 1,
                       Phone = "99887766"
                   },
                   Date = DateTime.Now,
                   Number = 123456,
                   Lines = new List<InvoiceLine>()
                   {
                       new InvoiceLine(){Code="A1", Description="New purchased item", Amount = 20, Id=1, Quantity=1},
                       new InvoiceLine(){Code="A2", Description="New purchased item 2", Amount = 30, Id=2, Quantity=1},
                   },
                   ExtraMessage = "To be shown for VIP clients!" // Conditional message based on customer type
            };

            invoice.TotalPaid = invoice.Total - 20;

            var invoiceTemplate = new InvoiceTemplate(invoice);
            var invoiceToPrint = invoiceTemplate.TransformText();
            Console.WriteLine(invoiceToPrint);

            Console.ReadLine();

        }
    }

   
}
