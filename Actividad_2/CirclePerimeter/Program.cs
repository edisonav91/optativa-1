using System;

// Name: Circle Perimeter
// Titulo: Perimetro de un circulo
// Descripcion: Pide al usuario el radio de un circulo y calcula su perimetro.

Console.Write("Ingrese el radio del circulo: ");
double radio = double.Parse(Console.ReadLine());

double pi = 3.1416;
double resultado = 2 * pi * radio;

Console.WriteLine("Resultado: " + resultado.ToString("F2"));
