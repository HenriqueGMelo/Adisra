using System;
using System.Collections.Generic;
using System.Linq;

namespace Adisra_do_Brasil
{
    internal class SequenciaNumerica
    {
        static void Main(string[] args)
        {
            Int64 controle = 0;

            Console.WriteLine("digite numero:");
            Int64 valor = Int64.Parse(Console.ReadLine());

            var numero = valor.ToString();

            List<Int64> values = new List<Int64> {};
            List<Int64> value = new List<Int64> {};

            for (int i = 0; i < numero.Length; i++)
            {
                values.Add(Int64.Parse(numero.Substring(i, 1)));
            }

            var result = values.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count()).ToList();

            foreach (var g in result)
            {
                
                if (g.Value >= controle && value.Where(x => x.Equals (g.Key)).Count() == 0) 
                {
                    controle = g.Value;
                    value.Add(g.Key);
                }
            }

            for (int i = value.Count-1; i > 0; i--)
            {
                Console.WriteLine(value[i]);
            }
        }
    }
}