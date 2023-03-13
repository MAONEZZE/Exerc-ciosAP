namespace Ex14L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int idade;
            float dias;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            dias = idade * 365;

            Console.WriteLine(nome.ToUpper()+", VOCÊ JÀ VIVEU "+dias+" DIAS");
        }
    }
}