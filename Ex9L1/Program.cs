namespace Ex9L1
{
    /*Crie um programa para calcular a média harmônica das notas de um Aluno*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;

            Console.Write("Digite Nota 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite Nota 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite Nota 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            media = 3 / ((1 / n1) + (1 / n2) + (1 / n3));

            Console.WriteLine("Media do aluno: "+Math.Pow(media, 2));
        }
    }
}