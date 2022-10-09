class Program
{
    static ILogger math_log;
    static void Main(string[] args)
    {
        math_log = new Logger();
        Math math = new Math(math_log);
        math.Sum();
    }
    
    public interface ILogger
    {
        void Event(string msg);
        void Error(string msg);
    }
    public class Logger : ILogger
    {
        public void Error(string msg)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(msg);
        }

        public void Event(string msg)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(msg);
        }
    }
    public interface IMath
    {
        void Sum();
    }
    class Math : IMath
    {
        ILogger math_log;
        public Math(ILogger _log)
        {
            math_log = _log;
        }
        public void Sum() {
            try
            {
                double a = Double.Parse(Console.ReadLine());
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine((a + b).ToString());
                math_log.Event((a + b).ToString());
            }
            catch (System.FormatException)
            {
                math_log.Error("Недопустимые значения");
            }
        }
    }
}
