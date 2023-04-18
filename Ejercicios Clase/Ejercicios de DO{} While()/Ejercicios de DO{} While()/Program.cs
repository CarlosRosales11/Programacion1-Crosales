//Ejercicios de DO{}While()

// 1) Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave, repetir este ingreso hasta que el usuario ingrese la clave correcta: 667788
/*
class Registro
{
    static void Main(string[] args)
    {
        string nombreDeUsuario;
        string clave;

        do
        {
            Console.Write("Ingrese su nombre de usuario: ");
            nombreDeUsuario = Console.ReadLine();

            Console.Write("Ingrese su clave: ");
            clave = Console.ReadLine();
        } while (clave != "667788");

        Console.WriteLine("¡Bienvenido al sistema!");

    }
}
*/

// 2) Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que ingrese un positivo.
/*
class Positivo
{
    static void Main(string[] args)
    {
        int num;

        do
        {
            Console.Write("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

        } while (num <= 0);

        Console.WriteLine("El número ingresado es: " + num);
           
    }
}
*/

// 3) Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de los números negativos ingresados
/*
class promedioNegativos
{
    static void Main(string[] args)
    {
        int num;
        int negativos = 0;
        int sumaNegativos = 0;

        do
        {
            Console.Write("Ingrese un número (0 para salir): ");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                negativos++;
                sumaNegativos += num;
            }
        
        } while (num != 0);

        Console.WriteLine("Saliendo del programa...");

        if (negativos > 0)
        {
            double promedioNegativos = (double) sumaNegativos / negativos;
            Console.WriteLine("El promedio de los números negativos ingresados es: " + promedioNegativos);
        } 
    }
}
*/

// 4) Se le solicitará ingresar números al usuario, se repetirá el pedido hasta que ingrese un número mayor a 3 cifras
/*
class Numeros
{
    static void Main(string[] args)
    {
        int num;

        do
        {
            Console.Write("Ingrese números: ");
            num = int.Parse(Console.ReadLine());
        } while (num < 1000);
        Console.WriteLine("El número ingresado es mayor o igual a 1000");
    }
}
*/

// 5) Siguiendo con el ejercicio anterior, al ingresar uno mayor o menor a 3 cifras se mostrará el promedio de los ingresados. 
/*
class promedioNumeros
{
    static void Main(string[] args)
    {
        int num;
        int suma = 0;
        int contador = 0;
        double promedio;

        do
        {
            Console.Write("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            if (num >= -999 && num <= 999)
            {
                contador++;
                suma += num;
            }

        } while (num < 1000 && num > -1000);

        promedio = (double)suma / contador;

        Console.WriteLine("El promedio de los números ingresados es: " + promedio);
    }
}
*/