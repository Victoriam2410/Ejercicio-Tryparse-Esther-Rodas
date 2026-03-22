int edad;
Console.Write("Ingrese la edad: ");
while (!int.TryParse(Console.ReadLine(), out edad) || edad <0)
{
    Console.WriteLine("ingrese una edad valida.");
}
Console.WriteLine($"Edad ingresada: {edad}");
