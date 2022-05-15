using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceler
{
    internal class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Database'e log yazar.");
        }
    }
}
