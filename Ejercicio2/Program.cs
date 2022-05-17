
int PrimerNumero, SegundoNumero;
int Opcion, Resultado;
int Programa = 1;

while (Programa != 0)
{
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Opcion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el primer número");
    PrimerNumero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número");
    SegundoNumero = Convert.ToInt32(Console.ReadLine());

    switch (Opcion)
    {
        case 1:
            Resultado = PrimerNumero + SegundoNumero;
            break;
        case 2:
            Resultado = PrimerNumero - SegundoNumero;
            break;
        case 3:
            Resultado = PrimerNumero * SegundoNumero;
            break;
        default:
            Resultado = PrimerNumero / SegundoNumero;
            break;
    }

    Console.WriteLine("El resultado es " + Resultado);
    
    Console.WriteLine("¿Desea realizar otra operación? 1 - Si , 0 - No");
    Programa = Convert.ToInt32(Console.ReadLine());
}
