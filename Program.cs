using System.ComponentModel;

namespace MergeRebaseSquashTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Math
    {
        public static double Sum(double x1, double x2)
        {
            return x1 + x2;
        }

        public static double Subtraction(double x1, double x2)
        {
            return x1 - x2;
        }
    }

    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
