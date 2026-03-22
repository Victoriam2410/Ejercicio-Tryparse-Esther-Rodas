int cantidad;
Console.Write("Ingrese la cantidad de productos a comprar: ");
while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
{
    Console.WriteLine("Ingrese un número entero positivo.");
}

for (int i = 1; i <= cantidad; i++)
{
    Console.WriteLine($"Producto {i} ingresado correctamente.");
}

Console.WriteLine($"\nSe han procesado {cantidad} productos.");
