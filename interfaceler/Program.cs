using System;

namespace interfaceler
{
     class Program
    {
        static void Main(string[] args)
        {
                FileLogger filelogger = new FileLogger();
                 filelogger.writeLog();

                DatabaseLogger databaselogger = new DatabaseLogger();
                databaselogger.writeLog();

                SmsLogger smslogger = new SmsLogger();  
                smslogger.writeLog();

                LogManager logmanager = new LogManager(new FileLogger());
                logmanager.writeLog();
        }
    }
}
