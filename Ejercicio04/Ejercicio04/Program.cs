int anioActual = 2026;
int anioNacimiento;

Console.Write("Ingrese su año de nacimiento: ");
while (!int.TryParse(Console.ReadLine(), out anioNacimiento) || anioNacimiento < 1900 || anioNacimiento > anioActual)
{
    Console.WriteLine($" Ingrese un año válido entre 1900 y {anioActual}.");
}

Console.WriteLine($"Año de nacimiento ingresado: {anioNacimiento}");