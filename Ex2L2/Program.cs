namespace Ex2L2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grauF, grauC;

            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            grauF = Convert.ToDouble(Console.ReadLine());

            grauC = ((grauF - 32) * 5) / 9;

            Console.WriteLine("Temperatura em graus celsius: "+grauC);
        }
    }
}