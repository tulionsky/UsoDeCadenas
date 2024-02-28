string cadena1 = "Hola";
string cadena2 = "Hola";

// comparacion
if (cadena1 == cadena2)
{
    Console.WriteLine("Las cadenas son iguales.");
}
else
{
    Console.WriteLine("Las cadenas son diferentes.");
}

if (cadena1.Equals(cadena2, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Las cadenas son iguales, ignorando mayúsculas y minúsculas.");
}
else
{
    Console.WriteLine("Las cadenas son diferentes.");
}


//Concatenacion 
Console.WriteLine("Por favor, ingresa tu nombre:");
string nombre = Console.ReadLine();

Console.WriteLine("Por favor, ingresa tu apellido:");
string apellido = Console.ReadLine();

Console.WriteLine("Por favor, ingresa tu edad:");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine("Hola " + nombre + " " + apellido + ", tienes " + edad + " años.");
Console.WriteLine($"Hola {nombre} {apellido}, tienes {edad} años.");

// Busqueda de cadenas
string texto = "Paciencia debes tener, mi joven padawan.";
string patron = "padawan";

int indice = texto.IndexOf(patron);

if (indice != -1)
{
    Console.WriteLine($"La palabra {patron} fue encontrada en el índice {indice}");
}
else
{
    Console.WriteLine("No se encontraron coincidencias.");
}

if (texto.Contains(patron))
{
    Console.WriteLine($"Se encontró el patrón \"{patron}\" en el texto.");
}
else
{
    Console.WriteLine("No se encontraron coincidencias.");
}
//Formateo de cadenas
string nombre1 = "Luke";
string resultado = $"{nombre1}, Yo soy tu padre!!";
Console.WriteLine(resultado);

string nombre2 = "Anakin";
string nombre3 = "Skywalker";
string resultado1=string.Format("Yo no soy {0} {1},{0} esta muerto.", nombre2, nombre3);
Console.WriteLine(resultado1);

