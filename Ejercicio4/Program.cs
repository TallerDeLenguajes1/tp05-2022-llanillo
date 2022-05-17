using System.Data;
using System.Text.RegularExpressions;

string Cadena;
string Cadena2;

Console.WriteLine("Ingrese una cadena cualquiera");
Cadena = Console.ReadLine();

Console.WriteLine("Carácteres: " + Cadena[0] + " " + Cadena[1]);
Console.WriteLine("Longitud: " + Cadena.Length);
Console.WriteLine("Concatenada con 'pepe': " + String.Concat(Cadena, "pepe"));
Console.WriteLine("Subcadena: " + Cadena.Substring(3));

Console.WriteLine("Palabra mostrada carácter por carácter");
foreach(char Caracter in Cadena){
    Console.WriteLine(Caracter);
}

Console.WriteLine("Buscar la palabra 'pepe' en la cadena");
Console.WriteLine(Cadena.Contains("pepe"));

Console.WriteLine("Palabra en mayúsculas");
Console.WriteLine(Cadena.ToUpper());

Console.WriteLine("Palabra en minúsculas");
Console.WriteLine(Cadena.ToLower());

Console.WriteLine("Ingrese otra cadena");;
Cadena2 = Console.ReadLine();

Console.WriteLine("Comparación de las cadenas");
Console.WriteLine();
Console.WriteLine(String.Compare(Cadena, Cadena2));

Console.WriteLine("Ingrese una ecuación");
Cadena = Console.ReadLine();

float Respuesta = (float) Convert.ToDouble(new DataTable().Compute(Cadena, null));
Console.WriteLine("Respueata: " + Respuesta);
