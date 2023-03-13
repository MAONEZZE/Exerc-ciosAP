namespace Ex6L1
{
    /*Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double grauC, grauF;

            Console.Write("Digite, em celsius, o grau");
            grauC = Convert.ToDouble(Console.ReadLine());

            grauF = (grauC * 1.8) + 32;

            Console.WriteLine("Grau em Fahrenheit: "+grauF);
        }
    }
}