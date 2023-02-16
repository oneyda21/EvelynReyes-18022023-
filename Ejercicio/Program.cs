using System;
using Ejercicio.Entidades;
using Ejercicio.Negocio;




Nombres nombre = new Nombres();
ClsOperacion clsNombre = new ClsOperacion();

Console.WriteLine("Ingresa tu nombre u otras palabras para contar la cantidad de letras que contiene");
String? Dato = Console.ReadLine();



Console.WriteLine(clsNombre.Resultado(nombre));
Console.WriteLine(Dato.Length);
