// Faça um programa que gere duas matrizes e faça as 4 operações básicas nelas
int qtdLinhas = 5, qtdColunas = 5;
float[,] matriz1 = new float[qtdLinhas, qtdColunas];
float[,] matriz2 = new float[qtdLinhas, qtdColunas];
float[,] resultado = new float[qtdLinhas, qtdColunas];
int option;

do
{
    Console.Clear();

    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            matriz1[linha, coluna] = new Random().Next(0, 10);
            matriz2[linha, coluna] = new Random().Next(0, 10);
        }
    }

    Console.Write("Matriz 1");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write(matriz1[linha, coluna] + " ");
        }
    }

    Console.Write("\n\nMatriz 2");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write(matriz2[linha, coluna] + " ");
        }
    }

    // Somando as matrizes
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            resultado[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
        }
    }

    Console.Write("\n\nSoma das matrizes");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write(resultado[linha, coluna] + " ");
        }
    }

    // Subtraindo as matrizes
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            resultado[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
        }
    }

    Console.Write("\n\nSubtração das matrizes");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write(resultado[linha, coluna] + " ");
        }
    }

    // Multiplicando as matrizes
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            resultado[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
        }
    }

    Console.Write("\n\nMultiplicação das matrizes");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write(resultado[linha, coluna] + " ");
        }
    }

    // Dividindo as matrizes
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            if (matriz2[linha, coluna] != 0)
                resultado[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
            else
                resultado[linha, coluna] = float.NaN;
        }
    }

    Console.Write("\n\nDivisão das matrizes");
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write($"{resultado[linha, coluna]:0.00} ");
        }
    }

    do
    {
        Console.WriteLine("\n\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);