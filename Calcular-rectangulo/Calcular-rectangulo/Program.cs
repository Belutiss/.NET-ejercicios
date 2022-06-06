
Console.Clear();

Console.WriteLine("Este programa calculará la superficie de un rectángulo");
Console.WriteLine();

Console.WriteLine("Por favor, ingrese la base del rectángulo");
double baseRectángulo = double.Parse(Console.ReadLine());

Console.WriteLine("Excelente! Ahora ingrese la altura del rectángulo");
double alturaRectángulo = double.Parse(Console.ReadLine());

double superficieRectángulo = baseRectángulo * alturaRectángulo;

Console.WriteLine($"La superficie del rectángulo ingresado es: {superficieRectángulo}");
Console.WriteLine();

if (superficieRectángulo > 10)
{
    Console.WriteLine("La superficie del rectángulo es mayor a 10");
}
else if (superficieRectángulo == 10)
{
    Console.WriteLine("La superficie del rectángulo es igual a 10");
}
else Console.WriteLine("La superficie del rectángulo es menor a 10 ");

Console.ReadKey();
