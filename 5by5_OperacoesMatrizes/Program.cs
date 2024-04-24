// Faça um programa que gere duas matrizes e faça as 4 operações básicas nelas
int qtdLinhas = 3, qtdColunas = 3;
int[,] matriz1 = new int[qtdLinhas, qtdColunas];
int[,] matriz2 = new int[qtdLinhas, qtdColunas];
int[,] resultado = new int[qtdLinhas, qtdColunas];

for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(1, 10);
        matriz2[linha, coluna] = new Random().Next(1, 10);
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
        resultado[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
    }
}

Console.Write("\n\nDivisão das matrizes");
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write(resultado[linha, coluna] + " ");
    }
}