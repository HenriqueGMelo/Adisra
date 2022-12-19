using System;

namespace Adisra_do_Brasil
{
    internal class DolarParaReal
    {
        static void Main(string[] args)
        {
            int continuar = 1, resposta;

            do
            {
                Console.WriteLine("Valor em dólar que deseja converter para real: ");
                double dolar = double.Parse(Console.ReadLine());
                Console.Clear();

                double real = dolar * 5.36;
                Console.WriteLine($"Valor em dólar {dolar.ToString("C")} convertendo para valor em real = {real.ToString("C")}");
                Console.WriteLine();
                
                do
                {
                    Console.WriteLine("Deseja realizar nova conversão ?");
                    Console.Write("Tecle 1 para SIM ou 0 para NÃO : ");
                    resposta = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine();

                    if (resposta != 1 && resposta != 0)
                    {
                        Console.Write("Escolha opção válida \n\n");
                    }
                }
                while (resposta < 0 || resposta > 1);
            }
            while (continuar == resposta);           
        }
    }
}