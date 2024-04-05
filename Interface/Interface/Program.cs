namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDivide a = new Calculate();
            Console.WriteLine(a.Divide(1,5));
        }
    }
}
