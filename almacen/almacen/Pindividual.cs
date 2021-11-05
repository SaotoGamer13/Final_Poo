using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Pindividual : Producto
    {
        public Pindividual(string pnombre, int pcodigo, int pprecio, bool pimportado) : base(pnombre, pcodigo, pprecio, pimportado)
        {
        }
    }
}
