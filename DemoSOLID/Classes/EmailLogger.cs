using DemoSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID.Classes
{
    public class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }
}
