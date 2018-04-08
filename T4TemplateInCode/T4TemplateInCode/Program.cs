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

            var sample = new Sample(customers);
            var result = sample.TransformText();
            Console.WriteLine(result);

            Console.WriteLine("Text template --->");
            var textTemplate = new TextTemplate(customers);
            result = textTemplate.TransformText();

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }

    public class ComplexData
    {

    }
}
