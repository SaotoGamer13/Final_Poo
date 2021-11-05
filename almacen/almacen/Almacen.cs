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
        private List<Pkind> pkinds = new List<Pkind>();
        private static int billetera = 1000;

        private static int auxiliar;

        public Almacen(string nombre, int id,List<Producto> productos, List<Venta> ventas, List<Compra> compras, List<Pkits> kits, List<Pindividual> pindividuals, List<Pkind> pkinds)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.id = id;
            this.productos = productos ?? throw new ArgumentNullException(nameof(productos));
            this.ventas = ventas ?? throw new ArgumentNullException(nameof(ventas));
            this.compras = compras ?? throw new ArgumentNullException(nameof(compras));
            this.kits = kits ?? throw new ArgumentNullException(nameof(kits));
            this.pindividuals = pindividuals ?? throw new ArgumentNullException(nameof(pindividuals));
            this.pkinds = pkinds ?? throw new ArgumentNullException(nameof(pkinds));
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        internal List<Producto> Productos { get => productos; set => productos = value; }
        internal List<Venta> Ventas { get => ventas; set => ventas = value; }
        internal List<Compra> Compras { get => compras; set => compras = value; }
        internal List<Pkits> Kits { get => kits; set => kits = value; }
        internal List<Pindividual> Pindividuals { get => pindividuals; set => pindividuals = value; }
        internal List<Pkind> Pkinds { get => pkinds; set => pkinds = value; }

        public static int AlmacenM()
        {
            
            Console.WriteLine("===========================================");
            Console.WriteLine("Bienvenido al almacen deportivo");
            Console.WriteLine("");
            Console.WriteLine("1. Agregar producto" );
            Console.WriteLine("2. Agregar kit" );
            Console.WriteLine("3. Lista de producto disponibles en bodega");
            Console.WriteLine("4. List de kits disponibles en bodega");
            Console.WriteLine("5. Comprar producto");
            Console.WriteLine("6. Comprar kit");
            Console.WriteLine("7. Vender producto");
            Console.WriteLine("8. Vender kit");
            Console.WriteLine("9. Lista de productos del cliente");
            Console.WriteLine("10. Lista de kits del cliente");
            Console.WriteLine("11. Generar reporte");
            Console.WriteLine("");
            Console.WriteLine("===========================================");

            return Int32.Parse(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            List<Pkind> pkinds = new List<Pkind>();
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
                        Console.WriteLine(" Ingresar nombre del Producto : ");
                        string pnombre = Console.ReadLine();
                        Console.WriteLine(" Ingresar codigo del producto ");
                        int pcodigo = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Ingresar precio del producto ");
                        int pprecio = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Elegir entre nacional (1) e importada (2)");
                        bool pimportado = false;
                        if ((auxiliar = int.Parse(Console.ReadLine())) == 1 ){
                            pimportado = true;
                        }
                        

                        Producto producto = new Producto(pnombre, pcodigo, pprecio, pimportado);
                        productos.Add(producto);
     
                        billetera = billetera-pprecio;
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
                        billetera = billetera - pprecio;
                        break;

                    case 3:
                        if (productos.Any())
                        {
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
                        }
                        else
                        {
                            Console.WriteLine("=================================");
                            Console.WriteLine("La bodega no posee productos");
                            Console.WriteLine("================================");
                        }
                        break;

                    case 4:
                        if (kits.Any())
                        {
                            foreach (Pkits result in kits)
                            {
                                Console.WriteLine("===========================================");
                                Console.WriteLine("informacion del Kit:");
                                Console.WriteLine("Nombre del Kit: " + result.Knombre);
                                Console.WriteLine("Codigo del Kit: " + result.Kcodigo);
                                Console.WriteLine("Precio del Kit: " + result.Kprecio);
                                Console.WriteLine("=============================================");

                            }
                        }
                        else
                        {
                            Console.WriteLine("=================================");
                            Console.WriteLine("La bodega no posee kits");
                            Console.WriteLine("================================");
                        }
                        break;

                    case 5:
                        if (productos.Any())
                        {
                            Console.WriteLine("nombre del Producto a comprar: ");
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
                        }
                        else
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("No hay productos disponibles para comprar");
                            Console.WriteLine("============================================");
                        }
                        break;

                    case 6:
                        if (kits.Any())
                        {
                            Console.WriteLine("nombre del Kit a comprar: ");
                            string nombrep0 = Console.ReadLine();
                            for (int cantidad = 0; cantidad < kits.Count; cantidad++)
                            {
                                if (nombrep0 == kits[cantidad].Pnombre)
                                {
                                    Pkind kits0 = new Pkind(pkinds[cantidad].Knombre, pkinds[cantidad].Kcodigo, pkinds[cantidad].Kprecio, pkinds[cantidad].Pnombre, pkinds[cantidad].Pcodigo, pkinds[cantidad].Pprecio, pkinds[cantidad].Pimportado);

                                    pkinds.Add(kits0);
                                    kits.RemoveAt(cantidad);

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("No hay kits disponibles para comprar");
                            Console.WriteLine("============================================");
                        }
                        break;



                    case 7:
                        if (productos.Any())
                        {
                            Console.WriteLine("nombre del Producto a vender: ");
                            string nombrep1 = Console.ReadLine();
                            for (int cantidad = 0; cantidad < pindividuals.Count; cantidad++)
                            {
                                if (nombrep1 == pindividuals[cantidad].Pnombre)
                                {
                                    Producto productos2 = new Producto(pindividuals[cantidad].Pnombre, pindividuals[cantidad].Pcodigo, pindividuals[cantidad].Pprecio, pindividuals[cantidad].Pimportado);

                                    productos.Add(productos2);
                                    pindividuals.RemoveAt(cantidad);
                                    
                                    Console.WriteLine("Saldo Disponible: " + billetera);

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("No hay productos disponibles para vender");
                            Console.WriteLine("============================================");
                        }
                        break;



                    case 8:
                        if (kits.Any())
                        {
                            Console.WriteLine("nombre del Kit a vender: ");
                            string nombrep01 = Console.ReadLine();
                            for (int cantidad = 0; cantidad < pkinds.Count; cantidad++)
                            {
                                if (nombrep01 == pkinds[cantidad].Pnombre)
                                {
                                    Pkits kits01 = new Pkits(kits[cantidad].Knombre, kits[cantidad].Kcodigo, kits[cantidad].Kprecio, kits[cantidad].Pnombre, kits[cantidad].Pcodigo, kits[cantidad].Pprecio, kits[cantidad].Pimportado);

                                    kits.Add(kits01);
                                    pkinds.RemoveAt(cantidad);
                                    
                                    Console.WriteLine("Saldo Disponible: " + billetera);

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("No hay kits disponibles para vender");
                            Console.WriteLine("============================================");
                        }
                        break;

                    case 9:
                        if (productos.Any())
                        {
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
                        }
                        else
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("El cliente no posee productos");
                            Console.WriteLine("============================================");
                        }
                        break;

                    case 10:
                        if (kits.Any())
                        {
                            foreach (Pkits result in pkinds)
                            {
                                Console.WriteLine("===========================================");
                                Console.WriteLine("informacion del Kit:");
                                Console.WriteLine("Nombre del Kit: " + result.Knombre);
                                Console.WriteLine("Codigo del Kit: " + result.Kcodigo);
                                Console.WriteLine("Precio del Kit: " + result.Kprecio);
                                Console.WriteLine("=============================================");

                            }
                        }
                        else
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("El cliente no posee kits");
                            Console.WriteLine("============================================");
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

