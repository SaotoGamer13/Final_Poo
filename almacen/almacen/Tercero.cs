using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacen
{
    class Tercero
    {
        private string Tnombre;
        private int identificacion;
        private string direccion;
        private int telefono;
        private List<Cliente> Clientes = new List<Cliente>();

        public Tercero(string tnombre, int identificacion, string direccion, int telefono, List<Cliente> clientes)
        {
            Tnombre = tnombre ?? throw new ArgumentNullException(nameof(tnombre));
            this.identificacion = identificacion;
            this.direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            this.telefono = telefono;
            Clientes = clientes ?? throw new ArgumentNullException(nameof(clientes));
        }

        public string Tnombre1 { get => Tnombre; set => Tnombre = value; }
        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        internal List<Cliente> Clientes1 { get => Clientes; set => Clientes = value; }
    }
}
