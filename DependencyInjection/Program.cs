// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
internal class Program
{
    public class ConsoleLog
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Silnik
    {


    }
    public class Auto
    {
        private readonly Silnik _silnik;
        private readonly ConsoleLog _log;

        public Auto(Silnik silnik, ConsoleLog log)
        {
            _silnik = silnik;
            _log = log;
        }
        public void Jedz()
        {
            _silnik.Odpal();
            _log.Write("Samochód zaczyna się poruszać");
        }
    }



}