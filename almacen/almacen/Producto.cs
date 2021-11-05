using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Producto
    {
        private string pnombre;
        private int pcodigo;
        private int pprecio;
        private bool pimportado;

        public Producto(string pnombre, int pcodigo, int pprecio, bool pimportado)
        {
            this.pnombre = pnombre ?? throw new ArgumentNullException(nameof(pnombre));
            this.pcodigo = pcodigo;
            this.pprecio = pprecio;
            this.pimportado = pimportado;
        }

        public string Pnombre { get => pnombre; set => pnombre = value; }
        public int Pcodigo { get => pcodigo; set => pcodigo = value; }
        public int Pprecio { get => pprecio; set => pprecio = value; }
        public bool Pimportado { get => pimportado; set => pimportado = value; }
   
       

   
    }

}
