namespace Ex13L1
{
    /*A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
    pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
    venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
    Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as
    quantidades de pães e de broas, e depois calcular os dados solicitados.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int pao, broa;
            double total, poupanca;

            Console.Write("Digite a quantidade de pães vendidos: ");
            pao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de broas vendidas: ");
            broa = Convert.ToInt32(Console.ReadLine());

            total = (pao * 0.12) + (broa * 1.5);
            poupanca = (10 * total) / 100;

            Console.WriteLine("Total arrecadado: "+total);
            Console.WriteLine("Poupança: "+poupanca);
        }
    }
}