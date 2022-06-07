/*
1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5 
*/



int[] misNumeros = new int[10];

for (int i = 0; i < misNumeros.Length; i++)
{
    Console.WriteLine($"Por favor ingrese el número {+i + 1}");
    misNumeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;  
for (int i = 0; i < 10; i++)
{
    suma = suma + misNumeros[i];
}

int mayor = 0;
for (int i = 0; i < 10; i++)
{
    if (misNumeros[i] > mayor)
    {
        mayor = misNumeros[i];
    }
}
Console.WriteLine($"El número más alto ingresado es {mayor}");

int menor = mayor;
for (int i = 0; i < 10; i++)
{
    if (misNumeros[i] < menor)
    {
        menor = misNumeros[i];
    }
}
Console.WriteLine($"El número más bajo ingresado es: {menor}");

int promedio = 0;
for (int i = 0; i<10; i++)
{
    promedio = suma / misNumeros.Length;
}
Console.WriteLine($"El promedio de los números ingresados es: {promedio}"); 

Console.WriteLine($"Los números ingresados fueron: "); 
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(misNumeros[i]);
}