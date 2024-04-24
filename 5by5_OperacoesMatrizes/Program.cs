// Faça um programa que gere duas matrizes e faça as 4 operações básicas nelas
int qtdLinhas = 5, qtdColunas = 5;
float[,] matriz1 = new float[qtdLinhas, qtdColunas];
float[,] matriz2 = new float[qtdLinhas, qtdColunas];
float[,] resultado = new float[qtdLinhas, qtdColunas];
int option;

void ImprimirMatriz(float[,] matriz, string titulo)
{
    Console.Write("\n\n"+titulo);
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }
}

int menu()
{
    do
    {
        Console.WriteLine("\n\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);

    return option;
}

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

    ImprimirMatriz(matriz1, "Matriz 1");

    ImprimirMatriz(matriz2, "Matriz 2");

    // Somando as matrizes
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            resultado[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
        }
    }

    ImprimirMatriz(resultado, "Soma das matrizes");

    // Subtraindo as matrizes
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            resultado[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
        }
    }

    ImprimirMatriz(resultado, "Subtração das matrizes");

    // Multiplicando as matrizes
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            resultado[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
        }
    }

    ImprimirMatriz(resultado, "Multiplicação das matrizes");

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

    ImprimirMatriz(resultado, "Divisão das matrizes");

    
} while (menu() == 2);