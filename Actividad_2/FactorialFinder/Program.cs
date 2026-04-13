using System;

// Ejercicio 12
// Name: Factorial Finder
// Titulo: Factorial de un numero
// Descripcion: Pide un numero al usuario y devuelve el factorial de ese numero.

Console.Write("Ingrese un numero: ");
int valor = int.Parse(Console.ReadLine());

long factorial = 1;

for (int i = 1; i <= valor; i++)
{
    factorial = factorial * i;
}

Console.WriteLine("Resultado: " + factorial);
