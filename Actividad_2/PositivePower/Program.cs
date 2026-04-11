using System;

// Name: Positive Power
// Titulo: Potencia positiva
// Se debe hacer: Pedir un numero y elevarlo al cuadrado si es positivo.

Console.Write("Ingrese un numero: ");
double numero = Convert.ToDouble(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("Resultado: " + (numero * numero));
}
else if (numero == 0)
{
    Console.WriteLine("Resultado: 0");
}
else
{
    Console.WriteLine("Resultado: Numero negativo.");
}
