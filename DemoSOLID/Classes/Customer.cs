using DemoSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID.Classes
{
    public class Customer : IDiscount, IDatabase
    {
        private FileLogger logger = new FileLogger();

        private int _CustType;

        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }

        public virtual double GetDiscount(double totalSales)
        {
            //if (_CustType == 1)
            //{
            //    return totalSales - 100;
            //}
            //else
            //{
            //    return totalSales - 50;
            //}

            return totalSales;
        }

        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                logger.Handle(ex.ToString());
            }
        }
    }
}
