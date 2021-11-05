using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Pkits : Producto
    {

        private string Knombre;
        private int Kcodigo;
        private int Kprecio;

        public Pkits(string knombre, int kcodigo, int kprecio)
        {
            Knombre = knombre ?? throw new ArgumentNullException(nameof(knombre));
            Kcodigo = kcodigo;
            Kprecio = kprecio;
        }

        public string Knombre1 { get => Knombre; set => Knombre = value; }
        public int Kcodigo1 { get => Kcodigo; set => Kcodigo = value; }
        public int Kprecio1 { get => Kprecio; set => Kprecio = value; }
    }
}
