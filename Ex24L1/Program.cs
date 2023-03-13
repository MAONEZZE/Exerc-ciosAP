namespace Ex24L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 500; i = i + 2)
            {
                if(i%3 == 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine("A soma de todos os números ímpares que são múltiplos de três: " + soma);
        }
    }
}