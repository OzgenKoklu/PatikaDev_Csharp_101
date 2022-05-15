using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceler
{
    public class SmsLogger : ILogger
    {
        public void writeLog()
        {
            //  throw new NotImplementedException();
            Console.WriteLine("Sms olarak log yazar.");
        }


    }
}
