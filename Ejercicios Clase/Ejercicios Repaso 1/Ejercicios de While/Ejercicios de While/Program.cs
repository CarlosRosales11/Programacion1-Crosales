// Ejercicios de While

// 1) El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0 (cero) El sistema deberá informar la suma de los ingresados
/*
class sumaPositivos
{
    static void Main(String[] args)
    {
        int num;
        int suma = 0;   

        Console.Write("Ingrese números positivos y cuando quiera cortar presione 0: "); 
        num = int.Parse(Console.ReadLine());

        while (num > 0)
        {
            suma = suma + num;
            Console.Write("Ingrese otro número para la suma: ");
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("La suma es: " + suma);
    }
}
*/

// 2) Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados
/*
class promedioPositivos
{
    static void Main(String[] args)
    {
        int num;
        int suma = 0;
        int contador = 0;
        double promedio;

        Console.Write("Ingrese números positivos y cuando quiera cortar presione 0: ");
        num = int.Parse(Console.ReadLine());

        while (num > 0)
        {
            suma = suma + num;
            contador++;
            Console.Write("Ingrese otro número para la suma: ");
            num = int.Parse(Console.ReadLine());
        }
        if (contador > 0)
        {
            promedio = (double)suma / contador;
            Console.WriteLine("El promedio es: " + promedio);
        }
        else
        {
            Console.WriteLine("No se ingresaron números positivos.");
        }
    }
}
*/

// 3) El usuario ingresará una lista de nombres de personas, cuando se ingresé un nombre vacío, sin datos; el sistema informará cuántos nombres se han ingresado.
/*
class listaNombres
{
    static void Main(string[] args)
    {
        string nombres ;
        int suma = 0;
        int contador = 0;

        Console.Write("Ingrese la lista de nombres, una vez que finalice precione enter: ");
        nombres = Console.ReadLine();

        while (nombres != "")
        {
            contador++;
            Console.Write("Ingrese otro nombre o enter para salir: ");
            nombres = Console.ReadLine();
        }
        Console.WriteLine("La cantidad de nombres ingresados es: " + contador);
    }
}
*/

// 4) Para calcular el total de una factura , el usuario ingresará pares de datos Costo y Total ; cuando se ingrese costo 0 finaliza el ingreso de datos; informar el total adeudado.
/*
class totalFactura
{
    static void Main(string[] args)
    {
        string costo;
        string total;
        int costoNum;
        int suma = 0;
        int totalNum;

        Console.Write("Ingrese el costo: ");
        costo = Console.ReadLine(); 
        costoNum = int.Parse(costo);
       
        while (costoNum > 0)
        {
            Console.Write("Ingrese el total: ");
            total = Console.ReadLine();
            totalNum = int.Parse(total);

            suma = suma + (costoNum * totalNum);

            Console.Write("Ingrese el costo: ");
            costo = Console.ReadLine();
            costoNum = int.Parse(costo);
        }
        Console.WriteLine("El total adeudado es: " + suma);
    }
}
*/

// 5) Para calcular el consumo total de un cliente, el usuario primero ingresará cuántos productos compró; luego el sistema solicitará que ingrese el total y costo de cada uno de esos productos consumidos; al terminar informará el total adeudado por el cliente.
/*
class totalCliente
{
    static void Main(string[] args)
    {
        int cantidadProductos;
        int costoProducto = 0;
        int totalConsumido = 0;

        Console.Write("Ingrese la cantidad de productos comprados: ");
        cantidadProductos = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cantidadProductos; i++)
        {
            Console.Write("Ingrese el total del producto: ");
            int totalProductos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el costo del producto: ");
            costoProducto = int.Parse(Console.ReadLine());

            totalConsumido += costoProducto;
        }
        Console.WriteLine("El total adeudado por el cliente es: " + totalConsumido);
        Console.ReadLine();
    }
}
*/