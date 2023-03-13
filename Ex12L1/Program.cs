namespace Ex12L1
{
    /*A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
terreno e depois exibir a área do terreno.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comp, area;

            Console.Write("Digite a largura do terreno: ");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o comprimento do terreno: ");
            comp = Convert.ToDouble(Console.ReadLine());

            area = largura * comp;

            Console.WriteLine("Area do terreno: "+area);
        }
    }
}