﻿using System;

namespace almacen
{
    class Program
    {
      
        private static int almacen()
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
            int valor = -1;

            do
            {
                valor = almacen();


                switch (valor)
                {
                    case 1:
                        Console.WriteLine(" ingresar nombre del Producto : ");
                        string nombrep = Console.ReadLine();
                        Console.WriteLine("ingresar codigo del producto");
                        int pcodigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresar precio del producto");
                        int pprecio = int.Parse(Console.ReadLine());
                        Console.WriteLine("elegir entre nacional e importada");
                        bool pimportado = bool.Parse(Console.ReadLine());

                        Producto producto = new Producto(nombrep, pcodigo, pprecio, pimportado);
                        productos.Add(producto);

                        break;

                    case 2:
                        Console.WriteLine(" ingresar nombre del kit");
                        string nombrep = Console.ReadLine();
                        Console.WriteLine("ingresar codigo del kit");
                        int pcodigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresar precio del kit");
                        int pprecio = int.Parse(Console.ReadLine());

                        Producto producto = new Producto(nombrep, pcodigo, pprecio);
                        productos.Add(producto);
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;

                    case 10:
                        break;

                    case 11:
                        break;


                }

    }


}
