namespace Ex1L1
{
    /*Crie um programa para calcular o volume de uma caixa retangular*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, altura, volume, comp;

            Console.WriteLine("Digite os dados do retangulo");
            Console.Write("Largura: ");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.Write("comprimento: ");
            comp = Convert.ToDouble(Console.ReadLine());
            Console.Write("altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = largura * altura * comp;

            Console.WriteLine("Volume da caixa: "+volume);



        }
    }
}