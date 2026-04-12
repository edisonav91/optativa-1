using System;

// Name: Fraction Difference
// Titulo: Resta de fracciones
// Descripcion: Solicita al usuario los valores para dos fracciones y muestra la diferencia entre esas fracciones.

Console.Write("Ingrese el numerador de la primera fraccion: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el denominador de la primera fraccion: ");
int den1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el numerador de la segunda fraccion: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el denominador de la segunda fraccion: ");
int den2 = int.Parse(Console.ReadLine());

int numR = num1 * den2 - num2 * den1;
int denR = den1 * den2;

if (numR == 0)
{
    Console.WriteLine("Resultado: 0");
    return;
}

int a = numR;
int b = denR;

if (a < 0)
{
    a = a * -1;
}

if (b < 0)
{
    b = b * -1;
}

while (b != 0)
{
    int residuo = a % b;
    a = b;
    b = residuo;
}

numR = numR / a;
denR = denR / a;

Console.WriteLine("Resultado: " + numR + "/" + denR);
