int cantidad;
Console.Write("Ingrese la cantidad de estudiantes: ");
while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
{
    Console.WriteLine("Ingrese un número entero positivo.");
}
Console.WriteLine($"Cantidad de estudiantes ingresada: {cantidad}");