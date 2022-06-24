string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[1] Soma");
Console.WriteLine("[2] Subtração");
Console.WriteLine("[3] Multiplicação");
Console.WriteLine("[4] Divisão");
Console.WriteLine("[5] Exponenciação");
Console.WriteLine("[6] Radiciação");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "1":
        CalcularSoma();
        break;
    case "2":
        CalcularSubtracao();
        break;
    case "3":
        CalcularMultiplicacao();
        break;
    case "4":
        CalcularDivisao();
        break;
    case "5":
        CalcularExp();
        break;
    case "6":
        CalcularRad();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nObrigado por utilizar nosso programa.");

void CalcularSoma()
{
    double a, b, resultado;

    Console.WriteLine("--- Soma A+B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a + b;

    Console.WriteLine($"{a} somado com {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

void CalcularSubtracao()
{
    double a, b, resultado;

    Console.WriteLine("--- Subtração A-B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a - b;

    Console.WriteLine($"{a} subtraindo {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

void CalcularMultiplicacao()
{
    double a, b, resultado;

    Console.WriteLine("--- Multiplicação A*B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a * b;

    Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

void CalcularDivisao()
{
    double a, b, resultado;

    Console.WriteLine("--- Divisão A/B ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    if (b == 0)
    {
        Console.WriteLine("\nNão é possível dividir por zero.");
    }
    else
    {
        resultado = a / b;

        Console.WriteLine($"{a} dividido por {b} é {resultado}");
    }

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

void CalcularExp()
{
    double a, b, resultado;

    Console.WriteLine("--- Exponenciação ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = Math.Pow(a,b);

    Console.WriteLine($"{a} elevado a {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

void CalcularRad()
{
    double radicando, indice;

    Console.WriteLine("--- Radiciação ---\n");
    Console.WriteLine("Digite os valores.");

    Console.Write("Radicando = ");
    radicando = Convert.ToDouble(Console.ReadLine());
    Console.Write("Indice = ");
    indice = Convert.ToDouble(Console.ReadLine());

    if (radicando < 0)
    {
        throw new Exception("O radicando deve ser maior ou igual a zero");
    }
    else if (indice <= 0)
    {
        throw new Exception("O indice deve ser maior que zero");
    }
    else
    {
        double raiz = Math.Pow(radicando, 1/ indice);
        Console.WriteLine($"a raíz {radicando} de {indice} é {raiz}");
    }

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}