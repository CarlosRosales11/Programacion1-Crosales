//Ejercicios de  Para - For()

// 1) El usuario necesita ingresar 5 valores enteros, el sistema deberá informar la suma de los 5.
/*
class valoresEnteros
{
    static void Main(string[] args)
    {
        int suma = 0;
        int valor;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ingrese un valor entero a sumar: ");
            valor = int.Parse(Console.ReadLine());
            suma += valor;
        }
        Console.WriteLine("La suma de los valores es: " + suma);
    }
}
*/

// 2) Se necesita calcular el promedio de 8 números ingresados por el usuario.
/*
class promedioNum
{
    static void Main(string[] args)
    {
        double suma = 0;
        double promedio;
        double num;

        for (int i = 1; i <= 8; i++)
        {
            Console.Write("Ingrese números para saber su promedio: ");
            num = double.Parse(Console.ReadLine());
            suma += num;
        }    
        promedio = suma / 8;
        Console.WriteLine("El promedio de los números ingresados es: " + promedio);
    }
}
*/

// 3) Para calcular el total de una factura , el usuario ingresará pares de datos Costo y Total ; de unas 5 compras; informar el total adeudado.
/*
class totalFactura
{
    static void Main(string[] args)
    {
        int totalAdeudado = 0;
        int total;
        int costo;
        int suma = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ingrese el costo: ");
            costo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el total: ");
            total = int.Parse(Console.ReadLine());

           totalAdeudado  += costo - total;
        }
        Console.Write("El total adeudado es: " + totalAdeudado);
    }
}
*/

// 4) De una lista de 8 números indicar cual es el mayor.
/*
class lista
{
    static void Main(string[] args)
    {
        int[] num = { 5, 11, 30, 9, 50, 23, 99, 1 };
        int max = num[0]; // Se inicia con el primer elemento del arreglo.

        for (int i = 1; i < 8; i++)
        {
            if (num[i] > max)
                max = num[i]; // Se actualiza cada vez que encuentra un número mayor al máximo actual.
        }
        Console.WriteLine("El número máximo es: " + max);
    }
}
*/

// 5) El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado, indicar el cliente que gastó más. 
/*
class usuario
{
    static void Main(string[] args)
    {
        int max = 0;
        int total = 0;
        string nombre;
        string nomMáximo = "";

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese el nombre del cliente: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el total gastado por el cliente: ");
            total = int.Parse(Console.ReadLine());

            if (total > max)
            {
                nomMáximo = nombre;
                max = total;
            }
        }
        Console.WriteLine("El cliente que gastó más fue " + nomMáximo + " con un total de $" + max);
    }
}
*/