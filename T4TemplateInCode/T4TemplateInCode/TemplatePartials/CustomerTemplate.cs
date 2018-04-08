using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateInCode
{

    public partial class CustomerTemplate
    {
        public CustomerTemplate(Customer customer)
        {
            Customer = customer;
        }

        public Customer Customer { get; }
    }
}
