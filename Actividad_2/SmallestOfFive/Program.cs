using System;

// Ejercicio 14
// Name: Smallest Of Five
// Titulo: Menor de cinco numeros
// Descripcion: Pide al usuario cinco numeros y muestra el mas pequeno.

Console.Write("Ingrese el primer numero: ");
double primero = double.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
double segundo = double.Parse(Console.ReadLine());

Console.Write("Ingrese el tercer numero: ");
double tercero = double.Parse(Console.ReadLine());

Console.Write("Ingrese el cuarto numero: ");
double cuarto = double.Parse(Console.ReadLine());

Console.Write("Ingrese el quinto numero: ");
double quinto = double.Parse(Console.ReadLine());

double menor = primero;

if (segundo < menor)
{
    menor = segundo;
}

if (tercero < menor)
{
    menor = tercero;
}

if (cuarto < menor)
{
    menor = cuarto;
}

if (quinto < menor)
{
    menor = quinto;
}

Console.WriteLine("Resultado: " + menor);
