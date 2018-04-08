using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateInCode
{
    public partial class Sample
    {

        public Sample(List<Customer> data)
        {
            Data = data;
        }

        public List<Customer> Data;
    }
}
