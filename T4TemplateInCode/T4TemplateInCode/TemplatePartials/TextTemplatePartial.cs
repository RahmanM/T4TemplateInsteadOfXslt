using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateInCode
{

    public partial class TextTemplate
    {

        public TextTemplate(List<Customer> data)
        {
            Data = data;
        }

        public List<Customer> Data;
    }
}
