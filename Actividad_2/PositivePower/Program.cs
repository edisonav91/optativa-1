using System;

// Name: Positive Power
// Titulo: Potencia positiva
// Descripcion: Solicita al usuario un numero y eleva este numero al cuadrado solo si es positivo.

Console.Write("Ingrese un numero: ");
double valor = double.Parse(Console.ReadLine());

if (valor > 0)
{
    Console.WriteLine("Resultado: " + (valor * valor));
}
else if (valor == 0)
{
    Console.WriteLine("Resultado: 0");
}
else
{
    Console.WriteLine("Resultado: Numero negativo.");
}
