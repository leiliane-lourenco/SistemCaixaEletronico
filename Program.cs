using System;

namespace caixa_eletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite o valor que deseja sacar (minimo de R$20,00 / máximo de R$1000,00):");
                int valor = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine($"Valor saque: R${valor},00");


                if (valor >= 20 && valor <= 1000)
                {
                    int notaDeCem = valor / 100; //contagem das notas de 100R$

                    int resto = valor - (notaDeCem * 100); //valor menos as notas de 100.

                    int notaDeCinquenta = resto / 50;//contagem das notas de 50R$

                    resto = resto - (notaDeCinquenta * 50);

                    int notaDeVinte = resto / 20;//contagem das notas de 20R$

                    resto = resto - (notaDeVinte * 20);

                    int notaDeDez = resto / 10;//contagem das notas de 10R$

                    resto = resto - (notaDeDez * 10);

                    Console.WriteLine("---------------------");

                    Console.WriteLine("Quantidade de notas:");

                    Console.WriteLine("Notas de R$100: " + notaDeCem);

                    Console.WriteLine("Notas de R$50: " + notaDeCinquenta);

                    Console.WriteLine("Notas de R$20: " + notaDeVinte);

                    Console.WriteLine("Notas de R$10: " + notaDeDez);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Valor inválido");
                    Console.WriteLine("Informe um valor entre de R$20,00 e R$1000,00");
                    Console.WriteLine( );

                }

                Console.WriteLine("Tecle ENTER para continuar");
                Console.ReadLine();
            }
           
























        }
    }
}
