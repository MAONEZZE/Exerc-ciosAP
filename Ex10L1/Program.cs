namespace Ex10L1
{
    /*Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double prova1, peso1, prova2, peso2, media;

            Console.Write("Digite a nota da prova 1: ");
            prova1 = Convert.ToDouble(Console.ReadLine());  
            Console.Write("Digite a nota do peso da prova 1: ");
            peso1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota da prova 2: ");
            prova2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota o peso da prova 2: ");
            peso2 = Convert.ToDouble(Console.ReadLine());

            media = (prova1 * peso1 + prova2 * peso2) / peso1 + peso2;

            Console.WriteLine("A media final do aluno: "+Math.Round(media, 2));

        }
    }
}