using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID.Classes
{
    public class FileLogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"log.txt", error);
        }
    }
}
