using DemoSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID.Classes
{
    public class CustomerWithRead : IDatabaseV1
    {
        private FileLogger logger = new FileLogger();

        public void Add()
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

        public void Read()
        { 
            // Implements logic for read
        }
    }
}
