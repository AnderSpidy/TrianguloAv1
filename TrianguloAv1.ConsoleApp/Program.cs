using System;

namespace TrianguloAv1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("TrianguloAv1App 2.0");
            Console.WriteLine("\n\nSe deseja utilizar o progama digite 1\ncaso contrario digite qualquer outro caractere:");
            string cond = Console.ReadLine();
            Console.ForegroundColor= ConsoleColor.White;
            while(cond == "1")
            {
                Console.Clear();
                Console.WriteLine("Identifique o Triangulo!");
                Console.WriteLine("Digite a medida X:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a medida Y:");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a medida Z:");
                int z = Convert.ToInt32(Console.ReadLine());
                if (x < (y + z) && y < (x + z) && z < (x + y))
                {
                    if (x == y && y == z)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Este Triangulo é Equilátero");
                    }
                    else if (x != y && y != z && x != z)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Este Triangulo é Escaleno");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Este Triangulo é Isósceles");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ESTE TRIANGULO É INVALIDO!!!\n é necessário que a medida de qualquer um dos lados" +
                                      " seja menor que asoma dos outros dois lados.");


                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\n\nDeseja fazer identificar mais um trangulo?\n SIM digite: 1\n NÃO digite qualquer coisa (menos 1)");
                Console.ForegroundColor = ConsoleColor.White;
                cond = Console.ReadLine();
            }
            Console.WriteLine("Fechando aplicação!!!");
            Console.ReadLine();
        }
    }
}
