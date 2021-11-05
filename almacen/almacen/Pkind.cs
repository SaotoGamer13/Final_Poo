using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Pkind : Pkits
    {
        public Pkind(string knombre, int kcodigo, int kprecio, int cantidad0 ,string pnombre, int pcodigo, int pprecio, bool pimportado) : base(knombre, kcodigo, kprecio, cantidad0, pnombre, pcodigo, pprecio, pimportado)
        {
        }
    }
}
