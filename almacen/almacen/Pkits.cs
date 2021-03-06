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
        private int cantidad0;

        public Pkits(string knombre, int kcodigo, int kprecio, int cantidad, string pnombre, int pcodigo, int pprecio, bool pimportado) : base(pnombre, pcodigo, pprecio, pimportado)
        {
            this.knombre = knombre ?? throw new ArgumentNullException(nameof(knombre));
            this.kcodigo = kcodigo;
            this.kprecio = kprecio;
            this.cantidad0 = cantidad0;
        }


        public string Knombre { get => knombre; set => knombre = value; }
        public int Kcodigo { get => kcodigo; set => kcodigo = value; }
        public int Kprecio { get => kprecio; set => kprecio = value; }
        public int Cantidad0 { get => cantidad0; set => cantidad0 = value; }
    }
}
