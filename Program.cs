// See https://aka.ms/new-console-template for more information
using Figura;

Cuadrado cuadrado = new Cuadrado();

cuadrado.alto=10;
cuadrado.ancho=10;

Console.WriteLine("el area es: "+ cuadrado.area());

Console.WriteLine("-----------------------------------------------------------");
Triangulo triangulo= new Triangulo(10,15);

Console.WriteLine("el area es: "+ triangulo.area());