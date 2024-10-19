namespace Test_2
{
    internal class Program
    {
        class Source
        {
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
            public double Add(double a, double b, double c)
            {
                return a + b + c;
            }

        }
        public class Test
        {
            public static void Main(string[] args)
            {
                Source source = new Source();
                Console.WriteLine(source.Add(10, 20, 30));
                Console.WriteLine(source.Add(1.1, 2.2, 3.8));


            }
        }
    }
}
