using System;

// Name: Midweek Day
// Titulo: Dia laboral de la semana
// Descripcion: Solicita al usuario un numero entre 1 y 7 y muestra el dia de la semana correspondiente, pero solo considerando los dias laborables.

Console.Write("Ingrese un numero entre 1 y 7: ");
int dia = int.Parse(Console.ReadLine());

if (dia == 1)
{
    Console.WriteLine("Resultado: Lunes");
}
else if (dia == 2)
{
    Console.WriteLine("Resultado: Martes");
}
else if (dia == 3)
{
    Console.WriteLine("Resultado: Miercoles");
}
else if (dia == 4)
{
    Console.WriteLine("Resultado: Jueves");
}
else if (dia == 5)
{
    Console.WriteLine("Resultado: Viernes");
}
else
{
    Console.WriteLine("Resultado: Numero fuera del rango laboral.");
}
