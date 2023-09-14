
using System.Diagnostics;

namespace Intefaces
{
    internal class Program
    {


        public interface ILogger
        {
            void LogError(string logError);
            void LogInfo(string logInfo);

        }
        //public interface IConcatString
        //{
        //    string ConcatStrings(string message,  DateTime.now);
        //}

        public class ConsoleLogger : ILogger
        {
            

            public void LogError(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
            }
            public void LogInfo(string logInfo)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(logInfo);
            }
        }
        public class FileLogger : ILogger
        {
            private readonly string _path;
            public FileLogger(string path)
            {
                _path = path;
            }
            public void LogError(string logError)
            {
                using (var streamWriter = new StreamWriter(_path, true))
                {
                    streamWriter.WriteLine($"Błąd: {logError}");
                }
            }
            public void LogInfo(string logInfo)
            {
                using (var streamWriter = new StreamWriter(_path, true))
                {
                    streamWriter.WriteLine($"Informacja {logInfo}");
                }

            }
        }
        public class LoggininService
        {
            private readonly ILogger _logger;

            public LoggininService(ILogger logger)
            {
                _logger = logger;
            }
            public void LogInfo()
            {
                _logger.LogInfo($"Nowe info o godzinie : {DateTime.Now}");
            }
            public void LogError()
            {
                _logger.LogError($"Nowy bład o godzinie: {DateTime.Now}");
            }
        }
        static void Main(string[] args)
        {
            var logginService = new LoggininService(new ConsoleLogger());
            logginService.LogInfo();

         var logginServiceFile = new LoggininService(new FileLogger("C:\\serviceLog.txt"));
        logginServiceFile.LogError();

            var logginServiceEmail = new LoggininService(new EmailLogger("daria.pietka@gmail.com"));
            logginServiceEmail.LogInfo();
        }
        public class EmailLogger : ILogger
        {
            private readonly string _email;

            public  EmailLogger(string email)
            {
                _email = email;
            }
            public void LogError(string message)
            {
                Console.WriteLine($"Error {LogError} sent to {_email}");
            }
            public void LogInfo(string logInfo)
            {
                Console.WriteLine($" Info: {logInfo} sent to {_email}");
            }



        }

    }

}


