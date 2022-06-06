
Console.WriteLine("Este programa le informará en qué países usted es mayor de edad");
Console.WriteLine();

Console.WriteLine("Por favor, ingrese su edad:");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine($"La edad ingresada es: {edad}");

if (edad >= 15)
{
    Console.WriteLine("Con +15 usted es mayor de edad en Irán e Indonesia.");
}
 if (edad >= 16)
{
    Console.WriteLine("Con +16 usted es mayor de edad en Escocia, Cuba y Vietnam");
}
 if (edad >= 17)
{
    Console.WriteLine("Con +17 usted es mayor de edad en Corea del Norte");
}
 if (edad >= 18)
{
    Console.WriteLine("Con +18 usted es mayor de edad en Argetina, Estados Unidos, Uruguay, Italia y Brasil");

}
 if (edad >= 19)
{
    Console.WriteLine("Con +19 usted es mayor de edad en Corea del Sur y Argelia");
}
 if (edad >= 20)
{
    Console.WriteLine("Con +20 usted es mayor de edad en Taiwán y Tailandia");
}
 if (edad >= 21)
{
    Console.WriteLine("Con +21 usted es mayor de edad en Egipto, Honduras y Singapur");
}
 else if (edad <= 14)
{
    Console.WriteLine("Usted es menor de edad en todo el mundo");
}
Console.ReadKey();  