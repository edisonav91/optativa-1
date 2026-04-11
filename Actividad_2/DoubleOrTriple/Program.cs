using System;

// Name: Double Or Triple
// Titulo: Doble o triple
// Descripcion: Solicita al usuario dos numeros. Si el primero es mayor, devuelve su doble, de lo contrario devuelve el triple del segundo.

Console.Write("Ingrese el primer numero: ");
double primero = double.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
double segundo = double.Parse(Console.ReadLine());

double resultado;

if (primero >= segundo)
{
    resultado = primero * 2;
}
else
{
    resultado = segundo * 3;
}

Console.WriteLine("Resultado: " + resultado);
