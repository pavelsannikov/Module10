class Program
{
    static void Main(string[] args)
    {
        try
        {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            Math math = new Math();
            Console.WriteLine(math.Sum(a, b));
        }
        catch(System.FormatException)
        {
            Console.WriteLine("Недопустимые значения");
        }
    }
    public interface IMath
    {
        public double Sum(double a, double b);
    }
    class Math : IMath
    {
        public double Sum(double a, double b) { return a + b; }
    }
}
