DateTime fecha;
Console.Write("Ingrese una fecha (dd/mm/aaaa): ");
while (!DateTime.TryParse(Console.ReadLine(), out fecha))
{
    Console.WriteLine("Ingrese una fecha válida.");
}

Console.WriteLine($"Fecha ingresada: {fecha}");