using System;

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
                        Console.WriteLine("nombre Producto : ");
                        string nombrep = Console.ReadLine();
                        Console.WriteLine("numeros de horas requeridas para la instalacion");
                        int nroHoras = int.Parse(Console.ReadLine());
                        Console.WriteLine("Cuanto es el costo por hora ");
                        int costoHora = int.Parse(Console.ReadLine());
                        Console.WriteLine("Cuanto es el costo por hora ");
                        int costoHora = int.Parse(Console.ReadLine());

                        Producto producto = new Producto(nombrep, nroHoras, costoHora);
                        productos.Add(producto);

                        break;

                    case 2:
                        Console.WriteLine("nombre Producto : ");
                        string nombrep = Console.ReadLine();
                        Console.WriteLine("numeros de horas requeridas para la instalacion");
                        int nroHoras = int.Parse(Console.ReadLine());
                        Console.WriteLine("Cuanto es el costo por hora ");
                        int costoHora = int.Parse(Console.ReadLine());
                        Console.WriteLine("Cuanto es el costo por hora ");
                        int costoHora = int.Parse(Console.ReadLine());

                        Producto producto = new Producto(nombrep, nroHoras, costoHora);
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
