namespace MyLib
{
    public static class MathOperations
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            return (double)a / b;
        }
    }
    public class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }
        public void Print() => Console.WriteLine($"Name: {name}");
    }
}