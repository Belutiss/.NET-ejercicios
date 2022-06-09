/*
Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
*/


Console.WriteLine("Ingrese cantidad de filas");
int cantidadFilas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cantidad de columnas");
int cantidadColumnas = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantidadFilas, cantidadColumnas];

int LengthFilas = numeros.GetUpperBound(0) + 1;
int LengthColumnas = numeros.GetUpperBound(1) + 1;

for (int columna = 0; columna < LengthColumnas; columna++)
{
     Console.WriteLine($"Datos columna Nº: {columna + 1} ");

    for (int filas = 0; filas < LengthFilas; filas++)
    {
        Console.WriteLine($"Ingrese dato de la fila Nº {filas + 1}: ");
        numeros[filas, columna] = int.Parse(Console.ReadLine());
    }
}

var promedio = new double[cantidadColumnas];
for (int columna = 0; columna < LengthColumnas; columna++)
{
    double suma = 0;

    for (int filas = 0; filas < LengthFilas; filas++)
    {
        suma += numeros[filas, columna];  
    }
    promedio[columna] = suma / LengthFilas;
}




for (int filas = 0; filas < LengthFilas; filas++)
   {
    Console.WriteLine();

     for (int columna = 0; columna < LengthColumnas; columna++)
    {
        Console.Write($"{numeros[filas, columna]:00} ");
    }
    Console.WriteLine();
}

    Console.WriteLine("==========================================================");
Console.WriteLine("Los promedios de cada columna son los siguientes:");
for (int columna = 0; columna < LengthColumnas; columna++)
{
    Console.Write($"{promedio[columna]:00} ");
}
Console.WriteLine();















//for (int columna = 0; columna < LengthColumnas; columna++)
//{
//    Console.WriteLine("==============================================");
//    Console.WriteLine();
//    Console.WriteLine($"Datos columna Nº: {columna + 1} ");

//    double suma = 0;
//    double promedio = 0;
//    for (int filas = 0; filas < LengthFilas; filas++)
//    {
//        suma += numeros[filas, columna];
//        promedio = suma / LengthFilas;
//        Console.Write($"Dato Nº {filas + 1}: ");
//        Console.WriteLine(numeros[filas, columna]);
//    }
//    Console.WriteLine($"El promedio de la columna {columna + 1} es: {promedio}");
//}