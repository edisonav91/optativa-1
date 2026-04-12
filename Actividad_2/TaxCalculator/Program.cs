using System;

// Name: Tax Calculator
// Titulo: Calculo de impuesto
// Descripcion: Solicita al usuario su salario anual y, si este excede los 12000, muestra el impuesto a pagar que es el 15% del excedente.

Console.Write("Ingrese su salario anual: ");
double salario = double.Parse(Console.ReadLine());

if (salario > 12000)
{
    double extra = salario - 12000;
    double impuesto = extra * 0.15;
    Console.WriteLine("Resultado: " + impuesto);
}
else
{
    Console.WriteLine("Resultado: No debe impuestos.");
}
