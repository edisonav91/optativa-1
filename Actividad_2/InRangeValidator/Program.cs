using System;

// Ejercicio 13
// Name: In Range Validator
// Titulo: Validar rango
// Descripcion: Pide un numero al usuario y verifica si esta en el rango de 10 a 20, ambos incluidos.

Console.Write("Ingrese un numero: ");
int valor = int.Parse(Console.ReadLine());

if (valor >= 10 && valor <= 20)
{
    Console.WriteLine("Resultado: Esta en el rango.");
}
else
{
    Console.WriteLine("Resultado: Fuera del rango.");
}
