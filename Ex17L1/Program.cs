namespace Ex17L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Digite um valor para A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um valor para B: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um valor para C: ");
            c = Convert.ToDouble(Console.ReadLine());

            if((a + b) < c)
            {
                Console.WriteLine("Soma de A e B: "+(a + b));
            }
            else
            {
                Console.WriteLine("Nada");
            }

        }
    }
}