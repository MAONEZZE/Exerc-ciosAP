using System.ComponentModel;

namespace Ex3L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, baseCilind, altura, volume;

            Console.Write("Digite a altura do cilindro: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o raio da base do cilindro: ");
            raio = Convert.ToDouble(Console.ReadLine());

            baseCilind = 3.14 * Math.Pow(raio, 2);

            volume = baseCilind * altura;

            Console.WriteLine("Volume do Cilindro: "+volume);

        }
    }
}