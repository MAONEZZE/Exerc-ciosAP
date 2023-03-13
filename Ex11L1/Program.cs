namespace Ex11L1
{
    /*Crie um programa para verificar se um número é primo.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool x = false;

            Console.Write("Digite um numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i < n; i++)
            {
                if(n%i == 0)
                {
                    x = true;
                }
            }

            if (x == false)
            {
                Console.WriteLine("É primo");
            }
            else
            {
                Console.WriteLine("Não é primo");
            }
        }
    }
}