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
        private static int auxiliar;



        public Almacen(string nombre, int id, List<Producto> productos, List<Venta> ventas, List<Compra> compras, List<Pkits> kits, List<Pindividual> pindividuals, List<Pkind> pkinds)
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
            Console.WriteLine("===========================================");
            Console.WriteLine("");
            Console.WriteLine("===========================================");
            Console.WriteLine(" 1. Agregar producto");
            Console.WriteLine(" 2. agregar kit");
            Console.WriteLine(" 3. lista de producto disponibles en bodega");
            Console.WriteLine(" 4. list de kits disponibles en bodega");
            Console.WriteLine(" 5. comprar producto");
            Console.WriteLine(" 6. Comprar kit");
            Console.WriteLine(" 7. vender producto");
            Console.WriteLine(" 8. vender kit");
            Console.WriteLine(" 9. lista de productos del cliente");
            Console.WriteLine(" 10. lista de kits del cliente");
            Console.WriteLine(" 12. monedero");
            Console.WriteLine(" 0. salir del almacen");
            Console.WriteLine("===========================================");
            Console.WriteLine("");

            return Int32.Parse(Console.ReadLine());
        }

        static void Main()
        {

                List<Pkind> pkinds = new List<Pkind>();
                List<Pindividual> pindividuals = new List<Pindividual>();
                List<Pkits> kits = new List<Pkits>();
                List<Producto> productos = new List<Producto>();
                int valor = -1;
                int billetera = 1000;
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
                            if ((auxiliar = int.Parse(Console.ReadLine())) == 1)
                            {
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
                            Console.WriteLine("ingresar cantidad de productos en el kit");
                            int cantidad0 = int.Parse(Console.ReadLine());
                            Console.WriteLine(" ingresar nombre de los Productos : ");
                            pnombre = Console.ReadLine();
                            Console.WriteLine("ingresar precio del producto individual");
                            pprecio = int.Parse(Console.ReadLine());
                            Console.WriteLine("ingresar codigo de los productos");
                            pcodigo = int.Parse(Console.ReadLine());

                            int kprecio = pprecio * cantidad0;

                            Console.WriteLine("elegir entre nacional(1) e importada(2)");
                            pimportado = false;
                            if ((auxiliar = int.Parse(Console.ReadLine())) == 1)
                            {
                                pimportado = true;
                            }

                            Pkits kit = new Pkits(knombre, kcodigo, kprecio, cantidad0, pnombre, pcodigo, pprecio, pimportado);
                            kits.Add(kit);
                            break;

                        case 3:
                            if (productos.Any())
                            {
                                Console.WriteLine("La lista contiene {0} productos", productos.Count);

                                foreach (Producto result in productos)
                                {
                                    Console.WriteLine("===========================");
                                    Console.WriteLine("INFORMACION DEL PRODUCTO:");
                                    Console.WriteLine("===========================");
                                    Console.WriteLine("");
                                    Console.WriteLine("Nombre del producto: " + result.Pnombre);
                                    Console.WriteLine("");
                                    Console.WriteLine("  Codigo del producto: " + result.Pcodigo);
                                    Console.WriteLine("  Precio del producto: " + result.Pprecio);
                                    Console.WriteLine("  Nacional(True) o Importado(False): " + result.Pimportado);
                                    Console.WriteLine("=============================================================");


                                }
                            }
                            else
                            {
                                Console.WriteLine("=============================");
                                Console.WriteLine("La bodega no posee productos");
                                Console.WriteLine("=============================");
                            }
                            break;

                        case 4:
                            if (kits.Any())
                            {
                                Console.WriteLine("La lista contiene {0} kits", kits.Count);
                                foreach (Pkits result in kits)
                                {
                                    Console.WriteLine("======================");
                                    Console.WriteLine("INFORMACION DEL KIT:");
                                    Console.WriteLine("======================");
                                    Console.WriteLine("");
                                    Console.WriteLine("Nombre del Kit: " + result.Knombre);
                                    Console.WriteLine("");
                                    Console.WriteLine("  Codigo del Kit: " + result.Kcodigo);
                                    Console.WriteLine("  Precio del Kit: " + result.Kprecio);
                                    Console.WriteLine("  Nombre del producto: " + result.Pnombre);
                                    Console.WriteLine("  Cantidad del producto: " + result.Cantidad0);
                                    Console.WriteLine("===================================");

                                }
                            }
                            else
                            {
                                Console.WriteLine("=========================");
                                Console.WriteLine("La bodega no posee kits");
                                Console.WriteLine("=========================");
                            }
                            break;

                        case 5:
                            if (productos.Any())
                            {
                                Console.WriteLine("nombre del Producto a comprar: ");
                                Console.WriteLine("=================================");
                                string nombrep2 = Console.ReadLine();
                                for (int cantidad = 0; cantidad < productos.Count; cantidad++)
                                {
                                    if (nombrep2 == productos[cantidad].Pnombre)
                                    {
                                        Pindividual pindividuals2 = new Pindividual(productos[cantidad].Pnombre, productos[cantidad].Pcodigo, productos[cantidad].Pprecio, productos[cantidad].Pimportado);
                                      if (billetera >= productos[cantidad].Pprecio)

                                      {

                                        int cio = productos[cantidad].Pprecio;

                                        bool nac = productos[cantidad].Pimportado;
                                        if (nac == true)
                                        {
                                            billetera = billetera - (((cio*2)/100) + cio);

                                            pindividuals.Add(pindividuals2);
                                            productos.RemoveAt(cantidad);
                                            Console.WriteLine("El producto ha costado " + cio + "mas un 2% de recargo ahora cuesta" + (((cio * 2) / 100) + cio));
                                            Console.WriteLine("Monedero actual: " + billetera);
                                        }
                                        else
                                        {

                                            billetera = billetera - cio;

                                            pindividuals.Add(pindividuals2);
                                            productos.RemoveAt(cantidad);
                                            Console.WriteLine("El producto ha costado " + cio);
                                            Console.WriteLine("Monedero actual: " + billetera);

                                            Console.WriteLine("El producto ha costado " + cio);
                                            Console.WriteLine("Monedero actual: " + billetera);

                                        }

                                      }

                                      else
                                      {
                                        Console.WriteLine("===========================================");
                                        Console.WriteLine("No hay dinero en el monedero");
                                        Console.WriteLine("===========================================");
                                      }
                                      break;


                                }
                                }


                                
                            }
                            else
                            {
                                Console.WriteLine("===========================================");
                                Console.WriteLine("No hay productos disponibles para comprar");
                                Console.WriteLine("===========================================");
                            }
                            break;

                        case 6:
                            if (kits.Any())
                            {
                                Console.WriteLine("nombre del Kit a comprar: ");
                                Console.WriteLine("============================");
                                string nombrep0 = Console.ReadLine();
                                for (int cantidad = 0; cantidad < kits.Count; cantidad++)
                                {


                                  if (nombrep0 == kits[cantidad].Knombre)
                                    {
                                        Pkind kits0 = new Pkind(kits[cantidad].Knombre, kits[cantidad].Kcodigo, kits[cantidad].Kprecio, kits[cantidad].Cantidad0, kits[cantidad].Pnombre, kits[cantidad].Pcodigo, kits[cantidad].Pprecio, kits[cantidad].Pimportado);
                                      if (billetera >= kits[cantidad].Kprecio)
                                      {
                                        int pre = kits[cantidad].Kprecio;
                                        int cant = kits[cantidad].Cantidad0;
                                        int F = 200;

                                        if (pre >= F)
                                        {
                                            billetera = billetera - ((((pre)*3) / 100) + (pre));
                                            pkinds.Add(kits0);
                                            kits.RemoveAt(cantidad);
                                            Console.WriteLine("======================================");
                                            Console.WriteLine("El kit ha costado " + pre + " pero con un 3% de desdescuento ahora cuesta " + ((((pre) * 3) / 100) + (pre)));
                                            Console.WriteLine("Monedero actual: " + billetera);
                                            Console.WriteLine("======================================");
                                        }
                                     
                                        else
                                        {
                                            billetera = billetera - kits[cantidad].Kprecio;
                                            pkinds.Add(kits0);
                                            kits.RemoveAt(cantidad);

                                            Console.WriteLine("======================================");
                                            Console.WriteLine("El kit ha costado " + pre);
                                            Console.WriteLine("Monedero actual: " + billetera);
                                            Console.WriteLine("======================================");

                                        }
                                        break;
                                      }


                                      else
                                      {
                                        Console.WriteLine("======================================");
                                        Console.WriteLine("No hay dinero suficiente en el monedero");
                                        Console.WriteLine("======================================");
                                      }
                                      break;



                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("======================================");
                                Console.WriteLine("No hay kits disponibles para comprar");
                                Console.WriteLine("======================================");
                            }
                            break;



                        case 7:
                            if (pindividuals.Any())
                            {
   
                               Console.WriteLine("nombre del Producto a vender: ");
                                Console.WriteLine("================================");
                                string nombrep1 = Console.ReadLine();
                                for (int cantidad = 0; cantidad < pindividuals.Count; cantidad++)
                                {
                                    if (nombrep1 == pindividuals[cantidad].Pnombre)
                                    {
                                        Producto productos2 = new Producto(pindividuals[cantidad].Pnombre, pindividuals[cantidad].Pcodigo, pindividuals[cantidad].Pprecio, pindividuals[cantidad].Pimportado);

                                         int ppre = pindividuals[cantidad].Pprecio;

                                        billetera = billetera + (((ppre*19)/100) + ppre);
                                        productos.Add(productos2);
                                        pindividuals.RemoveAt(cantidad);

                                       Console.WriteLine("==========================================");
                                       Console.WriteLine("El producto valia "+ ppre + " y se le ha aplicado un IVA del 19% y se ha vendido a " + (((ppre * 19) / 100) + ppre));
                                       Console.WriteLine("Monedero actual: " + billetera);
                                       Console.WriteLine("==========================================");


                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("==========================================");
                                Console.WriteLine("No hay productos disponibles para vender");
                                Console.WriteLine("==========================================");
                            }
                            break;



                        case 8:
                            if (pkinds.Any())
                            {
                                Console.WriteLine("nombre del Kit a vender: ");
                                Console.WriteLine("===========================");
                                string nombrep01 = Console.ReadLine();
                                for (int cantidad = 0; cantidad < pkinds.Count; cantidad++)
                                {
                                    if (nombrep01 == pkinds[cantidad].Knombre)
                                    {
                                        Pkits kits01 = new Pkits(kits[cantidad].Knombre, kits[cantidad].Kcodigo, kits[cantidad].Kprecio, kits[cantidad].Cantidad0, kits[cantidad].Pnombre, kits[cantidad].Pcodigo, kits[cantidad].Pprecio, kits[cantidad].Pimportado);

                                      int pre = kits[cantidad].Kcodigo;
                                      int pr = pkinds[cantidad].Kprecio;

                                      if (pre >= 12)
                                      {
                                        billetera = billetera + ((pr*5)/100 - pr);
                                        kits.Add(kits01);
                                        pkinds.RemoveAt(cantidad);
                                        Console.WriteLine("precio de kit: " + pr + " valor de kit con descuento: "+ ((pr * 5) / 100 - pr));
                                        Console.WriteLine("Monedero actual: " + billetera);
                                    }
                                      else
                                      {

                                        billetera = billetera + pkinds[cantidad].Kprecio;
                                        kits.Add(kits01);
                                        pkinds.RemoveAt(cantidad);
                                        Console.WriteLine("precio de kit: " + pr);
                                        Console.WriteLine("Monedero actual: " + billetera);
                                    }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("====================================");
                                Console.WriteLine("No hay kits disponibles para vender");
                                Console.WriteLine("====================================");
                            }
                            break;

                        case 9:
                            if (pindividuals.Any())
                            {
                                Console.WriteLine("El cliente possee {0} productos", pindividuals.Count);
                                foreach (Producto result in pindividuals)
                                {
                                    Console.WriteLine("===========================");
                                    Console.WriteLine("INFORMACION DEL PRODUCTO:");
                                    Console.WriteLine("===========================");
                                    Console.WriteLine("");
                                    Console.WriteLine("Nombre del producto: " + result.Pnombre);
                                    Console.WriteLine("");
                                    Console.WriteLine("  Codigo del producto: " + result.Pcodigo);
                                    Console.WriteLine("  Precio del producto" + result.Pprecio);
                                    Console.WriteLine("  Nacional(True) o Importado(False): " + result.Pimportado);
                                    Console.WriteLine("=====================================================");

                                }
                            }
                            else
                            {
                                Console.WriteLine("================================");
                                Console.WriteLine("El cliente no posee productos");
                                Console.WriteLine("================================");
                            }
                            break;

                        case 10:
                            if (pkinds.Any())
                            {
                                Console.WriteLine("El cliente posee {0} kits", pkinds.Count);
                                foreach (Pkits result in pkinds)
                                {
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("INFORMACION DEL KIT:");
                                    Console.WriteLine("=====================");
                                    Console.WriteLine("");
                                    Console.WriteLine("Nombre del Kit: " + result.Knombre);
                                    Console.WriteLine("");
                                    Console.WriteLine("  Codigo del Kit: " + result.Kcodigo);
                                    Console.WriteLine("  Precio del Kit: " + result.Kprecio);
                                    Console.WriteLine("  Nombre del producto: " + result.Pnombre);
                                    Console.WriteLine("  Cantidad del producto: " + result.Cantidad0);
                                    Console.WriteLine("=============================================");

                                }
                            }
                            else
                            {
                                Console.WriteLine("===========================");
                                Console.WriteLine("El cliente no posee kits");
                                Console.WriteLine("============================");
                            }
                            break;



                        case 11:
                            Console.WriteLine("==============================================");
                            Console.WriteLine("El dineor actual del cliente es: " + billetera);
                            Console.WriteLine("==============================================");



                            break;
                        case 0:
                          Environment.Exit(0);
                          break;

                }


                }
                while (valor != 0);
        }



        
    }


   
  
   
}

