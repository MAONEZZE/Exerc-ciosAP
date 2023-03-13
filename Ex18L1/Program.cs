namespace Ex18L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, nMaior, nMenor;
            Console.WriteLine("Digite numeros diferentes");
            Console.Write("Número A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (c < a && a < b)
            {
                Console.WriteLine(c + ", " + a + ", " + b);
            }
            else
            {
                if(b < a && a < c)
                {
                    Console.WriteLine(b + ", " + a + ", " + c);
                }
                else
                {
                    if (a < c && c < b)
                    {
                        Console.WriteLine(a + ", " + c + ", " + b);
                    }
                    else
                    {
                        if (b < c && c < a)
                        {
                            Console.WriteLine(b + ", " + c + ", " + a);
                        }
                        else
                        {
                            if (c < b && b < a)
                            {
                                Console.WriteLine(c + ", " + b + ", " + a);
                            }
                            else
                            {
                                if (a < b && b < c)
                                {
                                    Console.WriteLine(a + ", " + b + ", " + c);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}