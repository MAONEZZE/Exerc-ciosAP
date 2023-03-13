namespace Ex4L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmI, kmF, consumo, consumoKm;

            Console.Write("Digite a quilometragem Inicial: ");
            kmI = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite a quilometragem Final: ");
            kmF = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o consumo de combustivel: ");
            consumo = Convert.ToDouble(Console.ReadLine());

            consumoKm = consumo / (kmF - kmI);

            Console.WriteLine("Consumo de combustivel por km: "+consumoKm);
        }
    }
}
