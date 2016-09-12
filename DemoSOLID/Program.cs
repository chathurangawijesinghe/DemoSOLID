using DemoSOLID.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new SilverCustomer());
            customers.Add(new GoldCustomer());
            //customers.Add(new Enquiry());

            foreach (Customer customer in customers)
            {
                customer.Add();
            }
        }
    }
}
