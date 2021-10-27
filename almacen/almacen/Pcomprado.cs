using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Pcomprado
    {
        private int precio;
        private DateTime fecha;

        public Pcomprado(int precio, DateTime fecha)
        {
            this.precio = precio;
            this.fecha = fecha;
        }

        public int Precio { get => precio; set => precio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
