using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateInCode
{

    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public int Id { get; set; }

        public string Phone { get; set; }

        public CustomerType CustomerType { get; set; }

        public string GetCustomerNote(CustomerType type)
        {
            var text = "";
            switch (type)
            {
                case CustomerType.New:
                    text = "You are a new customer";
                    break;
                case CustomerType.Premier:
                    text = "You are a premier customer";
                    break;
                case CustomerType.Vip:
                    text = "You are the king";
                    break;
                default:
                    break;
            }

            return text;
        }
    }
}
