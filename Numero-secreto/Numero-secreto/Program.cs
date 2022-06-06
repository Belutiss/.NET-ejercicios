
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 51);

Console.WriteLine("Adivina el número secreto!");

var contador = 0;
int eleccion;

do
{
    contador++;
    Console.WriteLine("Ingrese un número entre 1 y 50 por favor");
    eleccion = int.Parse(Console.ReadLine());

    if (eleccion > numeroSecreto)
    {
        Console.WriteLine("El número es muy grande. Intente nuevamente por favor");
    }
    else if (eleccion < numeroSecreto)
    {
        Console.WriteLine("El número es muy chico. Intente nuevamente por favor");    
    }
    else
    {
        Console.WriteLine($"Felicitaciones! Has adivinado el número secreto que era: {numeroSecreto} ");
        Console.WriteLine($"Lo has adivinado en {contador} intentos");
    }
}
while (eleccion != numeroSecreto);