decimal salario;
Console.Write("Ingrese el salario del empleado: ");
while (!decimal.TryParse(Console.ReadLine(), out salario) || salario < 0)
{
    Console.WriteLine("Ingrese un salario decimal válido mayor o igual a 0.");
}

Console.WriteLine($"Salario ingresado: {salario}");