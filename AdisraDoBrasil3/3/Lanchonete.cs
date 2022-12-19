using AdisraDoBrasil3._3;
using System;

namespace Adisra_do_Brasil
{
    internal class Lanchonete
    {
        static void Main(string[] args)
        {
            int valorPedido;

            var pedido = new Pedidos();

            { 
                Console.WriteLine("Deseja pedir lanche ? sim ou não");
                string lanche = Console.ReadLine();
                Console.Clear();

                if (lanche == "sim")
                {
                    var hamburguer = new Lanche();

                    Console.WriteLine("Lanche de qual sabor ? carne ou frango");
                    string sabor = Console.ReadLine();
                    Console.Clear();

                    if (sabor == "carne")
                    {
                        Console.WriteLine("Quantos lanches de carne ?");
                        hamburguer.saborLanche = "carne";
                        hamburguer.quantidadeLanche = int.Parse(Console.ReadLine());
                    }

                    if (sabor == "frango")
                    {
                        Console.WriteLine("Quantos lanches de frango ?");
                        hamburguer.saborLanche = "frango";
                        hamburguer.quantidadeLanche = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Deseja salada no lanche ?  sim ou não");
                    string salada = Console.ReadLine();
                    Console.Clear();

                    if (salada == "sim")
                    {
                        Console.WriteLine($"Você pediu total de {hamburguer.quantidadeLanche} lanches, quantos com salada ?");
                        hamburguer.salada = true;
                        hamburguer.quantidadeSalada = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Deseja maionese no lanche ? sim ou não");
                    string maionese = Console.ReadLine();
                    Console.Clear();

                    if (maionese == "sim")
                    {
                        Console.WriteLine($"Você pediu total de {hamburguer.quantidadeLanche} lanches, quantos com maionese ?");
                        hamburguer.maioneseNoLanche = true;
                        hamburguer.quantidadeMaioneseNoLanche = int.Parse(Console.ReadLine());
                    }
                    pedido.lanche = hamburguer;
                }

                Console.WriteLine("Deseja batata frita ?  sim ou não");
                string batata = Console.ReadLine();
                Console.Clear();

                if (batata == "sim")
                {
                    var acompanhamento = new Batata();
                    Console.WriteLine("Quantas batatas ?");
                    acompanhamento.querBatata = true; 
                    acompanhamento.quantidadeDeBatata = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Deseja maionese na batata ? sim ou não");
                    string maionesebatata = Console.ReadLine();
                    Console.Clear();

                    if (maionesebatata == "sim")
                    {
                        Console.WriteLine($"Você pediu {acompanhamento.quantidadeDeBatata} batatas, quantos com maionese ?");
                        acompanhamento.maioneseNaBatata = true;
                        acompanhamento.quantidadeMaioneseNaBatata = int.Parse(Console.ReadLine());
                    }
                    pedido.batataAcompanhamento = acompanhamento;
                }

                Console.WriteLine("Deseja refrigerante ? sim ou não");
                string refrigerante = Console.ReadLine();
                Console.Clear();

                if (refrigerante == "sim")
                {
                    Console.WriteLine("Quantos refrigerantes ?");
                    pedido.bebida = true; 
                    pedido.quantidadeBebida = int.Parse(Console.ReadLine());      
                }
                var total = CalculaPrecoPedido(pedido);
                    Console.WriteLine($"Valor pedido: {total}");
            }
        }

        public static double CalculaPrecoPedido(Pedidos pedido)
        {
            double valorPedido = 0;

            if (pedido != null)
            {
                if (pedido.lanche != null)
                {
                    if (pedido.lanche.saborLanche == "carne")
                    {
                        valorPedido += pedido.lanche.quantidadeLanche * 20;
                    }
                    else
                    {
                        valorPedido += pedido.lanche.quantidadeLanche * 16;
                    }
                    if (pedido.lanche.maioneseNoLanche)
                    {
                        valorPedido += pedido.lanche.quantidadeMaioneseNoLanche * 1;
                    }
                    if (pedido.lanche.salada)
                    {
                        valorPedido += pedido.lanche.quantidadeSalada * 2;
                    }
                }
                if (pedido.batataAcompanhamento != null)
                {
                    if (pedido.batataAcompanhamento.querBatata)
                    {
                        valorPedido += pedido.batataAcompanhamento.quantidadeDeBatata * 6;

                        if (pedido.batataAcompanhamento.maioneseNaBatata)
                        {
                            valorPedido += pedido.batataAcompanhamento.quantidadeMaioneseNaBatata * 1;
                        }
                    }
                }
                if (pedido.bebida)
                {
                    valorPedido += pedido.quantidadeBebida * 4;
                }
            }
            return valorPedido;
        }
    }
}