namespace Ex5L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;

            Console.Write("Digite o raio da esfera: ");
            raio = Convert.ToDouble(Console.ReadLine());

            volume = (4 * 3.14 * Math.Pow(raio, 3))/3;

            Console.WriteLine("Volume da Esfera: "+Math.Round(volume, 2));
        }
    }
}