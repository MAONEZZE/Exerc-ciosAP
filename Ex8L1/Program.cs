namespace Ex8L1
{
    /*Crie um programa para calcular o volume de uma lata de óleo*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volumeL, altura;
            Console.Write("digite a o valor do raio da base da lata: ");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.Write("digite a altura da lata: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volumeL = altura * (3.14 * Math.Pow(raio, 2));

            Console.WriteLine("Volume da lata: "+volumeL);
        }
    }
}