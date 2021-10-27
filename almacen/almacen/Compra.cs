using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Compra
    {
        private int Cantidad;
        private DateTime Fecha;

        public Compra(int cantidad, DateTime fecha)
        {
            Cantidad = cantidad;
            Fecha = fecha;
        }

        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
    }
}
