namespace Ex29L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for(int j = 0; j <= 10; j++)
                {
                    int mult;
                    mult = i * j;
                    Console.WriteLine(i+" X "+j+" = "+mult);
                }
                Console.WriteLine();
                Console.WriteLine("X===============================X");
                Console.WriteLine();
            }
            {

            }
        }
    }
}