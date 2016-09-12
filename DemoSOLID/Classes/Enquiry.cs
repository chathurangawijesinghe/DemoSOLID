using DemoSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID.Classes
{
    public class Enquiry : IDiscount
    {
        public double GetDiscount(double totalSales)
        {
            return totalSales - 5;
        }

        public void Add()
        {
            throw new Exception("Not allowed");
        }
    }
}
