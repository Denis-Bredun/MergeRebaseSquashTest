using System.ComponentModel;

namespace MergeRebaseSquashTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi world");
        }
    }

    public static class Math
    {
        public static double Sum(double x1, double x2) => x1 + x2;
        public static double Subtract(double x1, double x2) => x1 - x2;
    }

    public record Person(string Name, int Age);

}
