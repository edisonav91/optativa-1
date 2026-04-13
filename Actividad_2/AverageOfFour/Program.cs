using System;

// Ejercicio 11
// Name: Average Of Four
// Titulo: Promedio de cuatro numeros
// Descripcion: Pide al usuario cuatro numeros y muestra el promedio.

Console.Write("Ingrese el primer numero: ");
double primero = double.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
double segundo = double.Parse(Console.ReadLine());

Console.Write("Ingrese el tercer numero: ");
double tercero = double.Parse(Console.ReadLine());

Console.Write("Ingrese el cuarto numero: ");
double cuarto = double.Parse(Console.ReadLine());

double promedio = (primero + segundo + tercero + cuarto) / 4;

Console.WriteLine("Resultado: " + promedio);
