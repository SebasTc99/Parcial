using System;

class Articulo
{
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public double Valor { get; set; }
    public int CantidadExistente { get; set; }
}

class Almacen
{
    private Articulo[] articulos;
    private int cantidadArticulos;

    public Almacen(int capacidad)
    {
        articulos = new Articulo[capacidad];
        cantidadArticulos = 0;
    }

    public void AgregarArticulo(Articulo articulo)
    {
        articulos[cantidadArticulos] = articulo;
        cantidadArticulos++;
    }

    public Articulo BuscarArticulo(string codigo)
    {
        for (int i = 0; i < cantidadArticulos; i++)
        {
            if (articulos[i].Codigo == codigo)
            {
                return articulos[i];
            }
        }
        return null;
    }
}

class Factura
{
    private Almacen almacen;
    private Articulo[] items;
    private int[] cantidades;
    private int cantidadItems;

    public Factura(Almacen almacen, int capacidad)
    {
        this.almacen = almacen;
        items = new Articulo[capacidad];
        cantidades=new int[capacidad];
        cantidadItems = 0;
    }

    public void AgregarItem(string codigo, int cantidad)
    {
        Articulo articulo = almacen.BuscarArticulo(codigo);
        if (articulo != null && articulo.CantidadExistente>=cantidad)
        {
            items[cantidadItems] = articulo;
            cantidades[cantidadItems] = cantidad;
            cantidadItems++;
            articulo.CantidadExistente -= cantidad;
        }
        else
        {
            Console.WriteLine("No Existe la cantidad para el articulo " + codigo);
        }
    }

    public void ImprimirFactura()
    {
        double totalFactura = 0;
        Console.WriteLine("------ Factura ------");
        for (int i = 0; i < cantidadItems; i++)
        {
            Articulo item = items[i];
            int cantidad = cantidades[i];
            double subtotal = item.Valor * cantidades[i];
            double iva = subtotal * 0.19; 
            double total = subtotal + iva;

            Console.WriteLine("Código: "+ items[i].Codigo);
            Console.WriteLine("Nombre: "+ items[i].Nombre);
            Console.WriteLine("Valor: "+ items[i].Valor);
            Console.WriteLine("Cantidad: "+ cantidad);
            Console.WriteLine("IVA: "+ iva);
            Console.WriteLine("Subtotal: "+ subtotal);
            Console.WriteLine("Total: "+ total);
            totalFactura += total;
            Console.WriteLine("---------------------");
        }
        Console.WriteLine("Total a pagar: "+ totalFactura);
    }
}

class Almacen
{
    static void Main(string[] args)
    {
        Almacen almacen = new Almacen(10); // Capacidad del vector: 10
        Articulo articulo1 = new Articulo { Codigo = "1", Nombre = "Jabon", Valor = 10000, CantidadExistente = 100 };
        Articulo articulo2 = new Articulo { Codigo = "2", Nombre = "Mantequilla", Valor = 5000, CantidadExistente = 50 };
        Articulo articulo3 = new Articulo { Codigo = "3", Nombre = "Azucar", Valor = 2500, CantidadExistente = 150 };
        Articulo articulo4 = new Articulo { Codigo = "4", Nombre = "Sal", Valor = 2000, CantidadExistente = 58 };
        Articulo articulo5 = new Articulo { Codigo = "5", Nombre = "Frijol", Valor = 2800, CantidadExistente = 50 };
        almacen.AgregarArticulo(articulo1);
        almacen.AgregarArticulo(articulo2);
        almacen.AgregarArticulo(articulo3);
        almacen.AgregarArticulo(articulo4);
        almacen.AgregarArticulo(articulo5);

        Factura factura = new Factura(almacen, 10); // Capacidad del vector: 10

        bool continuar = true;
        while (continuar)
        {
            
            Console.WriteLine("Ingrese el código del producto:");
            string codigoProducto = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad:");
            int cantidad = int.Parse(Console.ReadLine());

            
            factura.AgregarItem(codigoProducto, cantidad);

            Console.WriteLine("¿Desea agregar otro producto? (1=Si/2=No)");
            string respuesta = Console.ReadLine();
            if (respuesta != "1")
            {
                continuar = false;
            }
        }

        factura.ImprimirFactura();
    }
}
