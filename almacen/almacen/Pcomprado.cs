﻿using System;
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
        private List <Producto> producto = new List <Producto>();

        public Pcomprado(int precio, DateTime fecha, List<Producto> producto)
        {
            this.precio = precio;
            this.fecha = fecha;
            this.producto = producto;
        }

        public int Precio { get => precio; set => precio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public List <Producto> producto1 { get => producto; set => producto = value; }
    }
}
