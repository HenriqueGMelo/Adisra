using AdisraDoBrasil3._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adisra_do_Brasil
{
    public class Pedidos
    {
        public Lanche lanche { get; set; }
        public Batata batataAcompanhamento { get; set; }
        public bool bebida { get; set; }
        public int quantidadeBebida { get; set; }
    }
}