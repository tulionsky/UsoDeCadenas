/* 1. Escribir un programa que le pida al usuario un número entero positivo y le muestre un menú con las siguientes opciones: */
int opcion;
do
{
    int numero;
    do
    {
        Console.Write("Ingrese un número entero positivo: ");
    } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);
    do
    {
        Console.WriteLine("Menú:");
        Console.WriteLine("1. Calcular el factorial del número.");
        Console.WriteLine("2. Calcular la raíz cuadrada del número.");
        Console.WriteLine("3. Salir del programa.");
        Console.Write("Seleccione una opción: ");
    } while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3);
    switch (opcion)
    {
        case 1:
            long fact = 1;
            for (int i = 1; i <= numero; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"El factorial de {numero} es {fact}.");
            break;
        case 2:
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"La raíz cuadrada de {numero} es {raiz}.");
            break;
        case 3:
            Console.WriteLine("¡Ya te cansaste? Bye Bye");
            break;
        default:
            Console.WriteLine("Opción invalida. Por favor seleccione una opción del menú.");
            break;
    }
} while (opcion != 3);

/* 2. Escribir un programa que solicite al usuario dos números enteros y un operador matemático (+, -, *, /) */
//int opcion;
//Console.Write("Ingrese el primer número: ");
//int.TryParse(Console.ReadLine(), out int numero1);

//Console.Write("Ingrese el segundo número: ");
//int.TryParse(Console.ReadLine(), out int numero2);

//Console.Write("Ingrese el operador (+, -, *, /): ");
//string entrada = Console.ReadLine();

//double resultado = 0;
//switch (entrada)
//{
//    case "+":
//        resultado = numero1 + numero2;
//        break;
//    case "-":
//        resultado = numero1 - numero2;
//        break;
//    case "*":
//        resultado = numero1 * numero2;
//        break;
//    case "/":
//        if (numero2 == 0)
//        {
//            Console.WriteLine("No se puede dividir por cero.");
//            return;
//        }
//        resultado = (double)numero1 / numero2;
//        break;
//    default:
//        Console.WriteLine("Esa operacion es invalida.");
//        return;
//}
//Console.WriteLine($"El resultado de la operación es: {resultado}");

/* 3. Escribir un programa que imprima una tabla de multiplicar del 1 al 10 para un número introducido por el usuario. */
//int opcion;

//Console.Write("Ingrese el número del que desea ver la tabla: ");
//int.TryParse(Console.ReadLine(), out int numero);

//Console.WriteLine($"Tabla de multiplicar de {numero} es:");
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{numero} x {i} = {numero * i}");
//}

/* 4. Escribir un programa que adivine un número secreto entre 1 y 100.  */
//Random num = new Random();
//int numAl= num.Next(1, 101);
//int intento;

//Console.WriteLine("¡Adivina el número entre 1 y 100!");

//do
//{
//    Console.Write("Introduce tu intento: ");
//    intento = int.Parse(Console.ReadLine());

//    if (intento < numAl)
//    {
//        Console.WriteLine("El número es mayor. Bajale un poquito");
//    }
//    else if (intento > numAl)
//    {
//        Console.WriteLine("El número es menor. Dale un poco mas");
//    }
//} while (intento != numAl);

//Console.WriteLine("¡ESOOO! ¡Has adivinado el número " + numAl + "!");