int numero;
Console.Write("Ingrese un número entero: ");
while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Ingrese un número entero válido.");
}

if (numero % 2 == 0)
{
    Console.WriteLine($"El número {numero} es par.");
}
else
{
    Console.WriteLine($"El número {numero} es impar.");
}
