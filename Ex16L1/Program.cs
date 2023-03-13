namespace Ex16L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, aumento, salDesc;

            Console.Write("Digite o seu salario: ");
            sal = Convert.ToDouble(Console.ReadLine());

            aumento = (15 * sal) / 100 + sal;

            salDesc = aumento - (8 * aumento) / 100;

            Console.WriteLine("Salario Inicial: " + sal);
            Console.WriteLine("Salario com Aumento: " + aumento);
            Console.WriteLine("Salario Fianl: " + salDesc);
        }
    }
}