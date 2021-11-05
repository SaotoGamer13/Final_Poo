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
        private List<Pkits> kits = new List<Pkits>();
        private List<Producto> productos = new List<Producto>();
        private List<Venta> ventas = new List<Venta>();
        private List<Compra> compras = new List<Compra>();
        private List<Pindividual> pindividuals = new List<Pindividual>();

        private static int auxiliar;

        public Almacen(string nombre, int id,List<Producto> productos, List<Venta> ventas, List<Compra> compras, List<Pkits> kits, List<Pindividual> pindividuals)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.id = id;
            this.productos = productos ?? throw new ArgumentNullException(nameof(productos));
            this.ventas = ventas ?? throw new ArgumentNullException(nameof(ventas));
            this.compras = compras ?? throw new ArgumentNullException(nameof(compras));
            this.kits = kits ?? throw new ArgumentNullException(nameof(kits));
            this.pindividuals = pindividuals ?? throw new ArgumentNullException(nameof(pindividuals));
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        internal List<Producto> Productos { get => productos; set => productos = value; }
        internal List<Venta> Ventas { get => ventas; set => ventas = value; }
        internal List<Compra> Compras { get => compras; set => compras = value; }
        internal List<Pkits> Kits { get => kits; set => kits = value; }
        internal List<Pindividual> Pindividuals { get => pindividuals; set => pindividuals = value; }

        public static int AlmacenM()
        {
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. agregar kit");
            Console.WriteLine("3. lista de producto disponibles en bodega");
            Console.WriteLine("4. list de kits disponibles en bodega");
            Console.WriteLine("5. comprar producto");
            Console.WriteLine("6. Comprar kit");
            Console.WriteLine("7. vender producto");
            Console.WriteLine("8. vender kit");
            Console.WriteLine("9. lista de productos del cliente");
            Console.WriteLine("10. lista de kits del cliente");
            Console.WriteLine("11. generar reporte");

            return Int32.Parse(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            List<Pindividual> pindividuals = new List<Pindividual>();
            List<Pkits> kits = new List<Pkits>();
            List<Producto> productos = new List<Producto>();
            int valor = -1;

            do
            {
                valor = AlmacenM();


                switch (valor)
                {
                    case 1:
                        Console.WriteLine(" ingresar nombre del Producto : ");
                        string pnombre = Console.ReadLine();
                        Console.WriteLine("ingresar codigo del producto");
                        int pcodigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresar precio del producto");
                        int pprecio = int.Parse(Console.ReadLine());
                        Console.WriteLine("elegir entre nacional(1) e importada(2)");
                        bool pimportado = false;
                        if ((auxiliar = int.Parse(Console.ReadLine())) == 1 ){
                            pimportado = true;
                        }
                        

                        Producto producto = new Producto(pnombre, pcodigo, pprecio, pimportado);
                        productos.Add(producto);

                        break;

                    case 2:
                        Console.WriteLine(" ingresar nombre del kit");
                        string knombre = Console.ReadLine();
                        Console.WriteLine("ingresar codigo del kit");
                        int kcodigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresar precio del kit");
                        int kprecio = int.Parse(Console.ReadLine());
                        Console.WriteLine(" ingresar nombre del Producto : ");
                        pnombre = Console.ReadLine();
                        Console.WriteLine("ingresar codigo del producto");
                        pcodigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresar precio del producto");
                        pprecio = int.Parse(Console.ReadLine());
                       Console.WriteLine("elegir entre nacional(1) e importada(2)");
                        pimportado = false;
                        if ((auxiliar = int.Parse(Console.ReadLine())) == 1)
                        {
                            pimportado = true;
                        }

                        Pkits kit = new Pkits(knombre, kcodigo, kprecio, pnombre, pcodigo, pprecio, pimportado);
                        kits.Add(kit);
                        break;

                    case 3:

                        foreach (Producto result in productos)
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("informacion del producto:");
                            Console.WriteLine("Nombre del producto: " + result.Pnombre);
                            Console.WriteLine("Codigo del producto: " + result.Pcodigo);
                            Console.WriteLine("Precio del producto" + result.Pprecio);
                            Console.WriteLine("Nacional(True) o Importado(False): " + result.Pimportado);
                            Console.WriteLine("=============================================");

                        }
                        break;
                    case 4:
                        foreach (Pkits result in kits)
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("informacion del Kit:");
                            Console.WriteLine("Nombre del Kit: " + result.Knombre);
                            Console.WriteLine("Codigo del Kit: " + result.Kcodigo);
                            Console.WriteLine("Precio del Kit: " + result.Kprecio);
                            Console.WriteLine("=============================================");

                        }


                        break;

                    case 5:

                        Console.WriteLine("nombre del Producto a borrar: ");
                        string nombrep2 = Console.ReadLine();
                        for (int cantidad = 0; cantidad < productos.Count; cantidad++)
                        {
                            if (nombrep2 == productos[cantidad].Pnombre)
                            {
                                Pindividual pindividuals2 = new Pindividual(productos[cantidad].Pnombre, productos[cantidad].Pcodigo, productos[cantidad].Pprecio, productos[cantidad].Pimportado);

                                pindividuals.Add(pindividuals2);
                                productos.RemoveAt(cantidad);

                            }
                        }
                        break;


                        break;

                    case 6:



                        break;

                    case 7:

                        Console.WriteLine("nombre del Producto a borrar: ");
                        string nombrep1 = Console.ReadLine();
                        for (int cantidad = 0; cantidad < pindividuals.Count; cantidad++)
                        {
                            if (nombrep1 == pindividuals[cantidad].Pnombre)
                            {
                                Producto productos2 = new Producto(pindividuals[cantidad].Pnombre, pindividuals[cantidad].Pcodigo, pindividuals[cantidad].Pprecio, pindividuals[cantidad].Pimportado);

                                productos.Add(productos2);
                                pindividuals.RemoveAt(cantidad);

                            }
                        }
                        break;

                        break;

                    case 8:



                        break;

                    case 9:
                        foreach (Producto result in pindividuals)
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("informacion del producto:");
                            Console.WriteLine("Nombre del producto: " + result.Pnombre);
                            Console.WriteLine("Codigo del producto: " + result.Pcodigo);
                            Console.WriteLine("Precio del producto" + result.Pprecio);
                            Console.WriteLine("Importado? si.. Nacional? No: " + result.Pimportado);
                            Console.WriteLine("=============================================");

                        }
                        break;

                    case 10:
                        foreach (Pkits result in kits)
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("informacion del Kit:");
                            Console.WriteLine("Nombre del Kit: " + result.Knombre);
                            Console.WriteLine("Codigo del Kit: " + result.Kcodigo);
                            Console.WriteLine("Precio del Kit: " + result.Kprecio);
                            Console.WriteLine("=============================================");

                        }
                        break;

                    case 11:



                        break;

                }


            }
            while (valor != 0);
        }


    }



   
  
   
}

