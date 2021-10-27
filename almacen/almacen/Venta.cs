using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Venta
    {
        private int valor;
        private int cantidad;
        private DateTime fecha;

        public Venta(int valor, int cantidad, DateTime fecha)
        {
            this.valor = valor;
            this.cantidad = cantidad;
            this.fecha = fecha;
        }

        public int Valor { get => valor; set => valor = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
