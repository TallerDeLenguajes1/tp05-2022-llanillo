    
using System.Runtime.InteropServices;

int Numero;

Console.WriteLine("Ingrese un número");

Numero = Convert.ToInt32(Console.ReadLine());

if (Numero > 0)
{
    Console.WriteLine("El número invertido es: " + Invertir(Numero));
}
else
{
    Console.WriteLine("No cumple la condición para invertirlo");
}

int Invertir(int Numero)
{
    int Suma = 0;

    while (Numero != 0)
    {
        Suma = Suma * 10 + Numero % 10;
        Numero /= 10;
    }

    return Suma;
}
    