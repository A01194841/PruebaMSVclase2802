using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMSVclase2802.Algoritmo.Clase
{
    public class Demanda
    {
        public string IdProducto { get; set; }
        public string IdCliente { get; set; }
        public double Cantidad { get; set; }
        public Demanda ()
        {
        }
        public Demanda(string idProducto, string idCliente, double cantidad)
        {
            IdProducto = idProducto;
            IdCliente = idCliente;
            Cantidad = cantidad;
        }
    }
}
