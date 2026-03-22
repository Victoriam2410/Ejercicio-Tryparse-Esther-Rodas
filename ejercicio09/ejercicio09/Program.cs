double nota;
Console.Write("Ingrese la nota del estudiante (0-100): ");
while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
{
    Console.WriteLine("Ingrese una nota válida entre 0 y 100.");
}

if (nota >= 60)
{
    Console.WriteLine($"Nota ingresada: {nota} Aprobado.");
}
else
{
    Console.WriteLine($"Nota ingresada: {nota} Reprobado.");
}