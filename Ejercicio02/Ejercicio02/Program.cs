decimal precio;
Console.Write("Ingrese el precio del producto: ");
while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0)
{
    Console.WriteLine("Error: Ingrese un precio decimal válido mayor que 0.");
    Console.Write("Ingrese el precio del producto: ");
}
Console.WriteLine($"Precio ingresado: {precio}");