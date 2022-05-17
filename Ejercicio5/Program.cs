
using System.Text.RegularExpressions;

string Cadena;

Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
Regex WebRegex = new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*");

Console.WriteLine("Ingrese la cadena");
Cadena = Console.ReadLine();

Match EmailMatch = EmailRegex.Match(Cadena);
Match WebMatch = WebRegex.Match(Cadena);

if (EmailMatch.Success || WebMatch.Success)
{
    Console.WriteLine("Es correcta la cadena");
}
else
{
    Console.WriteLine("No es correcta");
}