using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Almacen
    {
        private string nombre;
        private int id;
        private List<Producto> productos = new List<Producto>();
        private List<Venta> ventas = new List<Venta>();
        private List<Compra> compras = new List<Compra>();

        public Almacen(string nombre, int id, List<Producto> productos, List<Venta> ventas, List<Compra> compras)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.id = id;
            this.productos = productos ?? throw new ArgumentNullException(nameof(productos));
            this.ventas = ventas ?? throw new ArgumentNullException(nameof(ventas));
            this.compras = compras ?? throw new ArgumentNullException(nameof(compras));
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        internal List<Producto> Productos { get => productos; set => productos = value; }
        internal List<Venta> Ventas { get => ventas; set => ventas = value; }
        internal List<Compra> Compras { get => compras; set => compras = value; }



    }
}
