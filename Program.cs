//By Silktz 
Console.WriteLine("Hello, World!");

int numero, multiplo, resultado;

Console.WriteLine("Digite qualquer número: ");
numero = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite um numero a ser verificado como múltiplo: ");
multiplo = int.Parse(Console.ReadLine()!);

if (numero % multiplo == 0)
{
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"{numero} é multiplo por {multiplo}");
    }

    else 
    {
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{numero} não é multiplo por {resultado=multiplo}");
    }



