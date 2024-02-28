//CONCATENAR CADENAS
using System.Xml.Linq;

string txt1 = "Hola ";
string txt2 = "Que tal?";
string txt3, txt4;
string nombre = "Pablo José";
int edad = 18;
string cadena = "Hola que tal?";

txt3 = txt1 + txt2; //UTILIZANDO "+"
Console.WriteLine(txt3);

txt3 = String.Concat(txt1, txt2); //UTILIZANDO STRING.CONCAT
Console.WriteLine(txt3);

txt4 = string.Format("El nombre de la persona es {0} y su edad es de {1}",nombre,edad); //UTILIZANDO STRING.FORMAT
Console.WriteLine(txt4);

txt4 = $"EL nombre de la persona es {nombre} y la edad es de {edad}"; //UTILIZANDO INTERPOLACION
Console.WriteLine(txt4);

//METODOS Y PROCEDIMIENTOS

int longitud = cadena.Length; //Aqui se devuelve el valor 13, que es el numero de caracteres de la cadena.

Console.WriteLine(cadena.ToUpper()); //ToUpper
Console.WriteLine(cadena.ToLower()); //ToLower

int posicion = cadena.IndexOf("que"); //Aqui devuelve 5 que es la posicion en la que se encuentra "que"

bool contiene = cadena.Contains("Hola"); //Aqui devuelve True

Console.WriteLine(nombre.Replace("Pablo", "Luis")); //Replace;

if ((nombre.StartsWith("Pablo")) && (nombre.EndsWith("José"))) //aqui verifica utilizando Startwish y endWith
    Console.WriteLine("Bonito nombre :)");

bool comparar = txt1.Equals(txt2); //Aqui devuelve Falso porque las cadenas no son iguales

string subcadena = txt2.Substring(4); //Aqui extraera solo la palabra "Tal"

int posicion2 = cadena.LastIndexOf("tal"); //Aqui Devuelve la posicion de la ultima palabra

string txt5 = "   Hola mundo   ";
string txtlimpio = txt5.Trim();
Console.WriteLine(txtlimpio); // Esto imprimirá "Hola mundo" sin espacios

char primerCaracter = cadena[0]; // El primer Caracter será 'H'

string Cadena3 = "   ";
bool cadenavacia = string.IsNullOrWhiteSpace(Cadena3); // el valor de cadenavacia será true

//OPERACIONES DE CADENAS
