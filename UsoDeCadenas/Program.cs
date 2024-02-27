//CONCATENAR CADENAS
string txt1 = "Hola ";
string txt2 = "Que tal?";
string txt3, txt4;
string nombre = "Pablo";
int edad = 18;

txt3 = txt1 + txt2; //UTILIZANDO "+"
Console.WriteLine(txt3);

txt3 = String.Concat(txt1, txt2); //UTILIZANDO STRING.CONCAT
Console.WriteLine(txt3);

txt4 = string.Format("El nombre de la persona es {0} y su edad es de {1}",nombre,edad); //UTILIZANDO STRING.FORMAT
Console.WriteLine(txt4);

txt4 = $"EL nombre de la persona es {nombre} y la edad es de {edad}"; //UTILIZANDO INTERPOLACION
Console.WriteLine(txt4);