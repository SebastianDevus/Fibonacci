int numero1 = 0;
int numero2 = 1;

Console.Clear();

Console.WriteLine("--------------- Sequência de Fibonacci ---------------");
Console.Write("Quantos números da sequência você deseja (>= 2)? ");

int contador = Convert.ToInt32(Console.ReadLine());

if (contador <= 2)
{
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\nA quantidade de números deve ser igual ou maior que 2!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.Write($"{numero1} {numero2} ");
    // Deve sempre exibir 0 1 e seguir na sequência até a quantidade de números desejada

    // Usa-se 'contador - 2' para remover os dois números iniciais (0 e 1) da conta para o laço
    for (int i = 1; i <= contador - 2; i++)
    {
        int resultado = numero2 + numero1;
        numero1 = numero2;
        numero2 = resultado;
        Console.Write($"{numero2} ");
    }
}
Console.WriteLine("\n");
Console.ResetColor();