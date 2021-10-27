   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Cliente
    {
        private string Pnombre;
        private int id;
        private string direccion;
        private int telefono;

        public cliente(string pnombre, int id, string direccion, int telefono)
        {
            Pnombre = pnombre ?? throw new ArgumentNullException(nameof(pnombre));
            this.id = id;
            this.direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            this.telefono = telefono;
        }

        public string Pnombre1 { get => Pnombre; set => Pnombre = value; }
        public int Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
