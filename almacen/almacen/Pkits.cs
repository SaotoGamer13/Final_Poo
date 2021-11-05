using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Pkits : Producto
    {

        private string knombre;
        private int kcodigo;
        private int kprecio;

        public Pkits(string knombre, int kcodigo, int kprecio)
        {
            this.knombre = knombre;
            this.kcodigo = kcodigo;
            this.kprecio = kprecio;
        }

        public string Knombre { get => knombre; set => knombre = value; }
        public int Kcodigo { get => kcodigo; set => kcodigo = value; }
        public int Kprecio { get => kprecio; set => kprecio = value; }
    }
}
