namespace Ex7L1
{
    /*Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, percComis, tVendas, comissao;

            Console.Write("Digite seu salario: ");
            sal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o percentual de comissão: ");
            percComis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Total de vendas: ");
            tVendas = Convert.ToDouble(Console.ReadLine());

            comissao = sal + (percComis / tVendas);

            Console.WriteLine("Salario total: "+comissao);
        }
    }
}