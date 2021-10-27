using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class bodega
    {
        private string direccion;

        public bodega(string direccion)
        {
            this.direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
        }

        public override bool Equals(object obj)
        {
            return obj is bodega bodega &&
                   direccion == bodega.direccion;
        }

    }
}
