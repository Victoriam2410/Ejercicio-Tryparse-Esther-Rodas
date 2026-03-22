double numero;
Console.Write("Ingrese un número para calcular su raíz cuadrada: ");
while (!double.TryParse(Console.ReadLine(), out numero) || numero < 0)
{
    Console.WriteLine("Ingrese un número válido mayor o igual a 0.");
}

double raiz = Math.Pow(numero, 0.5);
Console.WriteLine($"La raíz cuadrada es: {raiz}");