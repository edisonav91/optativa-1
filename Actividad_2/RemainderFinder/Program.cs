using System;

// Name: Remainder Finder
// Titulo: Hallar residuo
// Descripcion: Solicita dos numeros y muestra el residuo de la division del primero entre el segundo.

Console.Write("Ingrese el primer numero: ");
int primero = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
int segundo = int.Parse(Console.ReadLine());

int residuo = primero % segundo;

Console.WriteLine("Resultado: " + residuo);
