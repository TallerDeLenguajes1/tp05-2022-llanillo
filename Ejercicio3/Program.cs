using System;

float PrimerNumero, SegundoNumero;

Console.WriteLine("Ingrese un número");
PrimerNumero = (float) Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Valor Absoluto: " + Math.Abs(PrimerNumero));
Console.WriteLine("Valor Cuadrado: " + Math.Pow(PrimerNumero, 2));
Console.WriteLine("Raíz Cuadrada: " + Math.Pow(PrimerNumero, 0.5f));
Console.WriteLine("Seno: " + Math.Sin(PrimerNumero));
Console.WriteLine("Coseno: " + Math.Cos(PrimerNumero));
Console.WriteLine("Parte Entera " + Math.Floor(PrimerNumero));

Console.WriteLine("Ingrese el primer número");
PrimerNumero = (float) Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número");
SegundoNumero = (float) Convert.ToDouble(Console.ReadLine());

Console.WriteLine("El máximo entre los dos es: " + Math.Max(PrimerNumero, SegundoNumero));
Console.WriteLine("El mínimo entre los dos es: " + Math.Min(PrimerNumero, SegundoNumero));