using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class PBodega
    {
        private int direccion;

        public PBodega(int direccion)
        {
            this.direccion = direccion;
        }

        public override bool Equals(object obj)
        {
            return obj is PBodega bodega &&
                   direccion == bodega.direccion;
        }
    }
}
